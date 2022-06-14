using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleDatabase.DataProcess;

namespace SimpleDatabase
{
    public partial class CreateTable : Form
    {
        public CreateTable()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string tableName = textBox1.Text;
            List<string> list = new List<string>();
            
            list.Add(tableName);

            list.Add(radioButton1.Checked.ToString());
            list.Add(textBox2.Text);
            list.Add(comboBox1.SelectedItem.ToString());
            list.Add(radioButton2.Checked.ToString());
            list.Add(textBox3.Text);
            list.Add(comboBox2.SelectedItem.ToString());
            list.Add(radioButton3.Checked.ToString());
            list.Add(textBox4.Text);
            list.Add(comboBox3.SelectedItem.ToString());
            list.Add(radioButton4.Checked.ToString());
            list.Add(textBox5.Text);
            list.Add(comboBox4.SelectedItem.ToString());


            FileOperations fileOperations = new FileOperations();
            fileOperations.AddTable(list);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTable_Load(object sender, EventArgs e)
        {
           
        }
    }
}
