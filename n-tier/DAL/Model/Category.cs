﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
	public class Category
	{
		[Key]
		public int Id { get; set; }	
		public string Name { get; set; }
		public ICollection<News> News { get; set; }
	}
}
