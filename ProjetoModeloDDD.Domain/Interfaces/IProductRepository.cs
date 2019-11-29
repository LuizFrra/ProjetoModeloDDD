using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
