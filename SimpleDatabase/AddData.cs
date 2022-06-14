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
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            list.Add(label1.Text);
            list.Add(textBox6.Text);
            list.Add(label5.Text);
            list.Add(label10.Text);

            list.Add(label2.Text);
            list.Add(textBox7.Text);
            list.Add(label6.Text);
            list.Add(label11.Text);

            list.Add(label3.Text);
            list.Add(textBox8.Text);
            list.Add(label7.Text);
            list.Add(label12.Text);

            list.Add(label4.Text);
            list.Add(textBox9.Text);
            list.Add(label8.Text);
            list.Add(label13.Text);

            FileOperations fileOperations = new FileOperations();
            fileOperations.addValue(list);
        }

        private void AddData_Load(object sender, EventArgs e)
        {
            FileOperations fileOperations = new FileOperations();
            List<string> table = new List<string>();

            table = fileOperations.getTable();

            
            label9.Text = table[0];

            label1.Text = table[2];
            label2.Text = table[5];
            label3.Text = table[8];
            label4.Text = table[11];
            label5.Text = table[3];
            label6.Text = table[6];
            label7.Text = table[9];
            label8.Text = table[12];

            label10.Text = table[1];
            label11.Text = table[4];
            label12.Text = table[7];
            label13.Text = table[10];
        }
    }
}
