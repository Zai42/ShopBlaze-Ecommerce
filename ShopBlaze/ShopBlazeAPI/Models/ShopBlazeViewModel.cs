namespace ShopBlazeAPI.Models
{
    public class ShopBlazeViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string ProductImageName { get; set; }
        public byte[]? ProductImage { get; set; }
    }
}
