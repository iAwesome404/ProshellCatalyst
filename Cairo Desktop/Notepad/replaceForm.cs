using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class replaceForm : Form
    {
        public String findWord;
        public String replaceWord;
        public replaceForm()
        {
            InitializeComponent();
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            findWord = findText.Text;
            replaceWord = replaceText.Text;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            findWord = "";
            replaceWord = "";
            this.Close();
        }

        private void replaceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
