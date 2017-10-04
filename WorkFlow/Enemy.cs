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
    public class Enemy
    {
        private Texture2D solidTexture;
        private Rectangle box;
        private int x;
        private int y;
    public Enemy(int a, int b)
        {
            int x = a;
            int y = b;
        }
     public void LoadContent(GraphicsDevice graphics)
        {
            solidTexture = new Texture2D(graphics, 1, 1);
            solidTexture.SetData(new Color[] { Color.White });
            box = new Rectangle(x, y, 50, 50);
        }

    public void Initialize()
        {
            Initialize();
        }
    }
}
