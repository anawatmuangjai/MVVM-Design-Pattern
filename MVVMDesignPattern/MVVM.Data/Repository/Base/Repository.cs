using MVVM.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext context;

        private readonly DbSet<T> objectSet;

        public Repository()
        {
            context = new DatabaseContext();

            objectSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return objectSet.ToList();
        }

        public void Add(T entity)
        {
            objectSet.Add(entity);
            context.SaveChanges();
        }

        public void Deleted(T entity)
        {
            objectSet.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            objectSet.AddOrUpdate(entity);
            context.SaveChanges();
        }
    }
}
