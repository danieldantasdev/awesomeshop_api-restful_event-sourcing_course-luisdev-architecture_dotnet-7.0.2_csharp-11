using AwesomeShop.Core.Entities;
using AwesomeShop.Core.Enums;
using AwesomeShop.Core.Repositories;

namespace AwesomeShop.Infrastructure.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<int> Add(Order order)
    {
        return Task.FromResult(new Random().Next(1, 10000));
    }

    public Task AddUpdate(OrderUpdated orderUpdate)
    {
        return Task.CompletedTask;
    }

    public Task<Order> GetById(int id)
    {
        var order = new Order(
            "1234",
            "LuisDev",
            "luisdev@mail.com",
            new List<OrderItem> { new(1, "Product 1", 10.5m, 3) },
            new List<OrderUpdated>
            {
                new("Order Started", OrderStatus.StartedAndPaymentPending, id),
                new("Payment confirmed", OrderStatus.PreparingForDelivery, id),
                new("Order is shipped", OrderStatus.Shipped, id),
                new("Order is delivered", OrderStatus.Delivered, id)
            });

        return Task.FromResult(order);
    }
}