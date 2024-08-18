using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopBlazeAPI.Interface;
using ShopBlazeAPI.Models;
using System.Data.SqlClient;


namespace ShopBlazeAPI.ShopBlazeRepositories
{
    public class ShopBlazeRepo : IShopBlazeRepo
    {
        private readonly ShopBlazeEcommerceContext _context;
        public ShopBlazeRepo(ShopBlazeEcommerceContext context)
        {
            _context = context;
        }
        public async Task<List<ShopBlazeViewModel>> ProductsFullDetail()
        {
            var productFullDetail = await (from Product in _context.Products
                                join ProductCategory in _context.ProductCategories
                                on Product.Id equals ProductCategory.ProductId into productCategoryJoin
                                from ProductCategory in productCategoryJoin.DefaultIfEmpty() //For left join
                                join ProductImage in _context.ProductImages
                                on Product.Id equals ProductImage.ProductId into productImageJoin
                                from ProductImage in productImageJoin.DefaultIfEmpty() //For left join
                                select new ShopBlazeViewModel
                                {
                                    ProductId = Product.Id,
                                    ProductName = Product.ProductName,
                                    Category = ProductCategory.CategoryName,
                                    ProductImage = ProductImage.Images
                                }).ToListAsync();
            return productFullDetail;
        }
    }
}
