using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleCityDotNETModel.Item;
using BattleCityDotNETModel.Utils;

namespace BattleCityDotNETModel.Levels
{
    public class LevelData
    {
        public ItemData[][] LevelMap { get; set; }

        public ItemData this[Coordinates2D coords]
        {
            get
            {
                return LevelMap[coords.X][coords.Y];
            }

            set
            {
                LevelMap[coords.X][coords.Y] = value;
            }
        }
    }
}
