
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestMVCProject.Application.Service;
using TestMVCProject.Domain;


namespace TestMVCProject.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var Products = _productManager.GetAllProducts();
            return View(Products);
        }

        public IActionResult Detail(int id)
        {
            var Product = _productManager.GetProductById(id);

            return View(Product);
        }
    

    }
}


