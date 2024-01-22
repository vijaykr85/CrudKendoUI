using CrudKendoUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudKendoUI.Controllers
{
    public class ListController : Controller

    {
        private readonly productContext _productContext;

        public ListController(productContext mycontext)
        {
            this._productContext = mycontext;
        }

        public IActionResult Index() {
        return View();}

        public IActionResult GetData()
        {
            try
            {
                var data = _productContext.productDetails.ToList();
                return Json(data);

            }
            catch (Exception ex) 
            {
                return View();
            }
            
        }
        [HttpPost]
        public IActionResult CreateData(Product pr)
        {

            _productContext.productDetails.Add(pr);
            _productContext.SaveChanges();

            return Json(pr);
        }


        [HttpPost]
        public IActionResult DeleteData(Product pr)
        {
            _productContext.productDetails.Remove(pr);
            _productContext.SaveChanges();

            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult UpdateData(Product pr)
        {
            _productContext.productDetails.Update(pr);
            _productContext.SaveChanges();

            return Json(pr);
        }

        public ActionResult Create()
        {
            return View();
        }




    }

}
