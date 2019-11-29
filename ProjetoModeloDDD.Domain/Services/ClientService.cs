using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) : base(clientRepository)
        {
            this._clientRepository = clientRepository;
        }

        public ICollection<Client> GetSpecialClients(ICollection<Client> clients)
        {
            return clients.Where(c => c.PremmiumClient(c)).ToList();
        }
    }
}
