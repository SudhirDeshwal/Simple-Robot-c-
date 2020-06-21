using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Week_5_Lab.Movement;

namespace Week_5_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            pictPointer.Location = new Point(250, 200);
        }

        Movement m = new Movement(250, 200);
       
        
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoTen_Click(object sender, EventArgs e)
        {

            string i= m.DistanceChange(150).ToString();
            listviewHistory.Items.Add(i);
           // m.DistanceChange(150);
            pictPointer.Location = new Point(m.X, m.Y);

        }

        private void btnGoOne_Click(object sender, EventArgs e)
        {
            m.DistanceChange(50);
            pictPointer.Location = new Point(m.X, m.Y);
        }

        private void btnNorthTop_Click(object sender, EventArgs e)
        {
           
            pictPointer.Location = new Point(m.X, m.Y-m.Distance);
            label1.Text = m.X.ToString();
            label2.Text = m.Y.ToString();
        }

        private void btnSouthDown_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X, m.Y+m.Distance);
            label1.Text = m.X.ToString();
            label2.Text = m.Y.ToString();

        }

        private void btnWestLeft_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X-m.Distance, m.Y);
        }

        private void btnEastRight_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X+m.Distance, m.Y);
        }
    }
}
