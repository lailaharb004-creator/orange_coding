using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Simple_Ecommerce_Project.DataContext;
using Simple_Ecommerce_Project.Models;

namespace Simple_Ecommerce_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly EcommerceDbContext ecommerceDbContext;
        public CategoryController(EcommerceDbContext ecommerceDbContext, IWebHostEnvironment webHostEnvironment)
        {
            this.ecommerceDbContext = ecommerceDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
       

        public IActionResult Index()
        {
            List<Category> objCategoryList = ecommerceDbContext.Categories.ToList();
            return View(objCategoryList);
        }
        ////////////////////////////////////////////////////////////////
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
          
                    string categoryPath = Path.Combine(wwwRootPath, @"images\category");

              
                    if (!Directory.Exists(categoryPath))
                        Directory.CreateDirectory(categoryPath);

                    using (var fileStream = new FileStream(Path.Combine(categoryPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    category.ImageUrl = @"\images\category\" + fileName;
                }
                ecommerceDbContext.Categories.Add(category);
                ecommerceDbContext.SaveChanges();
                TempData["success"] = "Successfully Added !";
                return RedirectToAction("Index");
            }
            return View(category);
        }
        ////////////////////////////////////////////////////////////////
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id )
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

          
            var categoryFromDb = ecommerceDbContext.Categories.Find(id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
              
       
                        string wwwRootPath = _webHostEnvironment.WebRootPath;
                        if (file != null)
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                            string categoryPath = Path.Combine(wwwRootPath, @"images\category");

                            
                            if (!string.IsNullOrEmpty(category.ImageUrl))
                            {
                                var oldImagePath = Path.Combine(wwwRootPath, category.ImageUrl.TrimStart('\\'));
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                           
                            using (var fileStream = new FileStream(Path.Combine(categoryPath, fileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                            }
                            category.ImageUrl = @"\images\category\" + fileName;
                        }

                        ecommerceDbContext.Categories.Update(category);
                        ecommerceDbContext.SaveChanges();
                       TempData["success"] = "Successfully Edited !";
                return RedirectToAction("Index");
                    }
                    return View(category);
                }

        ////////////////////////////////////////////////////////////////////////////
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = ecommerceDbContext.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public IActionResult DeletePOST(int? id)
        {
            var obj = ecommerceDbContext.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            ecommerceDbContext.Categories.Remove(obj); 
            ecommerceDbContext.SaveChanges();
            TempData["success"] = "Successfully Deleted!";
            return RedirectToAction("Index");
        }

        ////////////////////////////////////////////////////////////////////////////////////
        
        public IActionResult CustomerIndex()

        {
            List<Category> objCategoryList = ecommerceDbContext.Categories.ToList();
            return View(objCategoryList);
        }


























    }
}
