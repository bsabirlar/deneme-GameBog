using GameBog.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBog.Entity
{
    class GameSale:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int StockIn { get; set; }
        public int GamePrice { get; set; }
    }
}
