using CameraShop.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop.Implementation
{
    public abstract class EfImplementation
    {
        protected CameraShopDbContext _context { get; }

        protected EfImplementation(CameraShopDbContext context)
        {
            _context = context;
        }

    }
}
