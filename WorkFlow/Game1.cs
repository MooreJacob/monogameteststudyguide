using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WorkFlow
{
   
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player1 p;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

   
        protected override void Initialize()
        {

            
            base.Initialize();
        }

   
        protected override void LoadContent()
        {
            p = new Player1(100, 150);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            p.Loadcontent(GraphicsDevice);
            
        }

 
        protected override void UnloadContent()
        {
          
        }

    
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            p.Update(gameTime);
            base.Update(gameTime);
          
        }

 
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            p.Draw(spriteBatch, gameTime);

            base.Draw(gameTime);
        }
    }
}
