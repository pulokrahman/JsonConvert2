using JsonConvert2Core.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JsonConvert2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> getProducts()
        {
            return Ok(productService.GetProducts().Result);
        }
        [HttpGet("SmartPhone")]
        public async Task<IActionResult> getProductThatIsSmartPhone()
        {
            var l = productService.GetProducts().Result.products;
                var l2=l.Select(product=> product).Where(product => product.category == "smartphones");
            return Ok(l2);
        }
    }
}
