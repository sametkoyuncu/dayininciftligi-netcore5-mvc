using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> 
        where TEntity:class, new()
    {
        public void Create(TEntity entity)
        {
            using var context = new DayiDbContext();

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            using var context = new DayiDbContext();

            return context.Set<TEntity>().ToList();
        }
        public TEntity GetById(int Id)
        {
            using var context = new DayiDbContext();

            return context.Set<TEntity>().Find(Id);
        }

        public void Update(TEntity entity)
        {
            using var context = new DayiDbContext();

            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new DayiDbContext();

            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }
    }
}
