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
            Thread.Sleep(3000);
            Refresh();

            this.BackColor = Color.Red;
            Thread.Sleep(30);
            Refresh();
            this.BackColor = Color.Black;
            Thread.Sleep(30);
            Refresh();
            this.BackColor = Color.Red;
            Thread.Sleep(30);
            Refresh();
            this.BackColor = Color.Black;
            Thread.Sleep(1000);
            Refresh();

            exitButton.Visible = true;
            
            outputLabel.Text = "Good Bye";
            Thread.Sleep(2500);
            Refresh();
            Application.Exit();

        }
    }
}
