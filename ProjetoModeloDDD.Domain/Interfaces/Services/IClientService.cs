using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        ICollection<Client> GetSpecialClients(ICollection<Client> clients);
    }
}
