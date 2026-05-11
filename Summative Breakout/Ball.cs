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
            _speed = Vector2.Zero;
            

        }

        public void Update()
        {
            

        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture, _location, Color.White);

        }

    }
}
