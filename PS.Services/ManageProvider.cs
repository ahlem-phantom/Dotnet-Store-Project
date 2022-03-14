using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Services
{
   public class ManageProvider
    {
        public List<Provider> lsProviders { get; set; }
        public List<Provider> GetProviderByName(string name)
        {
           /* List<Provider> req = (from p in lsProviders
                                 where p.UserName.Contains(name)
                                 select p).ToList();*/

            //meme requette avec lambda expression
            var req2 = lsProviders.Where(prov => prov.UserName.Contains(name)).ToList();
            return req2;
        }
        
        
        public List<String> GetProviderEmailByName(string name)
        {
            /*List<String> req = (from p in lsProviders
                                  where p.UserName.Contains(name)
                                  select p.Email).ToList();*/
            
            return lsProviders.Where(prov => prov.UserName.Contains(name)).Select(prov => prov.Email).ToList();
        }

        public void DesplayProviderEmailAndPasswordByName(string name)
        {
            /*var req = (from p in lsProviders
                                  where p.UserName.Contains(name)
                                  select (p.Email,p.Password)).ToList();
            foreach(var p in req)
            {
                Console.WriteLine(p);
            }*/
            
            foreach(var p in lsProviders.Where(prov => prov.UserName.Contains(name)).Select(prov => (prov.Email,prov.Password)))
            {
                Console.WriteLine(p);
            }
        }

        public Provider GetFirstProviderByName(string name)
        {
            var req = (from p in lsProviders
                                where p.UserName.StartsWith(name)
                                select p).ToList();
            return req.First();
        }


    }
}
