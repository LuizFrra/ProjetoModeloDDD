using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.AppService
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private IClientService clientService { get; set; }

        public ClientAppService(IClientService clientService) : base(clientService)
        {
            this.clientService = clientService;
        }

        public ICollection<Client> GetSpecialClients(ICollection<Client> clients)
        {
            return clientService.GetSpecialClients(clientService.GetAll());
        }
    }
}
