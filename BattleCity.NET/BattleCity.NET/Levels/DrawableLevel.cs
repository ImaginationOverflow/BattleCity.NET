using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using BattleCityDotNETModel.Levels;
using BattleCityDotNETModel.Utils;
using BattleCityDotNETModel.Item;

namespace BattleCityDotNET.Levels
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class DrawableLevel : Microsoft.Xna.Framework.DrawableGameComponent
    {
        Level _level;

        public DrawableLevel(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            _level = LevelFactory.Singleton.GetLevel(1);

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            var keysPressed = Keyboard.GetState(PlayerIndex.One).GetPressedKeys();

            Coordinates2D currentLocation = _level.PlayerCurrentLocation;
            if (keysPressed.Contains(Keys.Left))
            {
                _level.MovePlayerFromXToY(currentLocation, currentLocation.DecrementY());
            }
            if (keysPressed.Contains(Keys.Right))
            {
                _level.MovePlayerFromXToY(currentLocation, currentLocation.IncrementY());
            }
            if (keysPressed.Contains(Keys.Down))
            {
                _level.MovePlayerFromXToY(currentLocation, currentLocation.DecrementX());
            }
            if (keysPressed.Contains(Keys.Up))
            {
                _level.MovePlayerFromXToY(currentLocation, currentLocation.IncrementX());
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            for (int x = 0; x < _level.Width; ++x)
            {
                for (int y = 0; y < _level.Height; ++y)
                {
                    Coordinates2D coords = new Coordinates2D(x, y);
                    ItemData item = _level.GetItemAt(coords);


                }
            }

            base.Draw(gameTime);
        }
    }
}
