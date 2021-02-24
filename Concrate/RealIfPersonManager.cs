using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrate
{
    class RealIfPersonManager : IRealIfPerson
    {
        public bool IfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
