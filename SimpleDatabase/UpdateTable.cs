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
    public partial class UpdateTable : Form
    {
        int index;
        List<string>? column;
        public UpdateTable()
        {
            column = new List<string>();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileOperations fileOperations = new FileOperations();
            
            column = fileOperations.getByPK(textBox1.Text);
            if (column.Count>0)
            {
                textBox2.Text = column[0];
                textBox3.Text = column[1];


                index = Convert.ToInt32(column[4]);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            column[0] =textBox2.Text;
            column[1] = textBox3.Text;
            column[4] = index.ToString();
            FileOperations fileOperations = new FileOperations();
            fileOperations.updateData(column);
        }

        private void UpdateTable_Load(object sender, EventArgs e)
        {

        }
    }
}
