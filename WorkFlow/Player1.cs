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
        private Rectangle box;
        private int y;
        private int x;


        public Player1(int a, int b)
        {
            x = a;
            b = y;

        }

        public void Loadcontent(GraphicsDevice gd)
        {
            solidTexture = new Texture2D(gd, 1, 1);
            
            solidTexture.SetData(new Color[] { Color.White });
            box = new Rectangle(x, y , 150, 150);
        }

        
        public void Initialize()
        {
            Initialize();
        }


        public void Update(GameTime gt)
        {
            KeyboardState state = Keyboard.GetState();

            bool leftArrowKeyDown = state.IsKeyDown(Keys.Left);
            bool RightArrowKeyDown = state.IsKeyDown(Keys.Right);
            bool UpArrowKeyDown = state.IsKeyDown(Keys.Up);
            bool DownArrowKeyDown = state.IsKeyDown(Keys.Down);

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
            Update(gt);
        }

        public void Draw(SpriteBatch sb, GameTime gt)
        {
            sb.Begin();

            sb.Draw(solidTexture, box, Color.Red);

            sb.End();

        }


    }

}
