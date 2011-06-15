using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCityDotNETModel.Tanks
{
    public abstract class TankTemplate : ITank
    {
        

        public TankTemplate(int life, string name,long id,int damage)
        {
            Life = life;
            Name = name;
            Id = id;
            Damage = damage;
            
        }


        public int Life { get; protected set; }

        public string Name { get; protected set; }

        public long Id { get; protected set; }

        public int Damage { get; protected set; }
    }
}
