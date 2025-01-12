using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
	public class ProductDbContest:DbContext
	{
		public ProductDbContest() : base("ProductDbContest")
		{
		}

		public DbSet<News> News { get; set; }
		public DbSet<Category> Categories { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
			modelBuilder.Entity<Category>()
				.HasKey(c => c.Id);

		
			modelBuilder.Entity<News>()
				.HasKey(n => n.Id);

		
			modelBuilder.Entity<Category>()
				.HasMany(c => c.News)
				.WithRequired(n => n.Category)
				.HasForeignKey(n => n.CategoryId);

			base.OnModelCreating(modelBuilder);

		

		}

	}
	
}
