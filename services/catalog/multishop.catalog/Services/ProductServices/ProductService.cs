﻿
using AutoMapper;
using MongoDB.Driver;
using multishop.catalog.Dtos.ProductDtos;
using multishop.catalog.entities;
using multishop.catalog.Settings;

namespace multishop.catalog.Services.ProductServices
{
	public class ProductService : IProductService
	{
		private readonly IMongoCollection<Product> _productCollection;

		private readonly IMapper _mapper;

		public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
			_mapper = mapper;
		}

		public async Task CreateProductAsync(CreateProductDto createProductDto)
		{
			var value = _mapper.Map<Product>(createProductDto);
			await _productCollection.InsertOneAsync(value);
		}

		public async Task DeleteProductAsync(string id)
		{
			await _productCollection.DeleteOneAsync(x => x.ProductId == id);
		}

		public async Task<List<ResultProductDto>> GetAllProductAsync()
		{
			var values = await _productCollection.Find(x => true).ToListAsync();
			return _mapper.Map<List<ResultProductDto>>(values);
		}

		public async Task<GetByIdProductDto> GetByIdProductAsync(string id)
		{
			var value = await _productCollection.Find<Product>(x => x.ProductId== id).FirstOrDefaultAsync();
			return _mapper.Map<GetByIdProductDto>(value);
		}

		public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
		{
			var values = _mapper.Map<Product>(updateProductDto);
			await _productCollection.FindOneAndReplaceAsync(x => x.ProductId== updateProductDto.ProductId, values);
		}
	}
}
