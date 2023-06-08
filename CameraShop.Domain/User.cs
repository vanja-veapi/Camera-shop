namespace CameraShop.Domain
{
    public class User : Entity, IApplicationUser
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<UserUseCase> UserUseCases { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


        // IApplicationUser properties
        string IApplicationUser.Identity => UserName;
        int IApplicationUser.Id => Id;
        IEnumerable<int> IApplicationUser.UseCaseIds => UserUseCases.Select(x => x.UseCaseId);
        string IApplicationUser.Email => Email;
        bool IApplicationUser.IsAdmin => IsAdmin;
    }
}
