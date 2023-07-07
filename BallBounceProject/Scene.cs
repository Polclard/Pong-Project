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

        public Powerup Powerup  { get; set; }

        public Scene(int formWidth, int formHeight)
        {
            this.formWidth = formWidth;
            this.formHeight = formHeight;
            Players = new List<Player>();
            MainBall = new Ball(new Point(formWidth / 2, formHeight / 2), 20, Color.Red, "random");
            Powerup = null;
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
            
            if(Powerup != null)
            {
                Powerup.Draw(g);
            }
        }

        public void MoveBall()
        {
            MainBall.Move(Players[0], Players[1], formWidth, formHeight);
            Players[1].AIMovement(MainBall, formWidth, formHeight);
            CheckPowerupStatus();
        }

        public int CheckBallStatus()
        {
            return MainBall.CheckScored();
        }
        public void CheckPowerupStatus()
        {
            int hitBy = MainBall.CheckCollisionWithPowerup(Powerup);
            if(hitBy == 1)
            {
                Powerup.Activate(Players[0], Players[1]);
            }
            if(hitBy == 2)
            {
                Powerup.Activate(Players[1], Players[0]);
            }
               
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


        public void CreatePowerup()
        {
            Random rand = new Random();
            int choice = rand.Next(4);
            switch (choice)
            {
                case 0:
                    Powerup = new Powerup("EnlargePaddle", formWidth, formHeight);
                    break;
                case 1:
                    Powerup = new Powerup("ShrinkPaddle", formWidth, formHeight);
                    break;
                case 2:
                    Powerup = new Powerup("EnlargeOpposition", formWidth, formHeight);
                    break;
                case 3:
                    Powerup = new Powerup("ShrinkOpposition", formWidth, formHeight);
                    break;
            }
        }
    }
}
