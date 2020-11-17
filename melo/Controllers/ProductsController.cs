using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using melo.Services;
using melo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace melo.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        public JsonFileProductService productService;

        public ProductsController(JsonFileProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }

        
    }
}
