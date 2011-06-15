using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCityDotNETModel.Tanks
{
    public class SimpleTank : TankTemplate
    {
        private const int DAMAGE = 25;
        private const int LIFE = 100;

        public SimpleTank(long id, string name) : base(LIFE,name,id,DAMAGE) 
        {
        }


    }
}
