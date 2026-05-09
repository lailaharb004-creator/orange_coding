using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Simple_Ecommerce_Project.DataContext;
using Simple_Ecommerce_Project.Models;

[Authorize(Roles = "Admin")]
public class ProductController : Controller

{
    private readonly EcommerceDbContext _db;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public ProductController(EcommerceDbContext db , IWebHostEnvironment  webHostEnvironment)
    {
        _db = db;
        _webHostEnvironment = webHostEnvironment;
    }

    #region Admin Actions (CRUD)

    // 1. عرض كل المنتجات للآدمن (جدول الإدارة)
    public IActionResult Index()
    {
        var products = _db.Products.Include(u => u.Category).ToList();
        return View(products);
    }

    // 2. صفحة الإضافة
    public IActionResult Create()
    {
        ViewBag.CategoryList = GetCategoryList();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Product obj, IFormFile? file)
    {
        if (file != null)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string productPath = Path.Combine(wwwRootPath, @"images\products");

            if (!Directory.Exists(productPath)) Directory.CreateDirectory(productPath);

            using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            obj.ImageUrl = @"\images\products\" + fileName;
        }

        // حذفنا شرط الـ ModelState.IsValid مؤقتاً للتجربة
        _db.Products.Add(obj);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    // 3. صفحة التعديل
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0) return NotFound();

        var productFromDb = _db.Products.Find(id);
        if (productFromDb == null) return NotFound();

        ViewBag.CategoryList = GetCategoryList();
        return View(productFromDb);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Product obj , IFormFile? file)
    {
        if (file != null)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string productPath = Path.Combine(wwwRootPath, @"images\products");

            if (!Directory.Exists(productPath)) Directory.CreateDirectory(productPath);

            using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            // تعبئة خاصية الصورة بالمسار لكي ينجح الـ Validation
            obj.ImageUrl = @"\images\products\" + fileName;
        }
        if (ModelState.IsValid)
        {
            _db.Products.Update(obj);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(obj);
    }

    // 4. الحذف
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0) return NotFound();
        var productFromDb = _db.Products.Include(u => u.Category).FirstOrDefault(u => u.ProductId == id);
        return View(productFromDb);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePost(int? id)
    {
        var obj = _db.Products.Find(id);
        if (obj == null) return NotFound();

        _db.Products.Remove(obj);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Customer Actions

    // 5. صفحة المنتجات للزبائن (مسموحة للجميع)
    [AllowAnonymous]
    public IActionResult ByCategory(int categoryId)
    {
        // أضيفي سطر للـ Debugging أو فحص الـ ID
        if (categoryId == 0) return NotFound();

        var products = _db.Products
            .Include(u => u.Category) // لضمان جلب بيانات القسم المرتبط
            .Where(p => p.ProductCategoryId == categoryId)
            .ToList();

        var category = _db.Categories.Find(categoryId);
        ViewBag.CategoryName = category?.CategoryName ?? "Products";

        return View("CustomerProducts", products);
    }

    #endregion

    // Helper Method لتكرار القائمة المنسدلة
    private IEnumerable<SelectListItem> GetCategoryList()
    {
        return _db.Categories.Select(i => new SelectListItem
        {
            Text = i.CategoryName,
            Value = i.CategoryId.ToString()
        });
    }
}
