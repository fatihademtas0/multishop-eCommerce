using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using multishop.catalog.Dtos.ProductDtos;
using multishop.catalog.Services.ProductServices;

namespace multishop.catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _ProductService;

		public ProductsController(IProductService ProductService)
		{
			this._ProductService = ProductService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductList()
		{
			var values = await _ProductService.GetAllProductAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdProduct(string id)
		{
			var values = await _ProductService.GetByIdProductAsync(id);
			if (values == null)
			{
				return NotFound();
			}
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			await _ProductService.CreateProductAsync(createProductDto);
			return Ok("Product added successfully !");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProduct(string id)
		{
			var Product = await _ProductService.GetByIdProductAsync(id);

			if (Product == null)
			{
				return NotFound();
			}
			await _ProductService.DeleteProductAsync(id);
			return Ok("Product deleted successfully !");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			await _ProductService.UpdateProductAsync(updateProductDto);
			return Ok("Product updated successfully !");
		}
	}
}
