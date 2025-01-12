using DAL.Data;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL.Repo
{
	public class ProductRepo
	{
		ProductDbContest db;
		public ProductRepo()
		{
			db = new ProductDbContest();
		}
		public void Create(News s)
		{
			db.News.Add(s);
			db.SaveChanges();
		}
		public List<News> Get()
		{
			return db.News.Include(n => n.Category).ToList();
		}
		public void Update(News s)
		{
			var exobj = Get(s.Id);
			db.Entry(exobj).CurrentValues.SetValues(s);
			db.SaveChanges(); ;
		}
		public void Delete(int id)
		{
			var exobj = Get(id);
			db.News.Remove(exobj);

		}
		public News Get(int id)
		{
			return db.News.Include(n => n.Category).FirstOrDefault(n => n.Id == id);
		}
	}
}
