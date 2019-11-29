using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime RegisterDate { get; set; }

        public bool Active { get; set; }

        public ICollection<Product> Products { get; set; }

        public bool PremmiumClient(Client client)
        {
            var ticksPassed = (DateTime.Now - client.RegisterDate.AddYears(5)).Ticks;
            return client.Active && (ticksPassed > 0);
        }
    }
}
