using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleCityDotNET_Model.Levels
{
    public class EnemyData
    {
        private readonly LinkedList<Tank> _enemies = new LinkedList<Tank>();

        public bool AddEnemy(Tank enemy)
        {
            if(_enemies.Contains(enemy))
                return false;
            _enemies.AddLast(enemy);
            return true;
        }

        public bool RemoveEnemy(Tank enemy)
        {
            if (!_enemies.Contains(enemy))
                return false;
            _enemies.Remove(enemy);
            return true;
        }

        public IEnumerable<Tank> GetAllEnemies()
        {
            return _enemies;
        }
    }
}
