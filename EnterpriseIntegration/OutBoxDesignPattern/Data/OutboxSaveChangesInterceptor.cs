
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text.Json;

public class OutboxSaveChangesInterceptor : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        var context = (OrderDb)eventData.Context!;

        var newEvents = context.ChangeTracker.Entries<Order>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => new Order
            {
                Id = e.Entity.Id,
                Status = e.Entity.Status
            })
            .ToList();

        foreach (var ev in newEvents)
        {
            var outbox = new OutboxMessage
            {
                Id = Guid.NewGuid(),
                Type = typeof(Order).Name,
                Payload = JsonSerializer.Serialize(ev),
                CreatedAt = DateTime.UtcNow,
                Processed = false
            };
            context.OutboxMessages.Add(outbox);
        }

        return base.SavingChanges(eventData, result);
    }
}
