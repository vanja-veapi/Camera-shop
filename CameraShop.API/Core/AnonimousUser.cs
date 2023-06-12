using CameraShop.Domain;

namespace CameraShop.API.Core
{
    public class AnonimousUser : IApplicationUser
    {
        public string Identity => "Anonymous";

        public int Id => 0;

        public IEnumerable<int> UseCaseIds => new List<int>
        {

        };

        public string Email => "anonimous@asp-api.com";

        public bool IsAdmin => false;
    }
}
