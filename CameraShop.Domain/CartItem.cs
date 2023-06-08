namespace CameraShop.Domain
{

    public class CartItem
    {
        public int CartId { get; set; }
        public int CameraId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Camera Camera { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
