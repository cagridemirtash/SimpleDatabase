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
    public partial class StartFrame : Form
    {
        public StartFrame()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData();
            addData.Show();
        }

        private void StartFrame_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\projects\sharp\SimpleDatabase\table.bin"))
            {
                CreateTable createTable = new CreateTable();
                createTable.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListAll listAll = new ListAll();
            listAll.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateTable updateTable = new UpdateTable();
            updateTable.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListSingle listSingle = new ListSingle();
            listSingle.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteFrame deleteFrame = new DeleteFrame();
            deleteFrame.Show();
        }
    }
}
