using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FlowchartPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            outputLabel.Visible = true;
            startButton.Visible = false;
            Refresh();

            this.BackColor = Color.Red;
            Thread.Sleep(300);
            Refresh();
            this.BackColor = Color.Black;
            Thread.Sleep(300);
            Refresh();
            this.BackColor = Color.Red;
            Thread.Sleep(300);
            Refresh();
            this.BackColor = Color.Black;
            Thread.Sleep(300);
            Refresh();
            exitButton.Visible = true;
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            outputLabel.Text = "Good Bye";
            Refresh();
            Thread.Sleep(2500);
            Refresh();
            Application.Exit();
        }
    }
}
