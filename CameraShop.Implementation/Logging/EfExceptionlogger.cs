using CameraShop.Application.Logging;
using CameraShop.Domain;
using CameraShop.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop.Implementation.Logging
{
    public class EfExceptionlogger : EfImplementation, IExceptionLogger
    {
        public EfExceptionlogger(CameraShopDbContext context) : base(context)
        {
        }

        public void Log(Exception ex)
        {
            _context.ExceptionLogs.Add(new ExceptionLog
            {
                Exception = ex.Message,
                ExceptionDateTime = DateTime.UtcNow
            });
            _context.SaveChanges();
        }
    }
    public class EfUseCaseLogger : EfImplementation, IUseCaseLogger
    {
        public EfUseCaseLogger(CameraShopDbContext context) : base(context)
        {
        }

        public void Log(UseCaseLog log)
        {
            _context.UseCaseLogs.Add(log);
            _context.SaveChanges();
        }
    }
}
