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
    public partial class Options : Form
    {
        MainMenu MenuRef;
        public Options(MainMenu menuRef)
        {
            InitializeComponent();
            MenuRef = menuRef;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void cBoxPowerups_CheckedChanged(object sender, EventArgs e)
        {
            MenuRef.AllowPowerups = cBoxPowerups.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
