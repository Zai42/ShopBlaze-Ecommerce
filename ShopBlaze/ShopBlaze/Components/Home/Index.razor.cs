using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ShopBlaze.Interface;

namespace ShopBlaze.Components.Home
{
    public partial class Index
    {
        [Inject]
        private IShopBlazeRepo _shopBlazeRepo { get; set; }
        private void GetProducts()
        {
                var getData = _shopBlazeRepo.GetProductsData();
        }
        
    }
}
