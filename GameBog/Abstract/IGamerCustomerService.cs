using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Abstract
{
    public interface IGamerCustomerService
    {
        void Insert(GamerCustomer gamerCustomer);
        void Delete(GamerCustomer gamerCustomer);
        void Update(GamerCustomer gamerCustomer);
    }
}
