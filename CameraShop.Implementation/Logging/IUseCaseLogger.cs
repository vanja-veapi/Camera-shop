﻿using CameraShop.Domain;

namespace CameraShop.Implementation.Logging
{
    public interface IUseCaseLogger
    {
        void Log(UseCaseLog log);
    }
}
