﻿using multishop.catalog.Dtos.CategoryDtos;
using multishop.catalog.entities;

namespace multishop.catalog.Services.CategoryServices
{
	public interface ICategoryService
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();

		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);

		Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);

		Task DeleteCategoryAsync(string id);
	}
}
