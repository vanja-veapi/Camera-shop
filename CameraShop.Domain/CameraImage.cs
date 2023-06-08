﻿namespace CameraShop.Domain
{
    public class CameraImage : Entity
    {
        public int CameraId { get; set; }
        public string ImagePath { get; set; }
        public bool IsPrimary { get; set; }
        public virtual Camera Camera { get; set; }
    }
}
