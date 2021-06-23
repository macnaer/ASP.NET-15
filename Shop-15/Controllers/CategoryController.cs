using Microsoft.AspNetCore.Mvc;
using Shop_15.Data;
using Shop_15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_15.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _db.Category;
            return View(categoryList);
        }
    }
}
