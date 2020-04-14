using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVezba.Server.HubConnection
{
    public class HubShop : Hub
    {
        public async Task ProbnaMetoda()
        {
           await Clients.Caller.SendAsync("KlijentMetoda", "Poruka od servera");
        }
    }
}
