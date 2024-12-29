using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
	internal class ProductDbContest:DbContext
	{
		public ProductDbContest() : base("ProductDbContest")
		{
		}

		public DbSet<Product> myProducts { get; set; }
	}
}
