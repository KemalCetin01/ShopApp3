using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.WebUI.Models;
using ShopApp.Entities;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService) //ctor
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            ////return View(_productService.GetAll());
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });


            //return _productService.GetAll();

        }
    }
}
