using AutoMapper;
using ProjetoModeloDDD.API.Models;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.API.AutoMapper
{
    public class ApiModelToDomainProfile : Profile
    {
        public ApiModelToDomainProfile()
        {
            CreateMap<ClientModel, Client>().ForMember(p => p.ClientId, o => o.Ignore());
            CreateMap<ProductModel, Product>();
        }
    }
}
