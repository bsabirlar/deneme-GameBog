using GameBog.Abstract;
using GameBog.Adapters;
using GameBog.Concrete;
using GameBog.Entity;
using System;

namespace GameBog
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerCustomerManager gamerCustomerManager = new GamerCustomerManager(new GamerCustomerCheckManager());
            gamerCustomerManager.Insert(new GamerCustomer { FirstName= "Burak" , LastName = "Sabırlar", DateTimeBirth= (new DateTime(1994,04,23)), NationalityId="79218374" });

            Console.WriteLine("---------------Oyun Listesi-----------------");

            GameManager gameManager = new GameManager();
            gameManager.Delete(new GameSale { GameName = "Black of Heart", Id = 2, StockIn = 34, GamePrice = 23 });
            gameManager.Insert(new GameSale { GameName = "Black of Heart2", Id = 3, StockIn = 39, GamePrice = 333 });
            gameManager.Update(new GameSale { GameName = "Black of Heart3", Id = 4, StockIn = 3, GamePrice = 555 });

            Console.WriteLine("---------------Kampanya Listesi-----------------");
            CompanyManager manager = new CompanyManager();
            manager.Update(new Campaigne { CompanyName = "Kampanya yüzde 50 indirimli" }, new GamerCustomer { FirstName = "burak" },
                new GameSale { GameName = "hamiden" });


        }
    }
}
