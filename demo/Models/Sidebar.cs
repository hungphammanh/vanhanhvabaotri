using demo.Data;
using Microsoft.AspNetCore.Mvc;

namespace demo.Models
{
	public class Sidebar:ViewComponent
	{
		private readonly demoContext _context;

		public Sidebar(demoContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
