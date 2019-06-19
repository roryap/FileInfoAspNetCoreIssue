using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3
{
	[Route("Test/Home")]
	[ApiController]
	public class HomeController : Controller
	{
		[HttpGet]
		public async Task<ActionResult<Thing>> GetThing()
		{
			return new Thing()
			{
				Name = "First thing",
				File = new FileInfo("c:\file.txt")
			};
		}
	}

	public class Thing
	{
		public string Name { get; set; }

		public FileInfo File { get; set; }
	}
}
