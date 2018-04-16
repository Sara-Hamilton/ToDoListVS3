using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListVS3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoListVS3.Controllers
{
    public class ItemsController : Controller
    {
        // GET: /<controller>/
        private ToDoListContext db = new ToDoListContext();
        public IActionResult Index()
        {
            List<Item> model = db.Items.ToList();
            return View(model);
        }
    }
}
