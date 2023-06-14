using CameraShop.Domain;
using System.Collections.Generic;

namespace CameraShop.API.JWT
{
    public class UnauthorizedActor : IApplicationUser
    {
        public int Id => 0;

        public string Email => "";

        public string Identity => "Unauthorized";

        public IEnumerable<int> UseCaseIds => new List<int> { 6, 7 };

        public bool IsAdmin => false;
    }
}
