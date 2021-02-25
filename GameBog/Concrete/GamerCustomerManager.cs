using GameBog.Abstract;
using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Concrete
{
    class GamerCustomerManager : IGamerCustomerService
    {
        private IGamerCustomerCheckService _gamerCustomerCheckService;

        public GamerCustomerManager(IGamerCustomerCheckService gamerCustomerCheckService)
        {
            _gamerCustomerCheckService = gamerCustomerCheckService;
        }
        public void Delete(GamerCustomer gamerCustomer)
        {
            Console.WriteLine("Silme işlemi başarılı");
        }

        public void Insert(GamerCustomer gamerCustomer)
        {
            if (_gamerCustomerCheckService.IfNationalId(gamerCustomer)==true)
            {
                Console.WriteLine("Insert işlemi başarılı" + gamerCustomer.FirstName + _gamerCustomerCheckService.IfNationalId(gamerCustomer));
            }
            else
            {
                Console.WriteLine("işlem başarısız");
            }
        }

        public void Update(GamerCustomer gamerCustomer)
        {
            Console.WriteLine("Update işlemi başarılı");
        }
    }
}
