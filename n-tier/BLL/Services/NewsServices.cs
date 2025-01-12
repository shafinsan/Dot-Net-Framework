using AutoMapper;
using BLL.DTO;
using BLL.Services.Utility;
using DAL.Model;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class NewsServices
	{
		private static IMapper _mapper;

		static NewsServices()
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<MappingProfile>();
			});
			_mapper = new Mapper(config);
		}

		// Get all news with categories
		public static List<NewsCategoryDto> GetAllWithCategory()
		{
			var srepo = new ProductRepo();
			var data = srepo.Get();
			var ret = _mapper.Map<List<NewsCategoryDto>>(data);
			return ret;
		}

		// Get news with category by ID
		public static NewsCategoryDto GetWithCategory(int id)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get(id);
			var ret = _mapper.Map<NewsCategoryDto>(data);
			return ret;
		}

		// Create news
		public static void Create(NewsDto s)
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<NewsDto, News>();
			});
			var mapper = new Mapper(config);
			var st = mapper.Map<News>(s);
			var repo = new ProductRepo();
			repo.Create(st);
		}

		// Delete news
		public static void Delete(int id)
		{
			var srepo = new ProductRepo();
			srepo.Delete(id);
		}

		// Update news
		public static void Update(NewsDto s, int id)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get(id);
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<NewsDto, News>();
			});
			var mapper = new Mapper(config);
			var st = mapper.Map<News>(s);
			st.Id = id;
			srepo.Update(st);
		}

		// Get news by category
		public static List<NewsCategoryDto> GetByCategory(int categoryId)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get().Where(n => n.CategoryId == categoryId).ToList();
			return _mapper.Map<List<NewsCategoryDto>>(data);
		}

		// Get news by title
		public static List<NewsCategoryDto> GetByTitle(string title)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get().Where(n => n.Title.Contains(title)).ToList();
			return _mapper.Map<List<NewsCategoryDto>>(data);
		}

		// Get news by date and category
		public static List<NewsCategoryDto> GetByDateAndCategory(DateTime date, int categoryId)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get().Where(n => n.Date.Date == date.Date && n.CategoryId == categoryId).ToList();
			return _mapper.Map<List<NewsCategoryDto>>(data);
		}

		// Get news by title and category
		public static List<NewsCategoryDto> GetByTitleAndCategory(string title, int categoryId)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get().Where(n => n.Title.Contains(title) && n.CategoryId == categoryId).ToList();
			return _mapper.Map<List<NewsCategoryDto>>(data);
		}

		// Get news by title, date, and category
		public static List<NewsCategoryDto> GetByTitleDateCategory(string title, DateTime date, int categoryId)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get().Where(n => n.Title.Contains(title) && n.Date.Date == date.Date && n.CategoryId == categoryId).ToList();
			return _mapper.Map<List<NewsCategoryDto>>(data);
		}
	}
}
