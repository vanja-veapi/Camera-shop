namespace CameraShop.Domain
{
    public interface IApplicationUser
    {
        public string Identity { get; }
        public int Id { get; }
        public IEnumerable<int> UseCaseIds { get; }
        public string Email { get; }
        public bool IsAdmin { get; }
    }
}
