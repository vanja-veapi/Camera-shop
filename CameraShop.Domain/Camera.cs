namespace CameraShop.Domain
{
    public class Camera : Entity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public bool IsOnDiscount { get; set; }
        public int BrandId { get; set; }
        public int SensorTypeId { get; set; }
        public double Megapixels { get; set; }
        public string ISO { get; set; }
        public string VideoResolution { get; set; }
        public bool WifiSupport { get; set; }
        public bool BluetoothSupport { get; set; }
        public string LensMount { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual SensorType SensorType { get; set; }
        public virtual ICollection<CameraImage> CameraImages { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

}
