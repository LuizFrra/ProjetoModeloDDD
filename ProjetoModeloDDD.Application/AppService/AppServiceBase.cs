using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.AppService
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private IServiceBase<TEntity> serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public int Add(TEntity obj)
        {
            return serviceBase.Add(obj);
        }

        public ICollection<TEntity> GetAll()
        {
            return serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return serviceBase.GetById(id);
        }

        public int Remove(TEntity obj)
        {
            return serviceBase.Remove(obj);
        }

        public int Update(TEntity obj)
        {
            return serviceBase.Update(obj);
        }
    }
}
