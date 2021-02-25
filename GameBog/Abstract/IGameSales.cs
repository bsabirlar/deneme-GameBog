using GameBog.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Abstract
{
    interface IGameSales
    {
        void Update(GameSale sale);
        void Delete(GameSale sale);
        void Insert(GameSale sale);
    }
}
