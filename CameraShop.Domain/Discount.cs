namespace CameraShop.Domain
{
    public class Discount : Entity
    {
        public decimal DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? CameraId { get; set; }
        public int? BrandId { get; set; }
        public virtual Camera Camera { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
