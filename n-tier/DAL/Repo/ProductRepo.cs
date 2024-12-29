using DAL.Data;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
	public class ProductRepo
	{
		ProductDbContest db;
		public ProductRepo()
		{
			db = new ProductDbContest();
		}
		public void Create(Product s)
		{
			db.myProducts.Add(s);
			db.SaveChanges();
		}
		public List<Product> Get()
		{
			return db.myProducts.ToList();
		}
		public void Update(Product s)
		{
			var exobj = Get(s.Id);
			db.Entry(exobj).CurrentValues.SetValues(s);
			db.SaveChanges(); ;
		}
		public void Delete(int id)
		{
			var exobj = Get(id);
			db.myProducts.Remove(exobj);

		}
		public Product Get(int id)
		{
			return db.myProducts.Find(id);
		}
	}
}
