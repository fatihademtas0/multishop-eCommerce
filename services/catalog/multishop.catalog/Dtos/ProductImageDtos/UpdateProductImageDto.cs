﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace multishop.catalog.Dtos.CategoryDtos
{
	public class UpdateProductImageDto
	{
		public string? ProductImageId { get; set; }
		public string? Image1 { get; set; }
		public string? Image2 { get; set; }
		public string? Image3 { get; set; }
		public string? ProductId { get; set; }
	}
}
