using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prefi_activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Challenge0 challenge0 = new Challenge0();
            challenge0.Show();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Challenge1 challenge1 = new Challenge1();
            challenge1.Show(); // Ensure the object is used  
        }
    }
}
