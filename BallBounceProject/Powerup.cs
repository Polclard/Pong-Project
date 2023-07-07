using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBounceProject
{
    public class Powerup
    {
        public string Power { get; set; }
        public bool Active { get; set; }
        public Point Coordinates { get; set; }
        public Color Color { get; set; }
       

        public Powerup(string power, int FormWidth, int FormHeight)
        {
            Power = power;
            Active = false;

            Color = Power == "EnlargePaddle" || Power == "ShrinkOpposition" ? Color.SpringGreen : Color.DarkOrange;

            Random random = new Random();
            Coordinates = new Point((int)(random.NextDouble() * FormWidth), (int)(random.NextDouble() * FormHeight));
        }

        public void Draw(Graphics g)
        {
            if (Active) return;

            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Coordinates.X, Coordinates.Y, 80, 80);
            b.Dispose();

            Image img = Properties.Resources.Shrink_Powerup;
            if (Power == "EnlargePaddle" || Power == "EnlargeOpposition") img = Properties.Resources.Enlarge_Powerup;
            g.DrawImage(img, Coordinates.X + 15, Coordinates.Y + 15, 50, 50); 
            img.Dispose();
        }


        public void Activate(Player HitBy, Player Opposition)
        {
            Active = true;
            Color = Color.Transparent;
            if(Power == "EnlargePaddle")
            {
                HitBy.Height = 160;
            }
            if(Power == "ShrinkPaddle")
            {
                HitBy.Height = 80;
            }
            if(Power == "EnlargeOpposition")
            {
                Opposition.Height = 160;
            }
            if(Power == "ShrinkOpposition")
            {
                Opposition.Height = 80;
            }
            
        }
        public void Deactivate(Player HitBy, Player Opposition)
        {
            /*if(Power == "EnlargePaddle" || )
            {*/
            Active = false;
            HitBy.Height = 120;
            Opposition.Height = 120;
            //}
        }




    }
}
