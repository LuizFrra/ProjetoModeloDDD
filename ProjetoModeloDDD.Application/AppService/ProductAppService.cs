using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.AppService
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private IProductService productService;

        public ProductAppService(IProductService productService) : base(productService)
        {
            this.productService = productService;
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return productService.SearchByName(name);
        }
    }
}
