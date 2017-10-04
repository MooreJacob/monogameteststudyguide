using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow
{
    class Player1
    {
        private Texture2D solidTexture;
        private GraphicsDevice spriteBatch;
        private Rectangle p;
        private int y;
        private int x;

        public void Loadcontent()
        {
            solidTexture = new Texture2D(spriteBatch, 1, 1);
            
            solidTexture.SetData(new Color[] { Color.White });
            p = new Rectangle(x, y , 150, 150);
        }

    
        public void update()
        {
            KeyboardState state = Keyboard.GetState();

            bool leftArrowKeyDown = state.IsKeyDown(Keys.Left);

            if (state.IsKeyDown(Keys.Left))
            {
                x -= 5;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                x += 5;
            }
            if (state.IsKeyDown(Keys.Up))
            {
                y -= 5;
            }
            if (state.IsKeyDown(Keys.Down))
            {
                y += 5;
            }
        }

        public void Draw(SpriteBatch sb,GameTime gt)
        {
            sb.Begin();

            Draw(sb, gt);

            sb.End();

        }


    }

}
