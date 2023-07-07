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
            SpeedY = 5 * (random.Next(0, 2) * 2 - 1);
            
            if(Direction == "right"){
                SpeedX = 5;
            }
            else if(Direction == "left")
            {
                SpeedX = -5;
            }
            else
            {
                SpeedX = 5 * (random.Next(0, 2) * 2 - 1);
            }

        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, CenterCoordinates.X - Radius, CenterCoordinates.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }

        public int CheckCollisionWithPlayer(Player Player_1, Player Player_2)
        {
            if((this.CenterCoordinates.X-Radius < Player_1.Coordinates.X + Player.Width) 
                && ((this.CenterCoordinates.Y + Radius > Player_1.Coordinates.Y) 
                    && (this.CenterCoordinates.Y - Radius < Player_1.Coordinates.Y + Player_1.Height)))
            {
                return 1;
            }
            if ((this.CenterCoordinates.X+Radius > Player_2.Coordinates.X)
                && ((this.CenterCoordinates.Y + Radius > Player_2.Coordinates.Y) 
                    && (this.CenterCoordinates.Y - Radius < Player_2.Coordinates.Y + Player_1.Height)))
            {
                return 2;
            }
            return 0;
        }

        public int CheckCollisionWithPowerup(Powerup powerup)
        {
            if (powerup == null) return 0;

            if ((this.CenterCoordinates.X + Radius > powerup.Coordinates.X)
                && (this.CenterCoordinates.X - Radius < powerup.Coordinates.X + 100)
                && (this.CenterCoordinates.Y + Radius > powerup.Coordinates.Y)
                    && (this.CenterCoordinates.Y - Radius < powerup.Coordinates.Y + 100)
                    && !powerup.Active)
            {
                return SpeedX > 0 ? 1 : 2;
            }
           
            return 0;
        }
        public int CheckScored()
        {
            if (this.CenterCoordinates.X > 1000) return 1;              
            
            if (this.CenterCoordinates.X < 0) return 2;
            
            return 0;
        }

        public void CheckCollision(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            //collision with top wall
            if (this.CenterCoordinates.Y <= 0 && SpeedY < 0)
            {
                SpeedY *= -1;
            }

            //collision with bottom wall
            if (this.CenterCoordinates.Y > Form_Height - Radius && SpeedY > 0)
            {
                SpeedY *= -1;
            }

            //collision with player paddles
            int PlayerCollided = CheckCollisionWithPlayer(Player_1, Player_2);
            if (PlayerCollided > 0)
            {
                //change speedY depending on area of paddle hit
                int TotalSpeed = Math.Abs(SpeedX) + Math.Abs(SpeedY);
                TotalSpeed++;

                //get what player was in contact with the ball
                int PlayerY = Player_1.Coordinates.Y;
                if(PlayerCollided == 2) PlayerY = Player_2.Coordinates.Y;

                //get position of ball relative to the hit player
                int relativeY = this.CenterCoordinates.Y - PlayerY;
                
                //calculate the speed vectors 
                double Yweight = Math.Abs(relativeY - 60) / 60.0;
                SpeedY = (int) (TotalSpeed * Yweight * 0.7);
                SpeedX = TotalSpeed - SpeedY;

                
                //correct direction
                if(PlayerCollided == 2 ) SpeedX *= -1;
                
                if (relativeY < 60) SpeedY *= -1;

               
            }
           
            
        }

        public void Move(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            CenterCoordinates = new Point(CenterCoordinates.X + SpeedX, CenterCoordinates.Y + SpeedY);
            CheckCollision(Player_1, Player_2, Form_Width, Form_Height);
        }
    }
}
