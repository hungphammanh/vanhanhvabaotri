using demo.Data;
using Microsoft.AspNetCore.Mvc;

namespace demo.Models
{
	public class Search: ViewComponent
	{
		private readonly demoContext _context;

		public Search(demoContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
