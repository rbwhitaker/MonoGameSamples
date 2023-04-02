using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameXmlContent
{
    public class XmlContentGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Weapon _weapon;
        private SpriteFont _font;

        public XmlContentGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _weapon = Content.Load<Weapon>("Weapons/Broadsword");
            _font = Content.Load<SpriteFont>("Font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.DrawString(_font, _weapon.Name.ToUpper(), new Vector2(20, 20), Color.White);
            _spriteBatch.DrawString(_font, _weapon.Description, new Vector2(40, 45), Color.LightGray);
            _spriteBatch.DrawString(_font, _weapon.Cost + " gold", new Vector2(40, 70), Color.LightGray);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}