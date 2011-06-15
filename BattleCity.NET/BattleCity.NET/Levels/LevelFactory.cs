using System;
using System.Collections.Generic;
using System.Linq;
using BattleCityDotNETModel;
using BattleCityDotNETModel.Tanks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using BattleCityDotNETModel.Levels;
using BattleCityDotNETModel.Item;


namespace BattleCityDotNET.Levels
{
    
    public class LevelFactory
    {
        private static LevelFactory _singletonInstance;

        public static LevelFactory Singleton { 
            get 
            {
                if (_singletonInstance == null)
                    _singletonInstance = new LevelFactory();
                return _singletonInstance;
            } 
        }

        public Level GetLevel(int id)
        {
            LevelData data = new LevelData();
            data.LevelMap = new ItemData[10][] {
                new ItemData[10] { ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.ENEMY, ItemData.EMPTY, ItemData.WATER, ItemData.WATER, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.EMPTY, ItemData.EMPTY, ItemData.WATER, ItemData.WATER, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.EMPTY, ItemData.TOKEN, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.FRIEND, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.EMPTY, ItemData.WALL},
                new ItemData[10] { ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL, ItemData.WALL}
            };

            ITank enemy = new SimpleTank(1, "Enemy 1");
            
            EnemyData enemyData = new EnemyData();
            enemyData.AddEnemy(enemy);

            return new Level(data, enemyData);
        }
    }
}
