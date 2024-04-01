using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand : IRequest<CreateProductResult>
{
    public string Name { get; init; } = default!;
    public string Category { get; init; } = default!;
    public string Summary { get; init; } = default!;
    public string Description { get; init; } = default!;
    public string ImageFile { get; init; } = default!;
    public decimal Price { get; init; }
}

public record CreateProductResult(Guid Id);

public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}