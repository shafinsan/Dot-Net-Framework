using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab3.Controllers
{
	public class NewsController : ApiController
	{
		[HttpGet]
		[Route("api/news/all")]
		public HttpResponseMessage GetAll()
		{
			var data = NewsServices.GetAllWithCategory();
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// news -> ID
		[HttpGet]
		[Route("api/news/{id}")]
		public HttpResponseMessage Get(int id)
		{
			var data = NewsServices.GetWithCategory(id);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// news ->category
		[HttpGet]
		[Route("api/news/category/{categoryId}")]
		public HttpResponseMessage GetByCategory(int categoryId)
		{
			var data = NewsServices.GetByCategory(categoryId);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// news->title
		[HttpGet]
		[Route("api/news/title/{title}")]
		public HttpResponseMessage GetByTitle(string title)
		{
			var data = NewsServices.GetByTitle(title);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// news-> date,category
		[HttpGet]
		[Route("api/news/date/{date}/category/{categoryId}")]
		public HttpResponseMessage GetByDateAndCategory(DateTime date, int categoryId)
		{
			var data = NewsServices.GetByDateAndCategory(date, categoryId);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// news-> title,category
		[HttpGet]
		[Route("api/news/title/{title}/category/{categoryId}")]
		public HttpResponseMessage GetByTitleAndCategory(string title, int categoryId)
		{
			var data = NewsServices.GetByTitleAndCategory(title, categoryId);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// news-> title, date, and category
		[HttpGet]
		[Route("api/news/title/{title}/date/{date}/category/{categoryId}")]
		public HttpResponseMessage GetByTitleDateCategory(string title, DateTime date, int categoryId)
		{
			var data = NewsServices.GetByTitleDateCategory(title, date, categoryId);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}

		// Create news
		[HttpPost]
		[Route("api/news/create")]
		public HttpResponseMessage Create(NewsDto s)
		{
			NewsServices.Create(s);
			return Request.CreateResponse(HttpStatusCode.OK);
		}

		// Update 
		[HttpPut]
		[Route("api/news/update/{id}")]
		public HttpResponseMessage Update(NewsDto s, int id)
		{
			NewsServices.Update(s, id);
			return Request.CreateResponse(HttpStatusCode.OK);
		}

		// Delete
		[HttpDelete]
		[Route("api/news/delete/{id}")]
		public HttpResponseMessage Delete(int id)
		{
			NewsServices.Delete(id);
			return Request.CreateResponse(HttpStatusCode.OK);
		}

	}
}