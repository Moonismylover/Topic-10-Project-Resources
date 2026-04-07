using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Project_Resources
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void imgmario_1_Click(object sender, EventArgs e)
        {
            imgmario_1.Image = Properties.Resources.Mario_2;
        }
    }
}
