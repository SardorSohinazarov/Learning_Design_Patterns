
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

public class OutboxPublisher : BackgroundService
{
    private readonly IServiceProvider _sp;
    private readonly IBus _bus;

    public OutboxPublisher(IServiceProvider sp, IBus bus)
    {
        _sp = sp;
        _bus = bus;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using var scope = _sp.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<OrderDb>();

            var messages = db.OutboxMessages
                .Where(m => !m.Processed)
                .OrderBy(m => m.CreatedAt)
                .Take(10)
                .ToList();

            foreach (var msg in messages)
            {
                try
                {
                    var type = Type.GetType(msg.Type)!;
                    var @event = JsonSerializer.Deserialize(msg.Payload, type)!;

                    await _bus.Publish(@event, stoppingToken);

                    msg.Processed = true;
                    db.SaveChanges();
                }
                catch
                {
                    // Retry keyingi siklda
                }
            }

            await Task.Delay(2000, stoppingToken);
        }
    }
}
