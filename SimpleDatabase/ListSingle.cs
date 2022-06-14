using SimpleDatabase.DataProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDatabase
{
    public partial class ListSingle : Form
    {
        public ListSingle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string>();
            List<string> table = new List<string>();
            FileOperations fileOperations = new FileOperations();

            try
            {
                column = fileOperations.getByPK(textBox1.Text);
                label4.Text = column[0];
                label5.Text = column[1];
                label6.Text = column[3];
                
            }
            catch (Exception)
            {

            }
        }

        private void ListSingle_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
