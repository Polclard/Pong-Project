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
       
        public Point Coordinates { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public Direction MovingDirection { get; set; }
        public int SpeedY { get; set; }
        public int SpeedX { get; set; }
        public enum Direction
        {
            TopRight,
            BottomRight,
            TopLeft,
            BottomLeft,
            Random
        }

        public Ball(Point Coordinates, int Radius, Color color, Direction Direction)
        {
            this.Coordinates = Coordinates;
            this.Radius = Radius;
            this.Color = color;
            this.MovingDirection = Direction;
            SpeedX = 2;
            SpeedY = 2;

            if(Direction == Direction.Random)
            {
                Random randomDirection = new Random();
                int directionIndex = randomDirection.Next(0, 3);

                if (directionIndex == 0)
                    MovingDirection = Direction.TopLeft;
                else if (directionIndex == 1)
                    MovingDirection = Direction.TopRight;
                else if (directionIndex == 2)
                    MovingDirection = Direction.BottomLeft;
                else if (directionIndex == 3)
                    MovingDirection = Direction.BottomRight;
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, Coordinates.X - Radius, Coordinates.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }

        public bool CheckCollisionWithPlayer(Player Player_1, Player Player_2)
        {
            if((this.Coordinates.X-Radius < Player_1.Coordinates.X + Player.Width) &&
                ((this.Coordinates.Y > Player_1.Coordinates.Y) && (this.Coordinates.Y < Player_1.Coordinates.Y + Player.Height)))
            {
                return true;
            }
            if ((this.Coordinates.X+Radius > Player_2.Coordinates.X) &&
                ((this.Coordinates.Y > Player_2.Coordinates.Y) && (this.Coordinates.Y < Player_2.Coordinates.Y + Player.Height)))
            {
                return true;
            }
            return false;
        } 
        public int CheckScored()
        {
            if(this.Coordinates.X > 1000) return 1;              
            
            if (this.Coordinates.X < 0) return 2;
            
            return 0;
        }

        public void ChangeDirection(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            if (this.MovingDirection == Direction.BottomLeft)
            {
                if (this.Coordinates.X < -Radius*2)
                {
                    this.Coordinates = new Point(Form_Width/2, Form_Height/2);
                    this.MovingDirection = Direction.BottomRight;
                }
                if (this.Coordinates.Y > Form_Height - Radius)
                {
                    this.MovingDirection = Direction.TopLeft;
                }
                if(CheckCollisionWithPlayer(Player_1,Player_2))
                {
                    this.MovingDirection = Direction.BottomRight;
                }
            }
            else if (this.MovingDirection == Direction.BottomRight)
            {
                if (this.Coordinates.X > Form_Width+Radius)
                {
                    this.Coordinates = new Point(Form_Width / 2, Form_Height / 2);
                    this.MovingDirection= Direction.BottomLeft;
                }
                if (this.Coordinates.Y > Form_Height - Radius)
                {
                    this.MovingDirection = Direction.TopRight;
                }
                if (CheckCollisionWithPlayer(Player_1, Player_2))
                {
                    this.MovingDirection = Direction.BottomLeft;
                }
            }
            else if (this.MovingDirection == Direction.TopRight)
            {
                if (this.Coordinates.X > Form_Width+Radius)
                {
                    //Player_1.Points += 10;
                    //Player_2.Points -= 10;
                    this.Coordinates = new Point(Form_Width/2, Form_Height/2);
                    this.MovingDirection = Direction.TopLeft;
                }
                if (this.Coordinates.Y < Radius)
                {
                    this.MovingDirection = Direction.BottomRight;
                }
                if (CheckCollisionWithPlayer(Player_1, Player_2))
                {
                    this.MovingDirection = Direction.TopLeft;
                }
            }
            else if (this.MovingDirection == Direction.TopLeft)
            {
                if (this.Coordinates.X < - Radius*2)
                {
                    this.Coordinates = new Point(Form_Width / 2, Form_Height / 2);
                    this.MovingDirection = Direction.TopRight;
                }
                if (this.Coordinates.Y < Radius)
                {
                    this.MovingDirection = Direction.BottomLeft;
                }
                if (CheckCollisionWithPlayer(Player_1, Player_2))
                {
                    this.MovingDirection = Direction.TopRight;
                }
            }
        }

        public void Move(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            if(MovingDirection == Direction.TopLeft)
            {
                SpeedX = -5;
                SpeedY = -5;
                Coordinates = new Point(Coordinates.X + SpeedX, Coordinates.Y + SpeedY);
                ChangeDirection(Player_1,Player_2,Form_Width,Form_Height);
            }
            else if (MovingDirection == Direction.TopRight)
            {
                SpeedX = 5;
                SpeedY = -5;
                Coordinates = new Point(Coordinates.X + SpeedX, Coordinates.Y + SpeedY);
                ChangeDirection(Player_1, Player_2, Form_Width, Form_Height);
            }
            if (MovingDirection == Direction.BottomLeft)
            {
                SpeedX = -5;
                SpeedY = 5;
                Coordinates = new Point(Coordinates.X + SpeedX, Coordinates.Y + SpeedY);
                ChangeDirection(Player_1, Player_2, Form_Width, Form_Height);
            }
            if (MovingDirection == Direction.BottomRight)
            {
                SpeedX = 5;
                SpeedY = 5;
                Coordinates = new Point(Coordinates.X + SpeedX, Coordinates.Y + SpeedY);
                ChangeDirection(Player_1, Player_2, Form_Width, Form_Height);
            }
        }
    }
}
