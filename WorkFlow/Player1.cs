using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

        public void Loadcontent()
        {
            solidTexture = new Texture2D(spriteBatch, 1, 1);
            
            solidTexture.SetData(new Color[] { Color.White });
            p = new Rectangle(50, 100, 250, 250);
        }

        public void Draw(SpriteBatch sb)
        {
           

        }

        public void update()
        {

     

        }
        
    }

}
