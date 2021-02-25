using GameBog.Abstract;
using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Concrete
{
    class CompanyManager : ICampaigneService
    {
        public void CompanyAdd(Campaigne campaigne, GamerCustomer gamerCustomer, GameSale gameSale)
        {
            
            Console.WriteLine(campaigne.CompanyName + " kampanyasından indirimli fiyatınız : %50 oalrak eklendi" );
        }

        public void Delete(Campaigne campaigne, GamerCustomer gamerCustomer, GameSale gameSale)
        {
            Console.WriteLine(campaigne.CompanyName + " kampanyasından indirimli fiyatınız : %50 oalrak silindi");
        }

        public void Update(Campaigne campaigne, GamerCustomer gamerCustomer, GameSale gameSale)
        {
            Console.WriteLine(campaigne.CompanyName + " kampanyasından indirimli fiyatınız : %50 oalrak güncellendi");
        }
    }
}
