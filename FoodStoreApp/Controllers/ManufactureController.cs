using FoodStoreApp.Data;
using FoodStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodStoreApp.Controllers
{
    public class ManufactureController : Controller
    {
        // Переменная контекста для доступа к базе данных
        private readonly ApplicationDbContext _db;

        // Внедряем зависимость ApplicationDbContext через конструктор
        public ManufactureController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // Создаем список записей категорий из базы данных
            IEnumerable<Manufacture> manufactureList = _db.Manufacture;
            // Возвращаем загруженный список в представление
            return View(manufactureList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Manufacture cat)
        {

            _db.Manufacture.Add(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            return View();
        }


        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category cat)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(cat);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cat);
        }


            //GET - DELETE
            public IActionResult Delete(int? id)
        {
            return View();
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var cat = _db.Manufacture.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            _db.Manufacture.Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}

