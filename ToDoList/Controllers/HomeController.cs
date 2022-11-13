using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            IEnumerable<list> listOfItem = _context.list;
            
            return View(listOfItem);
        }
        [HttpGet]

        public IActionResult Create()
        {
            list lst = new list();
            return PartialView("ItemModelPartial",lst);
        }
        [HttpPost]

        public IActionResult Create(list lst)
        {
            _context.list.Add(lst);
            _context.SaveChanges();
            return PartialView("ItemModelPartial", lst);
        }

    }
}
