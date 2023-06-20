﻿using System;
using System.Collections.Generic;
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
        public static int Speed { get; set; } = 10;
        public static int Width = 50;
        public static int Height = 100;

        public Player(Point Coordinates, string Name)
        {
            this.Points = 0;
            this.Coordinates = Coordinates;
            this.Name = Name;
        }


        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(brush, Coordinates.X, Coordinates.Y, Width, Height);
            brush.Dispose();
        }

        public void MoveUp()
        { 
            this.Coordinates = new Point(Coordinates.X, Coordinates.Y - Speed);
        }

        public void MoveDown()
        {
            this.Coordinates = new Point(Coordinates.X, Coordinates.Y + Speed);
        }

        public void AIMovement(Ball MovingBall, int FormWidth, int FormHeight)
        {
            if(Name == "AI")
            {
                if(MovingBall.MovingDirection == Ball.Direction.BottomRight ||
                   MovingBall.MovingDirection == Ball.Direction.TopRight)
                { 
                    Point PointToHit = new Point(Coordinates.X, Coordinates.Y + Height / 2);
                    int Y = MovingBall.Coordinates.Y;
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
