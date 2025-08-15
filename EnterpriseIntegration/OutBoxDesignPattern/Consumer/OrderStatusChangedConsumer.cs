
using MassTransit;

public class OrderStatusChangedConsumer : IConsumer<Order>
{
    public async Task Consume(ConsumeContext<Order> context)
    {
        Console.WriteLine($"[CONSUMER] Order {context.Message.Id} status: {context.Message.Status}");

        await ProcessOrderAsync(context.Message);
    }

    private async Task ProcessOrderAsync(Order message)
    {
        throw new NotImplementedException();
    }
}