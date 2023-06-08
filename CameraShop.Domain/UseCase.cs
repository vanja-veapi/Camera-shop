namespace CameraShop.Domain
{
    public class UseCase : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<UserUseCase> UserUseCases { get; set; }
    }
}
