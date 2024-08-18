using Microsoft.AspNetCore.Mvc;
using ShopBlazeAPI.Interface;
using ShopBlazeAPI.Models;

namespace ShopBlazeAPI
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APIController : Controller
    {
        private readonly IShopBlazeRepo _repository;
        public APIController(IShopBlazeRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            //Get Complete Product Detail with Category and Images
            return View(await _repository.ProductsFullDetail());
        }
    }
}
