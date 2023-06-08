using CameraShop.Domain;
using CameraShop.EfDataAccess.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace CameraShop.EfDataAccess.Extenssions
{
    public static class DbSetExtensions
    {
        public static void Deactivate(this DbContext context, Entity entity)
        {
            entity.IsActive = false;
            context.Entry(entity).State = EntityState.Modified;
        }

        public static void Deactivate<T>(this DbContext context, int id)
            where T : Entity
        {
            var itemToDeactivate = context.Set<T>().Find(id);

            if (itemToDeactivate is null)
            {
                throw new EntityNotFoundException(id, typeof(T));
            }

            itemToDeactivate.IsActive = false;
            context.SaveChanges();
        }

        public static void Deactivate<T>(this DbContext context, IEnumerable<int> ids)
            where T : Entity
        {
            var toDeactivate = context.Set<T>().Where(x => ids.Contains(x.Id));

            //var nonExistingIds = ids.Except(toDeactivate.Select(x => x.Id));

            foreach (var d in toDeactivate)
            {
                d.IsActive = false;
            }

        }

    }
}
