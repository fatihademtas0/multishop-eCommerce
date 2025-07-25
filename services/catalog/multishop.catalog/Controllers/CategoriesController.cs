﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using multishop.catalog.Dtos.CategoryDtos;
using multishop.catalog.Services.CategoryServices;

namespace multishop.catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			this._categoryService = categoryService;
		}

		[HttpGet]
		public async Task<IActionResult> CategoryList()
		{
			var values = await _categoryService.GetAllCategoryAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdCategory(string id)
		{
			var values = await _categoryService.GetByIdCategoryAsync(id);
			if (values == null)
			{
				return NotFound();
			}
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
		{
			await _categoryService.CreateCategoryAsync(createCategoryDto);
			return Ok("Category added successfully !");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCategory(string id)
		{
			var category = await _categoryService.GetByIdCategoryAsync(id);

			if (category == null)
			{
				return NotFound();
			}
			await _categoryService.DeleteCategoryAsync(id);
			return Ok("Category deleted successfully !");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			await _categoryService.UpdateCategoryAsync(updateCategoryDto);
			return Ok("Category updated successfully !");
		}
	}
}
