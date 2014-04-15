using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnetizium
{
    public static class ScreenManager
    {
        private static List<Screen> Screens = new List<Screen>();

        public static Screen CurrentScreen
        {
            get
            {
                return Screens.Last();
            }
        }

        public static T GetScreen<T>() where T : Screen
        {
            return (T)Screens.FirstOrDefault(x => x.GetType() == typeof(T));
        }

        public static void LoadScreen<T>(bool onTop = false) where T : Screen
        {
            if (!onTop)
            {
                Screens.ForEach(x => x.Unload());
                Screens.Clear();
            }
            Screen screen = Activator.CreateInstance<T>();
            Screens.Add(screen);
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (Screen screen in Screens)
            {
                GameSettings.GraphicDevice.SetRenderTarget(screen.RenderTarget);
                GameSettings.GraphicDevice.Clear(Color.Transparent);

                spriteBatch.Begin();
                screen.Draw(spriteBatch);
                spriteBatch.End();

                GameSettings.GraphicDevice.SetRenderTarget(null);
            }

            spriteBatch.Begin();
            foreach (Screen screen in Screens)
                spriteBatch.Draw(screen.RenderTarget, Vector2.Zero, Color.White);
            spriteBatch.End();
        }

        public static void Update(GameTime gameTime)
        {
            foreach (Screen screen in Screens)
                screen.Update();
            
        }

    }
}
