using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return projetoModeloContext.Products.Where(n => n.Name == name);
        }
    }
}
