﻿using AutoMapper;
using multishop.catalog.Dtos.CategoryDtos;
using multishop.catalog.Dtos.ProductDetailDtos;
using multishop.catalog.Dtos.ProductDtos;
using multishop.catalog.Dtos.ProductImageDtos;
using multishop.catalog.entities;

namespace multishop.catalog.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
			CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();

			CreateMap<Product, ResultProductDto>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, GetByIdProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductDto>().ReverseMap();

			CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();

			CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
			CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
			CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();
			CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
		}
	}
}
