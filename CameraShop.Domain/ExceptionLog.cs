﻿namespace CameraShop.Domain
{
    public class ExceptionLog
    {
        public int Id { get; set; }
        public string ExceptionType { get; set; }
        public string Exception { get; set; }
        public DateTime ExceptionDateTime { get; set; }

    }
}
