using System;

using Microsoft.AspNetCore.Mvc;

namespace DocsVision.WebClient.Controllers
{
	public class AccountController : Controller
	{
		public AccountController() : base() { }

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
	}
}