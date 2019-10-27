using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DemoAwsApp.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoAwsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private ProductService _productService;
        
        public ValuesController()
        {
           _productService = new ProductService();
        }
        
        // GET api/product/all
        [HttpGet]
        public ActionResult<Product> Get()
        {

            var results = _productService.GetFirst();

            return results;
            
//            return results;
        }
        
    }
}