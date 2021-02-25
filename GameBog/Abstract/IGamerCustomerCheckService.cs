using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Abstract
{
    public interface IGamerCustomerCheckService
    {
        bool IfNationalId(GamerCustomer gamerCustomer );
    }
}
 