namespace CameraShop.Domain
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int CameraId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; }
        public virtual Camera Camera { get; set; }
    }

}
