using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class PracticeController : Controller
    {
        private ApplicationDbContext _applicationDbContext;
        public PracticeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // GET: PracticeController
        public ActionResult ProductForm()
        {
            Product productModel = new Product();
            return View(productModel);
        }

        [HttpPost]
        public JsonResult AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                using (_applicationDbContext)
                {
                    DbEntities.Product product = new DbEntities.Product{
                        Name = model.Name,
                        Price = model.Price,
                        Weight = model.Weight,
                        AvailableQuantity = model.AvailableQuantity,
                        Description = model.Description
                    };

                    _applicationDbContext.Add(product);

                    _applicationDbContext.SaveChanges();

                    return Json(product.ProductId);
                }
                
            }
            return Json("invalid");
        }

       
    }
}
