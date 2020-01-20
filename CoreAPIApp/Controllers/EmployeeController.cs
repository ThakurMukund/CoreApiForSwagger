using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Extensions.Logging;

namespace CoreAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
		[HttpGet]
		public HttpResponseMessage EmpXML()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"/Users/hp/Documents/TestAPI/CoreAPIApp/CoreAPIApp/App_Data/EmployeeTest.xml");

			HttpResponseMessage response = new HttpResponseMessage();

			string json = JsonConvert.SerializeXmlNode(doc);
			response.Content = new StringContent(json, Encoding.UTF8, "application/json");

			return response;
		}
	}
}