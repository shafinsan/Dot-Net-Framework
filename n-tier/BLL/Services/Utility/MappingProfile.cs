using AutoMapper;
using BLL.DTO;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Utility
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			// Mapping News to NewsDto
			CreateMap<News, NewsDto>()
				.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

			// Mapping Category to CategoryDto
			CreateMap<Category, CategoryDto>();

			// Mapping News to NewsCategoryDto (combining both News and Category)
			CreateMap<News, NewsCategoryDto>()
				.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
		}
	}
}
