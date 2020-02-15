using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeoGeniX.Forms;

namespace theCatalyst
{
    public partial class Run : DarkForm
    {
        public Run()
        {
            InitializeComponent();
        }

        private void Run_Load(object sender, EventArgs e)
        {

        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(darkTextBox1.Text);
            this.Close();
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                darkTextBox1.Text = openFileDialog1.FileName;
            }
        }

        private void darkLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
