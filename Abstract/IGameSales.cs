using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGameSales
    {
        void Sale(GameSales gameSales,Campaign campaign);
    }
}
