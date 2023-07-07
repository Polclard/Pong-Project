using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BallBounceProject
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Point Coordinates { get; set; }
        public int fieldHeight { get; set; }
        public static int Speed { get; set; } = 10;
        public static int Width = 30;
        public int Height { get; set; }

        public Player(Point Coordinates, string Name, int fieldHeight)
        {
            this.Points = 0;
            this.Coordinates = Coordinates;
            this.Name = Name;
            this.fieldHeight = fieldHeight;
            this.Height = 120;
        }


        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(brush, Coordinates.X, Coordinates.Y, Width, Height);
            brush.Dispose();
        }

        public void MoveUp()
        {   
            if(this.Coordinates.Y > 0)
            {
                this.Coordinates = new Point(Coordinates.X, Coordinates.Y - Speed);
            }
            
        }

        public void MoveDown()
        {   
            if(this.Coordinates.Y < fieldHeight-Height) { 
                this.Coordinates = new Point(Coordinates.X, Coordinates.Y + Speed);
            }
        }

        public void AIMovement(Ball MovingBall, int FormWidth, int FormHeight)
        {
            if(Name != "Player1" && Name !="Player2")
            {
                int XThreshold = 0;

                if(Name == "Easy")  XThreshold = FormWidth - (FormWidth / 3);
                
                if(MovingBall.SpeedX > 0 && MovingBall.CenterCoordinates.X > XThreshold)
                { 
                    Point PointToHit = new Point(Coordinates.X, Coordinates.Y + Height / 2);
                    int Y = MovingBall.CenterCoordinates.Y;
                    if (PointToHit.Y > Y && Math.Abs(PointToHit.Y - Y) > 10)
                    {
                        MoveUp();
                    }
                    else if (PointToHit.Y < Y && Math.Abs(PointToHit.Y - Y) > 10)
                    {
                        MoveDown();
                    }
                }

                if(Name == "Hard" && MovingBall.SpeedX < 0)
                {
                    Point PointToHit = new Point(Coordinates.X, Coordinates.Y + Height / 2);
                    int Y = FormHeight/2;
                    if (PointToHit.Y > Y)
                    {
                        MoveUp();
                    }
                    else if (PointToHit.Y < Y)
                    {
                        MoveDown();
                    }
                }
            }
        }
    }
}
