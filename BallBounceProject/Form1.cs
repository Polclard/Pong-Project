using Microsoft.VisualBasic.Devices;

namespace BallBounceProject
{
    public partial class Form1 : Form
    {
        Scene scene;
        Player Player1;
        Player Player2;
        public Form1(string Mode)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene(this.Width, this.Height);
            if(Mode == "PVP") // Player Vs Player
            {
                Player1 = new Player(new Point(10, this.Height / 2 - 50), "Player1");
                Player2 = new Player(new Point(this.Width - 75, this.Height / 2 - 50), "Player2");
            }
            else if (Mode == "PVC") // Player Vs Computer
            {
                Player1 = new Player(new Point(10, this.Height / 2 - 50), "Player1");
                Player2 = new Player(new Point(this.Width - 75, this.Height / 2 - 50), "AI");
            }
            scene.AddPlayers(Player1);
            scene.AddPlayers(Player2);
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.MoveBall();
            this.toolStripStatusLabel1.Text = $"Player 1: {scene.Players[0].Points} Player 2: {scene.Players[1].Points}";
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                foreach (Player player in scene.Players)
                {
                    if (player == Player1)
                    {
                        player.MoveUp();
                    }
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                foreach (Player player in scene.Players)
                {
                    if (player == Player1)
                    {
                        player.MoveDown();
                    }
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            scene.formWidth = this.Width;
            scene.formHeight = this.Height;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'W')
            {
                foreach (Player player in scene.Players)
                {
                    if (player == Player1)
                    {
                        player.MoveUp();
                    }
                }
            }
            else if (e.KeyChar == 'S')
            {
                foreach (Player player in scene.Players)
                {
                    if (player == Player1)
                    {
                        player.MoveDown();
                    }
                }
            }
        }
    }
}