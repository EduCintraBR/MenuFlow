using MediatR;
using MenuFlow.Application.Products.Queries.GetAllProducts;

namespace MenuFlow.API.Endpoints
{
    public static class ProductEndpoints
    {
        public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/products");

            group.MapGet("", async (IMediator sender, CancellationToken cancellationToken) =>
            {
                var query = new GetAllProductsQuery();
                var products = await sender.Send(query);
                return Results.Ok(products);
            });

            //group.MapGet("/products/{id:guid}", async (Guid id, IProductRepository productRepository, CancellationToken cancellationToken) =>
            //{
            //    var product = await productRepository.GetProductByIdAsync(id, cancellationToken);
            //    return product is not null ? Results.Ok(product) : Results.NotFound();
            //});

            //group.MapPost("/products", async (Product product, IProductRepository productRepository, CancellationToken cancellationToken) =>
            //{
            //    await productRepository.AddAsync(product, cancellationToken);
            //    return Results.Created($"/products/{product.Id}", product);
            //});

            //group.MapPut("/products/{id:guid}", async (Guid id, Product updatedProduct, IProductRepository productRepository, CancellationToken cancellationToken) =>
            //{
            //    if (id != updatedProduct.Id)
            //    {
            //        return Results.BadRequest("Product ID mismatch.");
            //    }
            //    await productRepository.UpdateAsync(updatedProduct, cancellationToken);
            //    return Results.NoContent();
            //});

            //group.MapDelete("/products/{id:guid}", async (Guid id, IProductRepository productRepository, CancellationToken cancellationToken) =>
            //{
            //    var product = await productRepository.GetProductByIdAsync(id, cancellationToken);
            //    if (product is null)
            //    {
            //        return Results.NotFound();
            //    }
            //    await productRepository.DeleteAsync(product, cancellationToken);
            //    return Results.NoContent();
            //});

            return app;
        }
    }
}
