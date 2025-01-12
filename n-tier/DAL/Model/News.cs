﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
	public class News
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }
		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
