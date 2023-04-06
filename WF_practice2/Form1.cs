using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_practice2
{
    public partial class Form1 : Form
    {
        bool shiftFlag= false;
        public Form1()
        {
            InitializeComponent();
            this.Height = 500;
            this.Width = 500;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 wnd = (Form1)sender;
            if(MouseButtons.Left == e.Button)
            {
                if (shiftFlag)
                {
                    MessageBox.Show("Bye;");
                    Environment.Exit(0);
                }
                else if( ((e.Location.X <= wnd.Width - 100 && e.Location.X >= 100) && (e.Location.Y == 100 || e.Location.Y == wnd.Height - 100)) || ((e.Location.Y <= wnd.Height -100 && e.Location.Y >= 100)&&(e.Location.X == 100 || e.Location.X == wnd.Width -100)))
                {
                    MessageBox.Show("Pointer is on the board");
                }
                else if ((e.Location.X > 100 && e.Location.X < wnd.Width-100) && (e.Location.Y > 100 && e.Location.Y < wnd.Width - 100))
                {
                    MessageBox.Show("Pointer is inside the rectangle");
                }
                else
                {
                    MessageBox.Show("Pointer is outside the rectangle");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ShiftKey) { shiftFlag = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ShiftKey) { shiftFlag = false; }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form1 wnd = (Form1)sender;
            wnd.Text = e.Location.ToString();
        }
    }
}
