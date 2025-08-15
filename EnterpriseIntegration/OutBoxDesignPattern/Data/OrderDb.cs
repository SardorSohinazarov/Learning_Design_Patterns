
using Microsoft.EntityFrameworkCore;

public class OrderDb : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OutboxMessage> OutboxMessages { get; set; }
}
