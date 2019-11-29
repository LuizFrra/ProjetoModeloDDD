using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        ICollection<Client> GetSpecialClients(ICollection<Client> clients);
    }
}
