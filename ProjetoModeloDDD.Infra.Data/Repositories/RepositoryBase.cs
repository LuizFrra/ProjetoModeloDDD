using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity: class
    {
        protected ProjetoModeloContext projetoModeloContext;

        public RepositoryBase(ProjetoModeloContext projetoModeloContext)
        {
            this.projetoModeloContext = projetoModeloContext;
        }

        public int Add(TEntity obj)
        {
            projetoModeloContext.Set<TEntity>().Add(obj);

            return projetoModeloContext.SaveChanges();
        }

        public ICollection<TEntity> GetAll()
        {
            return projetoModeloContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return projetoModeloContext.Set<TEntity>().Find(id);
        }

        public int Remove(TEntity obj)
        {
            projetoModeloContext.Set<TEntity>().Remove(obj);
            return projetoModeloContext.SaveChanges();
        }

        public int Update(TEntity obj)
        {
            projetoModeloContext.Entry(obj).State = EntityState.Modified;
            return projetoModeloContext.SaveChanges();
        }

    }
}
