using Microsoft.VisualBasic.Devices;

namespace BallBounceProject
{
    public partial class Form1 : Form
    {
        Scene scene;
        Player Player1;
        Player Player2;
        String Gamemode;

        bool keyWisDown = false;
        bool keySisDown = false;
        bool keyUpIsDown = false;
        bool keyDownIsDown = false;

        bool Pause = true;
        public Form1(string Mode)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new Scene(this.Width, this.Height);
            if (Mode == "PVP") // Player Vs Player
            {
                Player1 = new Player(new Point(10, this.Height / 2 - 120), "Player1", this.Height);
                Player2 = new Player(new Point(this.Width - 40, this.Height / 2 - 120), "Player2", this.Height);
            }
            else // Player Vs Computer
            {
                Player1 = new Player(new Point(10, this.Height / 2 - 120), "Player1", this.Height);
                Player2 = new Player(new Point(this.Width - 40, this.Height / 2 - 120), Mode, this.Height);

                showTutorial("hide");
                showTutorial("PvC");
            }
            scene.AddPlayers(Player1);
            scene.AddPlayers(Player2);
            timer1.Start();
            Gamemode = Mode.ToString();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pause
            if (Pause) return;

            //ball movement
            scene.MoveBall();


            //scoring
            int ballStatus = scene.CheckBallStatus();
            if (ballStatus == 1)
            {
                Player1.Points += 1;
                lblPlayer1Points.Text = Player1.Points.ToString();
                scene.NewRound(1);
                if (Player1.Points > 10)
                {
                    Pause = true;
                    if (MessageBox.Show("Player 1 won! Play Again?", "Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Player1.Points = 0;
                        Player2.Points = 0;
                        lblPlayer1Points.Text = "0";
                        lblPlayer2Points.Text = "0";
                        scene = new Scene(this.Width, this.Height);
                        scene.AddPlayers(Player1);
                        scene.AddPlayers(Player2);
                        lblPauseInfo.Visible = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            if (ballStatus == 2)
            {
                Player2.Points += 1;
                lblPlayer2Points.Text = Player2.Points.ToString();
                scene.NewRound(2);
                if (Player2.Points > 10)
                {
                    Pause = true;
                    if (MessageBox.Show("Player 2 won! Play Again?", "Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Player1.Points = 0;
                        Player2.Points = 0;
                        lblPlayer1Points.Text = "0";
                        lblPlayer2Points.Text = "0";
                        scene = new Scene(this.Width, this.Height);
                        scene.AddPlayers(Player1);
                        scene.AddPlayers(Player2);
                        lblPauseInfo.Visible = true;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }


            //player movement
            if (keyWisDown)
            {
                Player1.MoveUp();
            }
            else if (keySisDown)
            {
                Player1.MoveDown();
            }
            if (Gamemode == "PVP")
            {
                if (keyUpIsDown)
                {
                    Player2.MoveUp();
                }
                else if (keyDownIsDown)
                {
                    Player2.MoveDown();
                }
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Pause = !Pause;
                lblPauseInfo.Visible = Pause;
                showTutorial("hide");
            }


            if (Pause) return;

            if (e.KeyCode == Keys.W)
            {
                keyWisDown = true;
            }
            if (e.KeyCode == Keys.S)
            {
                keySisDown = true;
            }

            if (Gamemode == "PVP")
            {
                if (e.KeyCode == Keys.Up)
                {
                    keyUpIsDown = true;
                }

                if (e.KeyCode == Keys.Down)
                {
                    keyDownIsDown = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape) this.Close();


            if (e.KeyCode == Keys.W)
            {
                keyWisDown = false;
            }
            if (e.KeyCode == Keys.S)
            {
                keySisDown = false;
            }

            if (Gamemode == "PVP")
            {
                if (e.KeyCode == Keys.Up)
                {
                    keyUpIsDown = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    keyDownIsDown = false;
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //make the form dragabble https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void showTutorial(string what)
        {
            if (what == "hide")
            {
                tutBtnWkey.Visible = false;
                tutBtnAkey.Visible = false;
                tutBtnSkey.Visible = false;
                tutBtnDkey.Visible = false;

                tutBtnUpArrow.Visible = false;
                tutBtnDownArrow.Visible = false;
                tutBtnLeftArrow.Visible = false;
                tutBtnRightArrow.Visible = false;

                tutLblHeading.Visible = false;
                tutLblMoreInstructions.Visible = false;
                tutLblPlayer1.Visible = false;
                tutLblPlayer2.Visible = false;
                tutLblPlayer1Instructions.Visible = false;
                tutLblP2Instructions.Visible = false;
            }
            else
            {
                if (what == "PvP")
                {
                    tutBtnUpArrow.Visible = true;
                    tutBtnDownArrow.Visible = true;
                    tutBtnLeftArrow.Visible = true;
                    tutBtnRightArrow.Visible = true;

                    tutLblPlayer2.Visible = true;
                    tutLblP2Instructions.Visible = true;
                }

                tutBtnWkey.Visible = true;
                tutBtnAkey.Visible = true;
                tutBtnSkey.Visible = true;
                tutBtnDkey.Visible = true;

                tutLblHeading.Visible = true;
                tutLblMoreInstructions.Visible = true;

                tutLblPlayer1.Visible = true;
                tutLblPlayer1Instructions.Visible = true;

            }
        }
    }

}


