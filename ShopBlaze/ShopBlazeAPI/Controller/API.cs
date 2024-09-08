using Microsoft.AspNetCore.Mvc;
using ShopBlazeAPI.Interface;
using ShopBlazeAPI.Models;

namespace ShopBlazeAPI
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class API : Controller
    {
        private readonly IShopBlazeRepo _repository;
        public API(IShopBlazeRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<List<ShopBlazeViewModel>> GetProducts()
        {
            //Get Complete Product Detail with Category and Images
            return await _repository.ProductsFullDetail();
        }
    }
}
