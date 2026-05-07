using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace Summative_Breakout
{
    public class Paddle
    {
        private Rectangle _location;
        private Vector2 _speed;
        private Texture2D _texture;
        private Texture2D paddleTexture;
        private Rectangle rectangle;
        private Vector2 vector2;
        public void Inizialize()
        {
            _location = new Rectangle(0, 0, 10, 10);

        }

        public void Update(MouseState mouseState, GameTime gameTime)
        {
            _location.X = mouseState.X;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(_texture, _location, Color.White);

            spriteBatch.End();
        }
    }

}
