using System;

namespace BattleCityDotNET
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (BattleCity game = new BattleCity())
            {
                game.Run();
            }
        }
    }
#endif
}

