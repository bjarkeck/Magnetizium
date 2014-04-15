using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnetizium
{
    public class Screen
    {
        public readonly RenderTarget2D RenderTarget;
        public static ContentManager Content;

        private bool unloadScreen = false;

        public bool UnloadScreen
        {
            get { return unloadScreen = false; }
            private set { unloadScreen = value; }
        }

        public void Unload()
        {
            this.UnloadScreen = true;

        }

        public Screen()
        {
            RenderTarget = new RenderTarget2D(GameSettings.GraphicDevice, GameSettings.ScreenWidth, GameSettings.ScreenHeight);
            Color[] colorArr = new Color[GameSettings.ScreenWidth * GameSettings.ScreenHeight];
            for (int i = 0; i < colorArr.Length; i++)
                colorArr[i] = Color.Transparent;
            RenderTarget.SetData(colorArr);

        }

        public virtual void OnUnloadScreen()
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }

        public virtual void Update()
        {
        }
    }

}
