using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace theCatalyst
{
    public partial class findForm : Form
    {
        String findWord;
        public findForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            findWord = "";
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            findWord = findText.Text;
            this.Close();
        }
        public String getFindWord()
        {
            return findWord;
        }
    }
}
