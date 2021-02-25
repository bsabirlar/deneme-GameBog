using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Abstract
{
    interface ICampaigneService
    {
        void CompanyAdd(Campaigne campaigne, GamerCustomer gamerCustomer, GameSale gameSale);
        void Update(Campaigne campaigne, GamerCustomer gamerCustomer, GameSale gameSale);
        void Delete(Campaigne campaigne, GamerCustomer gamerCustomer, GameSale gameSale);
    }
}
