﻿using Microsoft.AspNetCore.Http;

namespace Project.BL.Dtos.SubCategory;
public record SubCategoryUpdateDTO(string Name, string Description, IFormFile image, int categoryId);
