using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrate
{
    class GameSalesManager : IGameSales
    {
        public void Sale(GameSales gameSales, Campaign campaign)
        {
            Console.WriteLine(gameSales.GameName + "adlı oyuns satıldı");
        }
    }
}
