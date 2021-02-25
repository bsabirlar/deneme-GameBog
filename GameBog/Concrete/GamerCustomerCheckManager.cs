using GameBog.Abstract;
using GameBog.Adapters;
using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Concrete
{
    class GamerCustomerCheckManager : IGamerCustomerCheckService
    {
        IGamerCustomerCheckService gamerCustomerCheckManager;
        public bool IfNationalId(GamerCustomer gamerCustomer)
        {
            gamerCustomerCheckManager = new GamerCustomerAdapter();
            return gamerCustomerCheckManager.IfNationalId(gamerCustomer);
        }
    }
}

