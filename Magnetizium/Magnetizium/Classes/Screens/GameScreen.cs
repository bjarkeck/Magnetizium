using Microsoft.Xna.Framework;
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
            tex = Content.Load<Texture2D>("magBg");
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, new Vector2(0, 0), Color.White);
        }
    }
}
