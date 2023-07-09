namespace BallBounceProject
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPVP = new Button();
            btnPvC = new Button();
            btnExit = new Button();
            btnOptions = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPVP
            // 
            btnPVP.BackColor = Color.FromArgb(36, 37, 38);
            btnPVP.Cursor = Cursors.Hand;
            btnPVP.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnPVP.FlatAppearance.BorderSize = 2;
            btnPVP.FlatStyle = FlatStyle.Flat;
            btnPVP.Location = new Point(300, 296);
            btnPVP.Margin = new Padding(3, 5, 3, 5);
            btnPVP.Name = "btnPVP";
            btnPVP.Size = new Size(300, 80);
            btnPVP.TabIndex = 0;
            btnPVP.Text = "Player vs Player";
            btnPVP.UseVisualStyleBackColor = false;
            btnPVP.Click += btnPVP_Click;
            // 
            // btnPvC
            // 
            btnPvC.BackColor = Color.FromArgb(36, 37, 38);
            btnPvC.Cursor = Cursors.Hand;
            btnPvC.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnPvC.FlatAppearance.BorderSize = 2;
            btnPvC.FlatStyle = FlatStyle.Flat;
            btnPvC.Location = new Point(300, 392);
            btnPvC.Margin = new Padding(3, 5, 3, 5);
            btnPvC.Name = "btnPvC";
            btnPvC.Size = new Size(300, 80);
            btnPvC.TabIndex = 1;
            btnPvC.Text = "Player Vs Computer";
            btnPvC.UseVisualStyleBackColor = false;
            btnPvC.Click += btnPvC_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(36, 37, 38);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(300, 584);
            btnExit.Margin = new Padding(3, 5, 3, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(300, 80);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button3_Click;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.FromArgb(36, 37, 38);
            btnOptions.Cursor = Cursors.Hand;
            btnOptions.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnOptions.FlatAppearance.BorderSize = 2;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Location = new Point(300, 488);
            btnOptions.Margin = new Padding(3, 5, 3, 5);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(300, 80);
            btnOptions.TabIndex = 4;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pong_Logo_Green_Transparent;
            pictureBox1.Location = new Point(300, 58);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 38);
            ClientSize = new Size(882, 674);
            Controls.Add(pictureBox1);
            Controls.Add(btnOptions);
            Controls.Add(btnExit);
            Controls.Add(btnPvC);
            Controls.Add(btnPVP);
            Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(3, 5, 3, 5);
            Name = "MainMenu";
            Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPVP;
        private Button btnPvC;
        private Button btnExit;
        private Button btnOptions;
        private PictureBox pictureBox1;
    }
}