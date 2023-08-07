using MediatR;

namespace AwesomeShop.Application.Queries.GetOrderById;

public class GetOrderByIdQuery : IRequest<GetOrderByIdViewModel>
{
    public GetOrderByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
}