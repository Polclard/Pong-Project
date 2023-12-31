﻿using System;
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
    public partial class MainMenu : Form
    {
        public bool AllowPowerups { get; set; }
        public MainMenu()
        {
            InitializeComponent();

            AllowPowerups = false;
        }

        private void btnPVP_Click(object sender, EventArgs e)
        {
            PlayingField form1 = new PlayingField("PVP", AllowPowerups);
            form1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Options optionForm = new Options(this);
            optionForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPvC_Click(object sender, EventArgs e)
        {
            ChooseDifficulty cd = new ChooseDifficulty(AllowPowerups);
            cd.ShowDialog();

        }
    }
}
