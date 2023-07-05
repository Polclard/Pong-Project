using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BallBounceProject
{
    public class Ball
    {
       
        public Point CenterCoordinates { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public int SpeedY { get; set; }
        public int SpeedX { get; set; }
        

        public Ball(Point Coordinates, int Radius, Color color, String Direction)
        {
            this.CenterCoordinates = Coordinates;
            this.Radius = Radius;
            this.Color = color;


            Random random = new Random();
            SpeedY = 5 * (random.Next(0, 1) * 2 - 1);
            
            if(Direction == "right"){
                SpeedX = 5;
            }
            else if(Direction == "left")
            {
                SpeedX = -5;
            }
            else
            {
                SpeedX = 5 * (random.Next(0, 1) * 2 - 1);
            }
            

            
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, CenterCoordinates.X - Radius, CenterCoordinates.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }

        public bool CheckCollisionWithPlayer(Player Player_1, Player Player_2)
        {
            if((this.CenterCoordinates.X-Radius < Player_1.Coordinates.X + Player.Width) 
                && ((this.CenterCoordinates.Y > Player_1.Coordinates.Y) 
                    && (this.CenterCoordinates.Y < Player_1.Coordinates.Y + Player.Height)))
            {
                return true;
            }
            if ((this.CenterCoordinates.X+Radius > Player_2.Coordinates.X)
                && ((this.CenterCoordinates.Y > Player_2.Coordinates.Y) 
                    && (this.CenterCoordinates.Y < Player_2.Coordinates.Y + Player.Height)))
            {
                return true;
            }
            return false;
        } 
        public int CheckScored()
        {
            if(this.CenterCoordinates.X > 1000) return 1;              
            
            if (this.CenterCoordinates.X < 0) return 2;
            
            return 0;
        }

        public void checkCollision(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            //collision with top or bottom wall
            if (this.CenterCoordinates.Y <= 0 || this.CenterCoordinates.Y > Form_Height - Radius)
            {
                SpeedY *= -1;
            }

            //collision with player paddles
            if (CheckCollisionWithPlayer(Player_1, Player_2))
            {
                SpeedX *= -1;
                _ = SpeedX > 0 ? SpeedX++ : SpeedX--;
            }
           
            
        }

        public void Move(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            CenterCoordinates = new Point(CenterCoordinates.X + SpeedX, CenterCoordinates.Y + SpeedY);
            checkCollision(Player_1, Player_2, Form_Width, Form_Height);
        }
    }
}
