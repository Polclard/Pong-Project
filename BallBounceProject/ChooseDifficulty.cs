using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallBounceProject
{
    public partial class ChooseDifficulty : Form
    {
        public bool AllowPowerups { get; set; }
        public ChooseDifficulty(bool allowPowerups)
        {
            InitializeComponent();
            AllowPowerups = allowPowerups;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Easy", AllowPowerups);
            form1.ShowDialog();
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Medium", AllowPowerups);
            form1.ShowDialog();
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Hard", AllowPowerups);
            form1.ShowDialog();
            this.Close();
        }
    }
}
