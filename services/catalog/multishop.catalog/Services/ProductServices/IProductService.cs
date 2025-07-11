using multishop.catalog.Dtos.ProductDtos;

namespace multishop.catalog.Services.ProductServices
{
	public interface IProductService
	{
		Task<List<ResultProductDto>> GetAllProductAsync();

		Task CreateProductAsync(CreateProductDto createProductDto);
		Task UpdateProductAsync(UpdateProductDto updateProductDto);

		Task<GetByIdProductDto> GetByIdProductAsync(string id);

		Task DeleteProductAsync(string id);
	}
}
