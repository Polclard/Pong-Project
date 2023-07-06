namespace BallBounceProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblPlayer1Points = new Label();
            lblPlayer2Points = new Label();
            lblPauseInfo = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // lblPlayer1Points
            // 
            lblPlayer1Points.AutoSize = true;
            lblPlayer1Points.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1Points.Location = new Point(61, 9);
            lblPlayer1Points.Name = "lblPlayer1Points";
            lblPlayer1Points.Size = new Size(36, 40);
            lblPlayer1Points.TabIndex = 1;
            lblPlayer1Points.Text = "0";
            // 
            // lblPlayer2Points
            // 
            lblPlayer2Points.AutoSize = true;
            lblPlayer2Points.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2Points.Location = new Point(934, 9);
            lblPlayer2Points.Name = "lblPlayer2Points";
            lblPlayer2Points.Size = new Size(36, 40);
            lblPlayer2Points.TabIndex = 2;
            lblPlayer2Points.Text = "0";
            // 
            // lblPauseInfo
            // 
            lblPauseInfo.AutoSize = true;
            lblPauseInfo.Font = new Font("Agency FB", 35.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPauseInfo.Location = new Point(307, 440);
            lblPauseInfo.Name = "lblPauseInfo";
            lblPauseInfo.Size = new Size(436, 72);
            lblPauseInfo.TabIndex = 3;
            lblPauseInfo.Text = "Press SPACE to start.";
            lblPauseInfo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 633);
            Controls.Add(lblPauseInfo);
            Controls.Add(lblPlayer2Points);
            Controls.Add(lblPlayer1Points);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResizeEnd += Form1_ResizeEnd;
            Click += Form1_Click;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblPlayer1Points;
        private Label lblPlayer2Points;
        private Label lblPauseInfo;
    }
}