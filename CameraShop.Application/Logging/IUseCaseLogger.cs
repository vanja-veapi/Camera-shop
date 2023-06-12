using CameraShop.Domain;

namespace CameraShop.Application.Logging
{
    public interface IUseCaseLogger
    {
        void Log(UseCaseLog log);
    }
}
