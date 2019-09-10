/*
 * Created by: Lana ZE
 * Created on: Sept. 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Program with Menu
 * This program displays my favouite soccer team with player with an exit menu
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

namespace ProgramMenuLana
{
    public partial class frmProgramMenu : Form
    {
        public frmProgramMenu()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblSoccerPlayer_Click(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // this will exit the program
            this.Close();
        }
    }
}
