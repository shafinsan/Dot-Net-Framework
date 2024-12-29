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
	public class ProductController : ApiController
	{
		[HttpGet]
		[Route("api/products/all")]
		public HttpResponseMessage GetAll()
		{
			var data=ProductServices.GetAll();	
			return Request.CreateResponse(HttpStatusCode.OK,data);
		}
		[HttpGet]
		[Route("api/products/{id}")]
		public HttpResponseMessage Get(int id)
		{
			var data = ProductServices.Get(id);
			return Request.CreateResponse(HttpStatusCode.OK, data);
		}
		[HttpPost]
		[Route("api/products/create")]
		public HttpResponseMessage Create(ProductDto s)
		{
			ProductServices.Create(s);
			return Request.CreateResponse(HttpStatusCode.OK);
		}

		[HttpPut]
		[Route("api/products/update/{id}")]
		public HttpResponseMessage Update(ProductDto s,int id)
		{
			ProductServices.Update(s,id);
			return Request.CreateResponse(HttpStatusCode.OK);
		}
		[HttpDelete]
		[Route("api/products/delete/{id}")]
		public HttpResponseMessage Delete(int id)
		{
			ProductServices.Delete(id);
			return Request.CreateResponse(HttpStatusCode.OK);
		}

	}
}