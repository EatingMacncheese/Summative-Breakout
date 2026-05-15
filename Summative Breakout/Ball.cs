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
    public class Ball
    {
        
        private Rectangle _location;
        private Vector2 _speed;
        private Texture2D _texture;


        public Ball(Texture2D texture, Rectangle location)
        {
            _location = location;
            _texture = texture;
            _speed = new Vector2(2, 4);
           

        }

        public void Update(Rectangle window)
        {
            _location.X += (int)_speed.X;
            if (_location.Right > window.Width || _location.Left < 0)
            {
                _speed.X *= -1;
            }
            _location.Y += (int)_speed.Y;
            if (_location.Top < window.Top)
            {
                _speed.Y = 4;
            }
            else if (_location.Bottom > window.Height)
                _speed.Y *= -1;  


            if (_location.Bottom < )
            {

            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture, _location, Color.White);

        }

    }
}
