using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBounceProject
{
    public class Scene
    {
        public List<Player> Players { get; set; }
        public Ball MainBall { get; set; }
        public int formWidth { get; set; }
        public int formHeight { get; set; }

        public Scene(int formWidth, int formHeight)
        {
            this.formWidth = formWidth;
            this.formHeight = formHeight;
            Players = new List<Player>();
            Random randomDirection = new Random();
            int directionIndex = randomDirection.Next(0, 3);
            if(directionIndex == 0)
                MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, Ball.Direction.TopLeft);
            else if(directionIndex == 1)
                MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, Ball.Direction.TopRight);
            else if (directionIndex == 2)
                MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, Ball.Direction.BottomLeft);
            else if (directionIndex == 3)
                MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, Ball.Direction.BottomRight);

        }

        public void AddPlayers(Player player)
        {
            this.Players.Add(player);
        }

        public void Draw(Graphics g)
        {
            foreach (var player in this.Players)
            {
                player.Draw(g);
            }
            MainBall.Draw(g);
        }

        public void MoveBall()
        {
            MainBall.Move(Players[0], Players[1], formWidth, formHeight);
            Players[1].AIMovement(MainBall, formWidth, formHeight);
        }

    }
}
