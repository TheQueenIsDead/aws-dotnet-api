using DemoAwsApp.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DemoAwsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private ProductService _productService;
        
        public ProductController()
        {
           _productService = new ProductService();
        }
        
        // GET api/product
        [HttpGet]
        public ActionResult<Product> Get()
        {

            var results = _productService.GetFirst();

            return results;
        }
        
    }
}