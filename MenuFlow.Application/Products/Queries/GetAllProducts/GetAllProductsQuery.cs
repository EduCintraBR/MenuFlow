using MediatR;
using MenuFlow.Application.DTOs;

namespace MenuFlow.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
    { }
}
