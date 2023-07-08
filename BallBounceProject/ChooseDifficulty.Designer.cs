namespace BallBounceProject
{
    partial class ChooseDifficulty
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
            btnMedium = new Button();
            label1 = new Label();
            btnEasy = new Button();
            btnHard = new Button();
            SuspendLayout();
            // 
            // btnMedium
            // 
            btnMedium.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnMedium.FlatAppearance.BorderSize = 2;
            btnMedium.FlatStyle = FlatStyle.Flat;
            btnMedium.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMedium.Location = new Point(12, 244);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(308, 67);
            btnMedium.TabIndex = 1;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 64);
            label1.Name = "label1";
            label1.Size = new Size(238, 51);
            label1.TabIndex = 3;
            label1.Text = "Choose Difficulty";
            // 
            // btnEasy
            // 
            btnEasy.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnEasy.FlatAppearance.BorderSize = 2;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEasy.Location = new Point(12, 171);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(308, 67);
            btnEasy.TabIndex = 4;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += button3_Click;
            // 
            // btnHard
            // 
            btnHard.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnHard.FlatAppearance.BorderSize = 2;
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnHard.Location = new Point(12, 317);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(308, 67);
            btnHard.TabIndex = 5;
            btnHard.Text = "Hard";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // ChooseDifficulty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 38);
            ClientSize = new Size(331, 396);
            Controls.Add(btnHard);
            Controls.Add(btnEasy);
            Controls.Add(label1);
            Controls.Add(btnMedium);
            ForeColor = Color.White;
            Name = "ChooseDifficulty";
            Text = "Player vs Computer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMedium;
        private Label label1;
        private Button btnEasy;
        private Button btnHard;
    }
}