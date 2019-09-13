using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntLanaZE
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void LblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void Grp1_Enter(object sender, EventArgs e)
        {

        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "hello, World!";
        }

        private void RadSpanish_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Hola, Mundo!";


       }

        private void RadArabic_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "مرحبا بالعالم!";
        }

        private void RadFilipino_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Kumusta, Mundo!";
        }
    }
}
