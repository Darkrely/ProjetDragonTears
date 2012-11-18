using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace DragonTears
{
    class ContenuJauge : Jauge
    {
        Rectangle rectangle = new Rectangle(13,-51,196,50);


        #region gestion
        public void Update(int sante, int santeMax, Texture2D jauge, Vector2 position)
        {
            rectangle.Width = (int)(((float)sante / (float)santeMax) * ((float)jauge.Width));
            rectangle.Y = (int)position.Y;

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();
            spritebatch.Draw(jaugeVide, rectangle, Color.White);
            spritebatch.End();
        }
        #endregion gestion

    }
}
