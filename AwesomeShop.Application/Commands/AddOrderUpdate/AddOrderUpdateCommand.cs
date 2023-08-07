using AwesomeShop.Core.Entities;
using AwesomeShop.Core.Enums;
using MediatR;

namespace AwesomeShop.Application.Commands.AddOrderUpdate;

public class AddOrderUpdateCommand : IRequest<Unit>
{
    public int OrderId { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }

    public OrderUpdated ToEntity()
    {
        return new OrderUpdated(Description, (OrderStatus)Status, OrderId);
    }
}