using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCityDotNET_Model
{
    public class Tank
    {
        public Tank(long id, string name)
        {
            Id = id;
            Name = name;
            Life = 100;
            Damage = 25;
        }

        public int Life { get; private set; }

        public string Name { get; private set; }

        public long Id { get; private set; }

        public int Damage { get; private set; }
    }
}
