﻿namespace RPG
{
    using System;
    using Microsoft.Xna.Framework;

#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class GameMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
