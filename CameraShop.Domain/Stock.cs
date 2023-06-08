namespace CameraShop.Domain
{
    public class Stock : Entity
    {
        public int CameraId { get; set; }
        public int QuantityInStock { get; set; }
        public virtual Camera Camera { get; set; }
    }
}
