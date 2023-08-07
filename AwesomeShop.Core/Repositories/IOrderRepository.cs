using AwesomeShop.Core.Entities;

namespace AwesomeShop.Core.Repositories;

public interface IOrderRepository
{
    Task<Order> GetById(int id);
    Task<int> Add(Order order);
    Task AddUpdate(OrderUpdated orderUpdate);
}