using multishop.catalog.Dtos.ProductImageDtos;

namespace multishop.catalog.Services.ProductImageServices
{
	public interface IProductImageService
	{
		Task<List<ResultProductImageDto>> GetAllProductImageAsync();

		Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
		Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);

		Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);

		Task DeleteProductImageAsync(string id);
	}
}
