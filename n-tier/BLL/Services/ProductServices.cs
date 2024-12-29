using AutoMapper;
using BLL.DTO;
using DAL.Model;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class ProductServices
	{
		public static List<ProductDto> GetAll()
		{
			var srepo = new ProductRepo();
			var data = srepo.Get();
			var config = new MapperConfiguration(cfg => {
				cfg.CreateMap<Product, ProductDto>();
			});
			var mapper = new Mapper(config); ;
			var ret = mapper.Map<List<ProductDto>>(data);
			return ret;

		}
		public static ProductDto Get(int id)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get(id);
			var config = new MapperConfiguration(cfg => {
				cfg.CreateMap<Product, ProductDto>();
			});
			var mapper = new Mapper(config); ;
			var ret = mapper.Map<ProductDto>(data);
			return ret;

		}
		public static void Create(ProductDto s)
		{
			var config = new MapperConfiguration(cfg => {
				cfg.CreateMap<ProductDto, Product>();
			});
			var mapper = new Mapper(config); ;
			var st = mapper.Map<Product>(s);
			var repo = new ProductRepo();
			repo.Create(st);

		}
		public static void Delete(int id)
		{
			var srepo = new ProductRepo();
			srepo.Delete(id);

		}
		public static void Update(ProductDto s,int id)
		{
			var srepo = new ProductRepo();
			var data = srepo.Get(id);
			var config = new MapperConfiguration(cfg => {
				cfg.CreateMap<ProductDto, Product>();
			});
			var mapper = new Mapper(config); ;
			var st = mapper.Map<Product>(s);
			st.Id = id;
			srepo.Update(st);
		}
	}
}
