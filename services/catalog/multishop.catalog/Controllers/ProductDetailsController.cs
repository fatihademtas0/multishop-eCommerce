using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using multishop.catalog.Dtos.ProductDetailDtos;
using multishop.catalog.Services.ProductDetailService;

namespace multishop.catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductDetailsController : ControllerBase
	{
		private readonly IProductDetailService _ProductDetailService;

		public ProductDetailsController(IProductDetailService ProductDetailService)
		{
			this._ProductDetailService = ProductDetailService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductDetailList()
		{
			var values = await _ProductDetailService.GetAllProductDetailAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdProductDetail(string id)
		{
			var values = await _ProductDetailService.GetByIdProductDetailAsync(id);
			if (values == null)
			{
				return NotFound();
			}
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
		{
			await _ProductDetailService.CreateProductDetailAsync(createProductDetailDto);
			return Ok("Product detail added successfully !");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProductDetail(string id)
		{
			var ProductDetail = await _ProductDetailService.GetByIdProductDetailAsync(id);

			if (ProductDetail == null)
			{
				return NotFound();
			}
			await _ProductDetailService.DeleteProductDetailAsync(id);
			return Ok("Product detail deleted successfully !");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
		{
			await _ProductDetailService.UpdateProductDetailAsync(updateProductDetailDto);
			return Ok("Product detail updated successfully !");
		}
	}
}
