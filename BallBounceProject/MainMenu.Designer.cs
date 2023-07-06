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
            label1 = new Label();
            btnOptions = new Button();
            SuspendLayout();
            // 
            // btnPVP
            // 
            btnPVP.Location = new Point(323, 247);
            btnPVP.Margin = new Padding(3, 4, 3, 4);
            btnPVP.Name = "btnPVP";
            btnPVP.Size = new Size(250, 72);
            btnPVP.TabIndex = 0;
            btnPVP.Text = "Player vs Player";
            btnPVP.UseVisualStyleBackColor = true;
            btnPVP.Click += btnPVP_Click;
            // 
            // btnPvC
            // 
            btnPvC.Location = new Point(323, 327);
            btnPvC.Margin = new Padding(3, 4, 3, 4);
            btnPvC.Name = "btnPvC";
            btnPvC.Size = new Size(250, 72);
            btnPvC.TabIndex = 1;
            btnPvC.Text = "Player Vs Computer";
            btnPvC.UseVisualStyleBackColor = true;
            btnPvC.Click += btnPvC_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(323, 487);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 72);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(392, 87);
            label1.MaximumSize = new Size(571, 667);
            label1.Name = "label1";
            label1.Size = new Size(114, 54);
            label1.TabIndex = 3;
            label1.Text = "Pong";
            label1.Click += label1_Click;
            // 
            // btnOptions
            // 
            btnOptions.Location = new Point(323, 407);
            btnOptions.Margin = new Padding(3, 4, 3, 4);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(250, 72);
            btnOptions.TabIndex = 4;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += button4_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 633);
            Controls.Add(btnOptions);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnPvC);
            Controls.Add(btnPVP);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPVP;
        private Button btnPvC;
        private Button btnExit;
        private Label label1;
        private Button btnOptions;
    }
}