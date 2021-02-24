using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrate
{
    public class GamerManager : IGamerServices
    {
        IRealIfPerson _realIfPerson;
        public GamerManager(IRealIfPerson realIfPerson)
        {
            _realIfPerson = realIfPerson;
        }
        public void Add(Gamer gamer)
        {
            if (_realIfPerson.IfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " added");
            }
            else
            {
                throw new Exception(gamer.FirstName+"you not real person");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated");
        }
    }
}
