using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleTimer
{
    public partial class SignalForm : Form
    {
        public SignalForm(string txt)
        {
            InitializeComponent();
            label2.Text = txt;
            label2.Left = (this.Width - label2.Width) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void SignalForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                this.Close();

        }
    }
}
