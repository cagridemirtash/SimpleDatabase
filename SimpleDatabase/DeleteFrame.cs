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
    public partial class DeleteFrame : Form
    {

        int index;
        List<string>? column;
        public DeleteFrame()
        {
            column = new List<string>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileOperations fileOperations = new FileOperations();

            column = fileOperations.getByPK(textBox1.Text);
            if (column.Count > 0)
            {
                label5.Text = column[0];
                label6.Text = column[1];
                label7.Text = column[2];


                index = Convert.ToInt32(column[4]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileOperations fileOperations = new FileOperations();
            fileOperations.deleteData(column);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
