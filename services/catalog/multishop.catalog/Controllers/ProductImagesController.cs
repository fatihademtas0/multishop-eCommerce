using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using multishop.catalog.Dtos.ProductImageDtos;
using multishop.catalog.Services.ProductImageService;

namespace multishop.catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductImagesController : ControllerBase
	{
		private readonly IProductImageService _ProductImageService;

		public ProductImagesController(IProductImageService ProductImageService)
		{
			this._ProductImageService = ProductImageService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductImageList()
		{
			var values = await _ProductImageService.GetAllProductImageAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdProductImage(string id)
		{
			var values = await _ProductImageService.GetByIdProductImageAsync(id);
			if (values == null)
			{
				return NotFound();
			}
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
		{
			await _ProductImageService.CreateProductImageAsync(createProductImageDto);
			return Ok("Product image added successfully !");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProductImage(string id)
		{
			var ProductImage = await _ProductImageService.GetByIdProductImageAsync(id);

			if (ProductImage == null)
			{
				return NotFound();
			}
			await _ProductImageService.DeleteProductImageAsync(id);
			return Ok("Product image deleted successfully !");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
		{
			await _ProductImageService.UpdateProductImageAsync(updateProductImageDto);
			return Ok("Product image updated successfully !");
		}
	}
}
