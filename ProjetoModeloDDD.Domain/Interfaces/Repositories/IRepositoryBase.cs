using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        int Add(TEntity obj);
        
        TEntity GetById(int id);

        ICollection<TEntity> GetAll();

        int Update(TEntity obj);

        int Remove(TEntity obj);
    }
}
