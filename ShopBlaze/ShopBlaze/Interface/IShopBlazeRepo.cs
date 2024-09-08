using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ShopBlaze.Interface
{
    public interface IShopBlazeRepo
    {
        public Task<string> GetProductsData();
    }
}
