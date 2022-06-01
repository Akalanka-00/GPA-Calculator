using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        firebaseConn conn = new firebaseConn();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void rsDataGridView()
        {
            conn.startConn();
            Dictionary<string, resultData> record = conn.exportData();
            rsDataView.Rows.Clear();
            rsDataView.Columns.Clear();

            rsDataView.Columns.Add("lvl", "Course level");
            rsDataView.Columns.Add("Course ID", "ID");
            rsDataView.Columns.Add("Course Name", "name");
            rsDataView.Columns.Add("Is GPA", "isGPA");
            rsDataView.Columns.Add("Result", "result");
            rsDataView.Columns.Add("Credit", "credit");
            Console.WriteLine(record.Values.Count);

            if(record != null)
            {
                foreach (var item in record)
                {
                    rsDataView.Rows.Add(item.Value.lvl, item.Key, item.Value.name, item.Value.isGPA == true ? "GPA" : "NGPA", item.Value.result, item.Value.credit);
                }
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvlCombo.SelectedIndex = 0;
            
            rsDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newResult nr = new newResult();
            nr.Visible = true;
        }
    }
}
