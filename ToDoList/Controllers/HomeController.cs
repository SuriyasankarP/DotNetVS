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
        public IActionResult Edit(int id)
        {
            var item1 = _context.list.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("EditModelPartial", item1);
        }
        [HttpPost]
        public IActionResult Edit(list lst)
        {
            _context.list.Update(lst);
            _context.SaveChanges();
            return PartialView("EditModelPartial", lst);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item1 = _context.list.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("DeleteModelPartial", item1);
        }
        [HttpPost]
        public IActionResult Delete(list lst)
        {
            var item1 = _context.list.Where(x => x.Id == lst.Id).FirstOrDefault();
            _context.list.Remove(item1);
            _context.SaveChanges();
            return PartialView("DeleteModelPartial", item1);
        }
    }
}
