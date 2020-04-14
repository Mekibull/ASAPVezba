using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVezba.Shared;

namespace ShopVezba.Server.HubConnection
{
    public class ShopHub2 : Hub
    {
        public async Task PrihvatiPodatke(List<Artikl> list)
        {
            Entity.DB baza = new Entity.DB();
            foreach(Artikl a in list)
            {
                baza.Artikls.Add(a);
            }

            await baza.SaveChangesAsync();
        }

        public async Task DajArtikle()
        {
            Entity.DB baza = new Entity.DB();
            await Clients.Caller.SendAsync("EvoArtikli", baza.Artikls.ToList());

           
        }

       

        
    }
}
