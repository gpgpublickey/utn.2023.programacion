using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp
{
    internal class Park
    {
        private int _qtPeople;
        private int _qtGames;
        private string _name;
        private string _address;

        public int GetPeople()
        {
            return _qtPeople;
        }

        public int GetGames()
        {
            return _qtGames;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetPeople(int people)
        {
            _qtPeople = people;
        }

        public void SetGames(int games)
        {
            _qtGames = games;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAddress(string address)
        {
            _address = address;
        }
    }
}
