using System;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocsVision.WebClient.Controllers
{
	public class HomeController : Controller
	{
		public HomeController() : base() { }

		public IActionResult Index()
		{
			return View();
		}
	}
}