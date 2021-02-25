using GameBog.Abstract;
using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Concrete
{
    class GameManager : IGameSales
    {
        public void Delete(GameSale sale)
        {
            Console.WriteLine("Oyun Silindi" + sale.GameName);
        }

        public void Insert(GameSale sale)
        {
            Console.WriteLine("Oyun eklendi" + sale.GameName);
        }

        public void Update(GameSale sale)
        {
            Console.WriteLine("Oyun güncellendi" + sale.GameName);
        }
    }
}
