using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOLIDPrinciples.Interfaces;

namespace SOLIDPrinciples.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductService _productService;

        public ProductsController(ILogger<BaseController> logger, IProductService productService) : base(logger)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            try
            {
                var products = _productService.GetAllProducts();
                return View(products);
            }
            catch (Exception ex)
            {
                
                return HandleError(ex);
            }
        }
    }
}