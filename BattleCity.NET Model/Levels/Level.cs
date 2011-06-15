using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using BattleCityDotNETModel.Item;
using BattleCityDotNETModel.Utils;

namespace BattleCityDotNETModel.Levels
{
    [Serializable]
    public class Level
    {
        private LevelData _levelData;
        private EnemyData _enemyData;
        public Coordinates2D PlayerCurrentLocation { get; set; }
        public int Width { get { return _levelData.LevelMap.Length; } }
        public int Height { get { return _levelData.LevelMap[0].Length; } }

        public Level(LevelData levelData, EnemyData enemyData)
        {
            _levelData = levelData;
            _enemyData = enemyData;
            PlayerCurrentLocation = GetPlayerLocation(_levelData);
        }
        
        private Coordinates2D GetPlayerLocation(LevelData data)
        {
            for (int x = 0; x < data.LevelMap.Length; ++x)
            {
                for (int y = 0; y < data.LevelMap[x].Length; ++y)
                {
                    Coordinates2D coords = new Coordinates2D(x, y);
                    if (data[coords] == ItemData.FRIEND)
                        return coords;
                }
            }

            return null;
        }

        public bool MoveEnemyFromXToY(Coordinates2D x, Coordinates2D y)
        {
            if (!EnemyAt(x))
                return false;

            if (EmptyAt(y))
            {
                _levelData[y] = _levelData[x];
                return true;
            }

            return false;
        }

        public bool MovePlayerFromXToY(Coordinates2D x, Coordinates2D y)
        {
            if (!PlayerAt(x))
                return false;

            if (EmptyAt(y))
            {
                _levelData[y] = _levelData[x];
                _levelData[x] = ItemData.EMPTY;
                PlayerCurrentLocation = y;
                return true;
            }

            return false;
        }

        public ItemData GetItemAt(Coordinates2D x)
        {
            return _levelData[x];
        }

        private bool ItemTypeAt(Coordinates2D x, ItemData type) 
        {
            if (_levelData[x] == type)
                return true;
            return false;
        }

        private bool PlayerAt(Coordinates2D x)
        {
            return ItemTypeAt(x, ItemData.FRIEND);
        }

        private bool EnemyAt(Coordinates2D x)
        {
            return ItemTypeAt(x, ItemData.ENEMY);
        }

        private bool EmptyAt(Coordinates2D x) 
        {
            return ItemTypeAt(x, ItemData.EMPTY);
        }
    }
}
