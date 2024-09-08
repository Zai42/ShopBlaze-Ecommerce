using Microsoft.AspNetCore.Mvc;
using ShopBlaze.Interface;
namespace ShopBlaze.Repository
{
    public class ShopBlazeRepo : IShopBlazeRepo
    {
        private readonly HttpClient _httpClient;

        public ShopBlazeRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetProductsData()
        {
            var response = await _httpClient.GetAsync($"http://localhost:5250/api/API/GetProducts");
            return "Nothing for now";
        }   
    }
}
