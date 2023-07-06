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
            tutLblPlayer1Instructions = new Label();
            tutBtnWkey = new Button();
            tutBtnSkey = new Button();
            tutBtnAkey = new Button();
            tutBtnDkey = new Button();
            tutBtnRightArrow = new Button();
            tutBtnLeftArrow = new Button();
            tutBtnDownArrow = new Button();
            tutBtnUpArrow = new Button();
            tutLblP2Instructions = new Label();
            tutLblMoreInstructions = new Label();
            tutLblPlayer1 = new Label();
            tutLblPlayer2 = new Label();
            tutLblHeading = new Label();
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
            lblPlayer1Points.Location = new Point(60, 9);
            lblPlayer1Points.Name = "lblPlayer1Points";
            lblPlayer1Points.Size = new Size(36, 40);
            lblPlayer1Points.TabIndex = 1;
            lblPlayer1Points.Text = "0";
            // 
            // lblPlayer2Points
            // 
            lblPlayer2Points.AutoSize = true;
            lblPlayer2Points.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2Points.Location = new Point(954, 9);
            lblPlayer2Points.Name = "lblPlayer2Points";
            lblPlayer2Points.Size = new Size(36, 40);
            lblPlayer2Points.TabIndex = 2;
            lblPlayer2Points.Text = "0";
            // 
            // lblPauseInfo
            // 
            lblPauseInfo.AutoSize = true;
            lblPauseInfo.Font = new Font("Agency FB", 35.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPauseInfo.Location = new Point(307, 480);
            lblPauseInfo.Name = "lblPauseInfo";
            lblPauseInfo.Size = new Size(436, 72);
            lblPauseInfo.TabIndex = 3;
            lblPauseInfo.Text = "Press SPACE to start.";
            // 
            // tutLblPlayer1Instructions
            // 
            tutLblPlayer1Instructions.AutoSize = true;
            tutLblPlayer1Instructions.Font = new Font("Agency FB", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            tutLblPlayer1Instructions.Location = new Point(61, 361);
            tutLblPlayer1Instructions.Name = "tutLblPlayer1Instructions";
            tutLblPlayer1Instructions.Size = new Size(291, 102);
            tutLblPlayer1Instructions.TabIndex = 5;
            tutLblPlayer1Instructions.Text = "use W to move UP\r\nuse S to move DOWN";
            // 
            // tutBtnWkey
            // 
            tutBtnWkey.BackColor = SystemColors.Highlight;
            tutBtnWkey.Enabled = false;
            tutBtnWkey.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnWkey.Location = new Point(149, 167);
            tutBtnWkey.Name = "tutBtnWkey";
            tutBtnWkey.Size = new Size(74, 81);
            tutBtnWkey.TabIndex = 6;
            tutBtnWkey.TabStop = false;
            tutBtnWkey.Text = "W";
            tutBtnWkey.UseVisualStyleBackColor = false;
            // 
            // tutBtnSkey
            // 
            tutBtnSkey.BackColor = SystemColors.Highlight;
            tutBtnSkey.Enabled = false;
            tutBtnSkey.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnSkey.Location = new Point(149, 254);
            tutBtnSkey.Name = "tutBtnSkey";
            tutBtnSkey.Size = new Size(74, 81);
            tutBtnSkey.TabIndex = 7;
            tutBtnSkey.TabStop = false;
            tutBtnSkey.Text = "S";
            tutBtnSkey.UseVisualStyleBackColor = false;
            // 
            // tutBtnAkey
            // 
            tutBtnAkey.Enabled = false;
            tutBtnAkey.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnAkey.Location = new Point(69, 254);
            tutBtnAkey.Name = "tutBtnAkey";
            tutBtnAkey.Size = new Size(74, 81);
            tutBtnAkey.TabIndex = 8;
            tutBtnAkey.TabStop = false;
            tutBtnAkey.Text = "A";
            tutBtnAkey.UseVisualStyleBackColor = true;
            // 
            // tutBtnDkey
            // 
            tutBtnDkey.Enabled = false;
            tutBtnDkey.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnDkey.Location = new Point(229, 254);
            tutBtnDkey.Name = "tutBtnDkey";
            tutBtnDkey.Size = new Size(74, 81);
            tutBtnDkey.TabIndex = 9;
            tutBtnDkey.TabStop = false;
            tutBtnDkey.Text = "D";
            tutBtnDkey.UseVisualStyleBackColor = true;
            // 
            // tutBtnRightArrow
            // 
            tutBtnRightArrow.Enabled = false;
            tutBtnRightArrow.Font = new Font("Calibri", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnRightArrow.Location = new Point(884, 254);
            tutBtnRightArrow.Name = "tutBtnRightArrow";
            tutBtnRightArrow.Size = new Size(74, 81);
            tutBtnRightArrow.TabIndex = 14;
            tutBtnRightArrow.TabStop = false;
            tutBtnRightArrow.Text = "→";
            tutBtnRightArrow.UseVisualStyleBackColor = true;
            // 
            // tutBtnLeftArrow
            // 
            tutBtnLeftArrow.Enabled = false;
            tutBtnLeftArrow.Font = new Font("Calibri", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnLeftArrow.Location = new Point(724, 254);
            tutBtnLeftArrow.Name = "tutBtnLeftArrow";
            tutBtnLeftArrow.Size = new Size(74, 81);
            tutBtnLeftArrow.TabIndex = 13;
            tutBtnLeftArrow.TabStop = false;
            tutBtnLeftArrow.Text = "←";
            tutBtnLeftArrow.UseVisualStyleBackColor = true;
            // 
            // tutBtnDownArrow
            // 
            tutBtnDownArrow.BackColor = SystemColors.Highlight;
            tutBtnDownArrow.Enabled = false;
            tutBtnDownArrow.Font = new Font("Calibri", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnDownArrow.Location = new Point(804, 254);
            tutBtnDownArrow.Name = "tutBtnDownArrow";
            tutBtnDownArrow.Size = new Size(74, 81);
            tutBtnDownArrow.TabIndex = 12;
            tutBtnDownArrow.TabStop = false;
            tutBtnDownArrow.Text = "↓";
            tutBtnDownArrow.UseVisualStyleBackColor = false;
            // 
            // tutBtnUpArrow
            // 
            tutBtnUpArrow.BackColor = SystemColors.Highlight;
            tutBtnUpArrow.Enabled = false;
            tutBtnUpArrow.Font = new Font("Calibri", 25F, FontStyle.Regular, GraphicsUnit.Point);
            tutBtnUpArrow.Location = new Point(804, 167);
            tutBtnUpArrow.Margin = new Padding(0);
            tutBtnUpArrow.Name = "tutBtnUpArrow";
            tutBtnUpArrow.Size = new Size(74, 81);
            tutBtnUpArrow.TabIndex = 11;
            tutBtnUpArrow.TabStop = false;
            tutBtnUpArrow.Text = "↑";
            tutBtnUpArrow.UseVisualStyleBackColor = false;
            // 
            // tutLblP2Instructions
            // 
            tutLblP2Instructions.AutoSize = true;
            tutLblP2Instructions.Font = new Font("Agency FB", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            tutLblP2Instructions.Location = new Point(679, 361);
            tutLblP2Instructions.Name = "tutLblP2Instructions";
            tutLblP2Instructions.Size = new Size(291, 102);
            tutLblP2Instructions.TabIndex = 10;
            tutLblP2Instructions.Text = "use W to move UP\r\nuse S to move DOWN";
            // 
            // tutLblMoreInstructions
            // 
            tutLblMoreInstructions.AutoSize = true;
            tutLblMoreInstructions.Font = new Font("Agency FB", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tutLblMoreInstructions.Location = new Point(440, 295);
            tutLblMoreInstructions.Name = "tutLblMoreInstructions";
            tutLblMoreInstructions.Size = new Size(170, 84);
            tutLblMoreInstructions.TabIndex = 15;
            tutLblMoreInstructions.Text = "SPACE - Pause\r\nEsc - Close";
            tutLblMoreInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tutLblPlayer1
            // 
            tutLblPlayer1.AutoSize = true;
            tutLblPlayer1.Font = new Font("Agency FB", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            tutLblPlayer1.Location = new Point(133, 79);
            tutLblPlayer1.Name = "tutLblPlayer1";
            tutLblPlayer1.Size = new Size(123, 51);
            tutLblPlayer1.TabIndex = 16;
            tutLblPlayer1.Text = "Player 1";
            // 
            // tutLblPlayer2
            // 
            tutLblPlayer2.AutoSize = true;
            tutLblPlayer2.Font = new Font("Agency FB", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            tutLblPlayer2.Location = new Point(776, 79);
            tutLblPlayer2.Name = "tutLblPlayer2";
            tutLblPlayer2.Size = new Size(132, 51);
            tutLblPlayer2.TabIndex = 17;
            tutLblPlayer2.Text = "Player 2";
            // 
            // tutLblHeading
            // 
            tutLblHeading.AutoSize = true;
            tutLblHeading.Font = new Font("Agency FB", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            tutLblHeading.Location = new Point(442, 120);
            tutLblHeading.Name = "tutLblHeading";
            tutLblHeading.Size = new Size(133, 51);
            tutLblHeading.TabIndex = 18;
            tutLblHeading.Text = "Controls";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 633);
            Controls.Add(tutLblHeading);
            Controls.Add(tutLblPlayer2);
            Controls.Add(tutLblPlayer1);
            Controls.Add(tutLblMoreInstructions);
            Controls.Add(tutBtnRightArrow);
            Controls.Add(tutBtnLeftArrow);
            Controls.Add(tutBtnDownArrow);
            Controls.Add(tutBtnUpArrow);
            Controls.Add(tutLblP2Instructions);
            Controls.Add(tutBtnDkey);
            Controls.Add(tutBtnAkey);
            Controls.Add(tutBtnSkey);
            Controls.Add(tutBtnWkey);
            Controls.Add(tutLblPlayer1Instructions);
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
        private Label tutLblPlayer1Instructions;
        private Button tutBtnWkey;
        private Button tutBtnSkey;
        private Button tutBtnAkey;
        private Button tutBtnDkey;
        private Button tutBtnRightArrow;
        private Button tutBtnLeftArrow;
        private Button tutBtnDownArrow;
        private Button tutBtnUpArrow;
        private Label tutLblP2Instructions;
        private Label tutLblMoreInstructions;
        private Label tutLblPlayer1;
        private Label tutLblPlayer2;
        private Label tutLblHeading;
    }
}