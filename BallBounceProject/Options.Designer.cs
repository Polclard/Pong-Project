namespace BallBounceProject
{
    partial class Options
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
            label2 = new Label();
            cBoxPowerups = new CheckBox();
            lblAboutInfo = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 40);
            label2.Name = "label2";
            label2.Size = new Size(59, 36);
            label2.TabIndex = 1;
            label2.Text = "Pong";
            // 
            // cBoxPowerups
            // 
            cBoxPowerups.AutoSize = true;
            cBoxPowerups.BackColor = Color.FromArgb(36, 37, 39);
            cBoxPowerups.Location = new Point(82, 119);
            cBoxPowerups.Name = "cBoxPowerups";
            cBoxPowerups.Size = new Size(136, 24);
            cBoxPowerups.TabIndex = 0;
            cBoxPowerups.Text = "Allow Powerups";
            cBoxPowerups.UseVisualStyleBackColor = false;
            cBoxPowerups.CheckedChanged += cBoxPowerups_CheckedChanged;
            // 
            // lblAboutInfo
            // 
            lblAboutInfo.AutoSize = true;
            lblAboutInfo.Location = new Point(97, 170);
            lblAboutInfo.Name = "lblAboutInfo";
            lblAboutInfo.Size = new Size(106, 60);
            lblAboutInfo.TabIndex = 2;
            lblAboutInfo.Text = "2023\r\nFilip Naskovski\r\nAlen Jangelov";
            lblAboutInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(36, 37, 39);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(75, 264);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 38);
            ClientSize = new Size(282, 318);
            Controls.Add(btnClose);
            Controls.Add(lblAboutInfo);
            Controls.Add(cBoxPowerups);
            Controls.Add(label2);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Options";
            Text = "Options";
            Load += Options_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private CheckBox cBoxPowerups;
        private Label lblAboutInfo;
        private Button btnClose;
    }
}