using AutoMapper;
using ProjetoModeloDDD.API.Models;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.API.AutoMapper
{
    public class DomainToApiModelProfile : Profile
    {
        public DomainToApiModelProfile()
        {
            CreateMap<Client, ClientModel>();
            CreateMap<Product, ProductModel>();
        }
    }
}
