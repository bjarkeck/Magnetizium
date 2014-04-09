using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnetizium
{
    public class GameScreen : Screen
    {
        Texture2D tex;
        public GameScreen()
        {
            tex = Content.Load<Texture2D>("asd");
        }
    }
}
