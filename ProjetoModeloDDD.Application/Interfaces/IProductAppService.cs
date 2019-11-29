using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IProductAppService
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
