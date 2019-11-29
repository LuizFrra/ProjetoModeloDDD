using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private IProductRepository _repository;

        public ProductService(IProductRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return _repository.SearchByName(name);
        }
    }
}
