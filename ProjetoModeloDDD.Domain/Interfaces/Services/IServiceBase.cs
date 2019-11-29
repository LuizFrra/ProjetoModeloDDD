using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        int Add(TEntity obj);

        TEntity GetById(int id);

        ICollection<TEntity> GetAll();

        int Update(TEntity obj);

        int Remove(TEntity obj);
    }
}
