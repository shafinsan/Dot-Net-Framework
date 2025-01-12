﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
	public class NewsDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}
