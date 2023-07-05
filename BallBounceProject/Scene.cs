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
            MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, "random");

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

        public int CheckBallStatus()
        {
            return MainBall.CheckScored();
        }

        public void NewRound(int previousRoundWinner)
        {   
            if (previousRoundWinner == 1)
            {
                MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, "right");
            }
            if (previousRoundWinner == 2)
            {
                MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, "left");
            }
        }
    }
}
