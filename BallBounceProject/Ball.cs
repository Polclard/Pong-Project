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
        public int Speed { get; set; }
        public enum Direction
        {
            TopRight,
            BottomRight,
            TopLeft,
            BottomLeft, 
        }

        public Ball(Point Coordinates, int Radius, Color color, Direction Direction)
        {
            this.Coordinates = Coordinates;
            this.Radius = Radius;
            this.Color = color;
            this.MovingDirection = Direction;
            Speed = 5;
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
            if ((this.Coordinates.X > Player_2.Coordinates.X) &&
                ((this.Coordinates.Y > Player_2.Coordinates.Y) && (this.Coordinates.Y < Player_2.Coordinates.Y + Player.Height)))
            {
                return true;
            }
            return false;
        }

        public void ChangeDirection(Player Player_1, Player Player_2, int Form_Width, int Form_Height)
        {
            if (this.MovingDirection == Direction.BottomLeft)
            {
                if (this.Coordinates.X < -Radius*2)
                {
                    Player_1.Points -= 10;
                    Player_2.Points += 10;
                    this.Coordinates = new Point(Form_Width/2, Form_Height/2);
                    this.MovingDirection=Direction.BottomRight;
                }
                if (this.Coordinates.Y > Form_Height - Radius * 4)
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
                if (this.Coordinates.X > Form_Width)
                {
                    Player_1.Points += 10;
                    Player_2.Points -= 10;
                    this.Coordinates = new Point(Form_Width / 2, Form_Height / 2);
                    this.MovingDirection= Direction.BottomLeft;
                }
                if (this.Coordinates.Y > Form_Height - 4*Radius)
                {
                    this.MovingDirection = Direction.TopRight;
                }
                if (CheckCollisionWithPlayer(Player_1, Player_2))
                {
                    this.MovingDirection = Direction.TopRight;
                }
            }
            else if (this.MovingDirection == Direction.TopRight)
            {
                if (this.Coordinates.X > Form_Width)
                {
                    Player_1.Points += 10;
                    Player_2.Points -= 10;
                    this.Coordinates = new Point(Form_Width/2, Form_Height/2);
                    this.MovingDirection = Direction.TopLeft;
                }
                if (this.Coordinates.Y < Radius)
                {
                    this.MovingDirection = Direction.BottomRight;
                }
                if (CheckCollisionWithPlayer(Player_1, Player_2))
                {
                    this.MovingDirection = Direction.BottomRight;
                }
            }
            else if (this.MovingDirection == Direction.TopLeft)
            {
                if (this.Coordinates.X < -Radius*2)
                {
                    Player_1.Points -= 10;
                    Player_2.Points += 10;
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
                Coordinates = new Point(Coordinates.X - Speed, Coordinates.Y - Speed);
                ChangeDirection(Player_1,Player_2,Form_Width,Form_Height);
            }
            else if (MovingDirection == Direction.TopRight)
            {
                Coordinates = new Point(Coordinates.X + Speed, Coordinates.Y - Speed);
                ChangeDirection(Player_1, Player_2, Form_Width, Form_Height);
            }
            if (MovingDirection == Direction.BottomLeft)
            {
                Coordinates = new Point(Coordinates.X - Speed, Coordinates.Y + Speed);
                ChangeDirection(Player_1, Player_2, Form_Width, Form_Height);
            }
            if (MovingDirection == Direction.BottomRight)
            {
                Coordinates = new Point(Coordinates.X + Speed, Coordinates.Y + Speed);
                ChangeDirection(Player_1, Player_2, Form_Width, Form_Height);
            }
        }
    }
}
