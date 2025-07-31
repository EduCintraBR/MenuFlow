using MediatR;
using MenuFlow.Application.DTOs;
using MenuFlow.Core.Interfaces;

namespace MenuFlow.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>
    {
        private readonly IUnitOfWork _UOW;
        public GetAllProductsQueryHandler(IUnitOfWork UOW)
        {
            _UOW = UOW;
        }

        public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _UOW.Products.GetAllProductsAsync(cancellationToken)
                .ContinueWith(products => products.Result.Select(product => new ProductDto
                {
                    Name = product.Name,
                    Price = product.Price,
                }), cancellationToken);
        }
    }
}
