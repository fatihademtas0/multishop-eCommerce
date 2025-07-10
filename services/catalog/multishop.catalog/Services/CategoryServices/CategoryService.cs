using AutoMapper;
using MongoDB.Driver;
using multishop.catalog.Dtos.CategoryDtos;
using multishop.catalog.entities;
using multishop.catalog.Settings;

namespace multishop.catalog.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		private readonly IMongoCollection<Category>? _categoryCollection;

		private readonly IMapper? _mapper;

		public CategoryService(IMapper? mapper , IDatabaseSettings _databaseSettings)
		{
			_mapper = mapper;
		}

		Task ICategoryService.CreateCategoryAsync(CreateCategoryDto createCategoryDto)
		{
			throw new NotImplementedException();
		}

		Task ICategoryService.DeleteCategoryAsync(string id)
		{
			throw new NotImplementedException();
		}

		Task<List<ResultCategoryDto>> ICategoryService.GetAllCategoryAsync()
		{
			throw new NotImplementedException();
		}

		Task<GetByIdCategoryDto> ICategoryService.GetByIdCategoryAsync(string id)
		{
			throw new NotImplementedException();
		}

		Task ICategoryService.UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
		{
			throw new NotImplementedException();
		}
	}
}
