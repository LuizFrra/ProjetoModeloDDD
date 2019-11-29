using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        int Add(TEntity obj);

        TEntity GetById(int id);

        ICollection<TEntity> GetAll();

        int Update(TEntity obj);

        int Remove(TEntity obj);
    }
}
