using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnetizium
{
    public static class GameSettings
    {
        public static int ScreenWidth = (int)(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width);
        public static int ScreenHeight = (int)(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height);
        public static Vector2 ScreenDimentions
        {
            get
            {
                return new Vector2(ScreenWidth, ScreenHeight);
            }
        }
        public static GraphicsDevice GraphicDevice;
    }
}
