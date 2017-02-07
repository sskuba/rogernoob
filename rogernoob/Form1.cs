using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rogernoob
{
    public partial class Form1 : Form
    {
        practicam6Entities p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new practicam6Entities();
            productesBindingSource1.DataSource = p.productes;
            
        }
    }
}
