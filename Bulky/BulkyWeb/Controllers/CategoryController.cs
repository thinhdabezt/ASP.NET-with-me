using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db =db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categeries.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category _obj)
        {
            if(_obj.Name == _obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Category Name and Display Order can not be the same!");
                    //add custom error: ModelState.AddModelError("id","error message")
            }
            if (ModelState.IsValid)
            {
                _db.Categeries.Add(_obj);
                _db.SaveChanges();
                //return RedirectToAction("Index","Category");
                //chuyển hướng đến ("action","controller")
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
                //nếu trong cùng 1 controller thì không cần thêm controller cũng đc
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categeries.Find(id);//chỉ nên dùng trên key
            //Category? categoryFromDb1 = _db.Categeries.FirstOrDefault(c => c.Id == id);
            //Category? categoryFromDb2 = _db.Categeries.Where(c => c.Id == id).FirstOrDefault();
            //2 cách dưới có thể modified để phù hợp yêu cầu
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category _obj)
        {
            if (_obj.Name == _obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Category Name and Display Order can not be the same!");
                //add custom error: ModelState.AddModelError("id","error message")
            }
            if (ModelState.IsValid)
            {
                _db.Categeries.Update(_obj);
                _db.SaveChanges();
                //return RedirectToAction("Index","Category");
                //chuyển hướng đến ("action","controller")
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
                //nếu trong cùng 1 controller thì không cần thêm controller cũng đc
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categeries.Find(id);//chỉ nên dùng trên key
            //Category? categoryFromDb1 = _db.Categeries.FirstOrDefault(c => c.Id == id);
            //Category? categoryFromDb2 = _db.Categeries.Where(c => c.Id == id).FirstOrDefault();
            //2 cách dưới có thể modified để phù hợp yêu cầu
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categeries.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            TempData["success"] = "Category deleted successfully";
            _db.Categeries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
