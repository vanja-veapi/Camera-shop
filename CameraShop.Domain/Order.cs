namespace CameraShop.Domain
{
    public class Order : Entity
    {
        public int UserId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }



}
