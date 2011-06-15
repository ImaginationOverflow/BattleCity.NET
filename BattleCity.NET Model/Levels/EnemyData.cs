using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleCityDotNETModel;
using BattleCityDotNETModel.Tanks;

namespace BattleCityDotNETModel.Levels
{
    public class EnemyData
    {
        private readonly LinkedList<ITank> _enemies = new LinkedList<ITank>();

        public bool AddEnemy(ITank enemy)
        {
            if(_enemies.Contains(enemy))
                return false;
            _enemies.AddLast(enemy);
            return true;
        }

        public bool RemoveEnemy(ITank enemy)
        {
            if (!_enemies.Contains(enemy))
                return false;
            _enemies.Remove(enemy);
            return true;
        }

        public IEnumerable<ITank> GetAllEnemies()
        {
            return _enemies;
        }
    }
}
