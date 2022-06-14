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
    public partial class ListAll : Form
    {
        public ListAll()
        {
            InitializeComponent();
        }

        private void ListAll_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ColumnName".ToString());
            table.Columns.Add("Value".ToString());
            table.Columns.Add("DataType".ToString());
            table.Columns.Add("PK".ToString());
            
            
            FileOperations fileOperations = new FileOperations();
            List<string> list=new List<string>();
            list = fileOperations.getAll();
            for (int i = 0; i < list.Count; i+=4)
            {
                DataRow dr = table.NewRow();
                dr["ColumnName"] = list[i];
                dr["Value"] = list[i+1];
                dr["DataType"] = list[i+2];
                dr["PK"] = list[i+3];
                table.Rows.Add(dr);
                
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ColumnName";
            dataGridView1.Columns[1].HeaderText = "Value";
            dataGridView1.Columns[2].HeaderText = "DataType";
            dataGridView1.Columns[3].HeaderText = "PK";
            dataGridView1.ColumnHeadersVisible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
