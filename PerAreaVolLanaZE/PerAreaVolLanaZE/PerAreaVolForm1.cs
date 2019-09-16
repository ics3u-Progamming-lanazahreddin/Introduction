/*
 * Created by: Lana ZE
 * Created on: 12-09-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Perimeter, Area, Volume by lana ZE
 * This program calculates the perimeter of a rectangle, rae of a circle and the volume of a sphere 
 * with an already given value
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolLanaZE
{
    public partial class frmPerAreaVolForm1 : Form
    {
        public frmPerAreaVolForm1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this calculates volume of a sphere 
            this.lblAVolume.Text = Convert.ToString( (double)4 / (double)3 * Math.PI * Math.Pow(3,3) ) + "cm³";
        }

        private void BtnQPerimeter_Click(object sender, EventArgs e)
        {
            //this calculates the perimeter of a rectangle
            this.lblAPerimeter.Text = Convert.ToString(2 * (5 + 8)) + "cm";
        }

        private void BtnQArea_Click(object sender, EventArgs e)
        {
            //this calculates the ares of a circle
            this.lblAArea.Text = Convert.ToString(Math.PI * Math.Pow(7, 2)) + " cm²";
        }
    }
}
