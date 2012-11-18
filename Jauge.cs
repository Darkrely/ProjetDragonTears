using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.GamerServices;


namespace DragonTears
{
    class Jauge
    {
        public Texture2D jaugeVide;
        public Texture2D JaugeVide
        {
            get { return jaugeVide; }
            set { jaugeVide = value; }
        }

        Vector2 position = new Vector2(10, -51);

        public Vector2 getPosition()
        {
            return position;
        }

        #region fonctions gestion
        public void LoadContent(ContentManager content, string assetName)
        {
            jaugeVide = content.Load<Texture2D>(assetName);
        }

        public void Update(bool combat)
        {
            if (combat == true )
            {
                if(position.Y < 10)
                {
                    position.Y++;
                }
            }
            else if (combat == false && position.Y > -51)
            {
                position.Y--;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(jaugeVide, position, Color.White);
            spriteBatch.End();
        }

        #endregion fonctions gestion

        
    }
}
