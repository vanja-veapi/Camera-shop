namespace CameraShop.Application.UseCases
{
    public interface IQuery<TResult, TRequest> : IUseCase
    {
        TResult Execute(TRequest search);
    }
}
