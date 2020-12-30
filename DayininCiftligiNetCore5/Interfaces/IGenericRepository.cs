using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity:class,new()
    {
        
        void Create(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
