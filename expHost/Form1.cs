using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceHost sh = new ServiceHost(typeof(expService.Expense));
            sh.Open();
            label1.Text = "Service is running";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
