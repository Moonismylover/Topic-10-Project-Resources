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
        Random generator = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void imgmario_1_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.Arrow;

            int randomNumber = generator.Next(5);

            if (randomNumber == 2)
            {
                imgmario_1.Image = Properties.Resources.Mario_3;
            }
            else
            {
                imgmario_1.Image = Properties.Resources.Mario_2;
            }


        }
    }
}
