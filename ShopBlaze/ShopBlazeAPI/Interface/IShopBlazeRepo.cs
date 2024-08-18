using ShopBlazeAPI.Models;

namespace ShopBlazeAPI.Interface
{
    public interface IShopBlazeRepo
    {
        public Task<List<ShopBlazeViewModel>> ProductsFullDetail();
    }
}
