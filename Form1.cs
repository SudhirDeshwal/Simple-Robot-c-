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

          //  string i= m.DistanceChange(150).ToString();
            //listviewHistory.Items.Add("X"+ m.X.ToString());
            //listviewHistory.Items.Add("Y"+m.Y.ToString());
            //listviewHistory.Items.Add("Distance"+ i);

            m.DistanceChange(150);
          //  pictPointer.Location = new Point(m.X, m.Y);

            //lblXaxis.Text = m.X.ToString();
            //lblYaxis.Text = m.Y.ToString();

        }

        private void btnGoOne_Click(object sender, EventArgs e)
        {
            // string i = m.DistanceChange(50).ToString();
            m.DistanceChange(50);
            //listviewHistory.Items.Add("X :" + m.X.ToString());
            //listviewHistory.Items.Add("Y :" + m.Y.ToString());
            //listviewHistory.Items.Add("Distance :" + i);
        }

        private void btnNorthTop_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X, m.Y-=m.Distance);
            lblXaxis.Text = m.X.ToString();
            lblYaxis.Text = (m.Y - m.Distance).ToString();

            listviewHistory.Items.Add("X :" + m.X.ToString());
            listviewHistory.Items.Add("Y :" + (m.Y-m.Distance).ToString());
            listviewHistory.Items.Add("Distance :" + m.Distance);
        }

        private void btnSouthDown_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X, m.Y+=m.Distance);
            lblXaxis.Text = m.X.ToString();
            lblYaxis.Text = (m.Y + m.Distance).ToString();

            listviewHistory.Items.Add("X :" + m.X.ToString());
            listviewHistory.Items.Add("Y :" + (m.Y+=m.Distance).ToString());
            listviewHistory.Items.Add("Distance :" + m.Distance);

        }

        private void btnWestLeft_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X-=m.Distance, m.Y);

            lblXaxis.Text = (m.X - m.Distance).ToString();
            lblYaxis.Text = m.Y.ToString();

            listviewHistory.Items.Add("X :" + (m.X-=m.Distance).ToString());
            listviewHistory.Items.Add("Y :" + m.Y.ToString());
            listviewHistory.Items.Add("Distance :" + m.Distance);
        }

        private void btnEastRight_Click(object sender, EventArgs e)
        {
            pictPointer.Location = new Point(m.X+=m.Distance, m.Y);

            lblXaxis.Text = (m.X + m.Distance).ToString();
            lblYaxis.Text = m.Y.ToString();


            listviewHistory.Items.Add("X :" + (m.X+m.Distance).ToString());
            listviewHistory.Items.Add("Y :" + m.Y.ToString());
            listviewHistory.Items.Add("Distance :" + m.Distance);
        }
    }
}
