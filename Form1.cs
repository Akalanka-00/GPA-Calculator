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
    public partial class GPA_CAL : Form
    {
        firebaseConn conn = new firebaseConn();
        
        public GPA_CAL()
        {
            InitializeComponent();
        }

        private double ResxCredit(string res)
        {
            double cGpa = 0;
            if (res == "A+")
            {
                return 4.2;
            }
            if (res == "A")
            {
                return 4.0;
            }
            if (res == "A-")
            {
                return 3.7;
            }
            if (res == "B+")
            {
                return 3.3;
            }
            if (res == "B")
            {
                return 3.0;
            }
            if (res == "B-")
            {
                return 2.7;
            }
            if (res == "C+")
            {
                return 2.3;
            }
            if (res == "C")
            {
                return 2.0;
            }
            if (res == "C-")
            {
                return 1.5;
            }
            if (res == "D")
            {
                return 1.0;
            }
            if (res == "I" || res == "F"|| res == "P"|| res == "N")
            {
                return 0.0;
            }
            return cGpa;
        }

        private void rsDataGridView()
        {
            conn.startConn();
            Dictionary<string, resultData> record = conn.exportData();
            rsDataView.Rows.Clear();
            rsDataView.Columns.Clear();

            double sgpa_zni=0;
            double sgpa_znixgi = 0;

            double tgpa_zni = 0;
            double tgpa_znixgi = 0;

            rsDataView.Columns.Add("lvl", "Course level");
            rsDataView.Columns.Add("Course ID", "ID");
            rsDataView.Columns.Add("Course Name", "name");
            rsDataView.Columns.Add("Is GPA", "isGPA");
            rsDataView.Columns.Add("Result", "result");
            rsDataView.Columns.Add("Credit", "credit");
           // Console.WriteLine(record.Values.Count);

            if(record != null)
            {
                foreach (var item in record)
                {
                    if (item.Value.isGPA == true)
                    {
                        tgpa_znixgi = tgpa_znixgi + item.Value.credit * ResxCredit(item.Value.result);
                        tgpa_zni = tgpa_zni + item.Value.credit;
                    }

                    if (lvlCombo.SelectedItem.ToString() == item.Value.lvl || lvlCombo.SelectedItem.ToString() == "All")
                    {
                        rsDataView.Rows.Add(item.Value.lvl,
                            item.Key, 
                            item.Value.name,
                            item.Value.isGPA == true ? "GPA" : "NGPA", 
                            item.Value.result, 
                            item.Value.credit);

                        if(item.Value.isGPA == true)
                        {
                            sgpa_znixgi = sgpa_znixgi + item.Value.credit * ResxCredit(item.Value.result);
                            sgpa_zni = sgpa_zni + item.Value.credit;
                        }

                    }
                    }



            }

            string gpa, sgpa;
            sgpa = ((sgpa_znixgi/sgpa_zni)).ToString("0.0000");
            gpa = (tgpa_znixgi / tgpa_zni).ToString("0.0000");

            sgpaLab.Text = sgpa;
            gpaLab.Text = gpa;

            rsDataView.Sort(rsDataView.Columns[0], ListSortDirection.Ascending);
            /* DataTable dt = new DataTable(); // your data table
             dt.DefaultView.Sort = "your_field" + "sort_direction";
             DataView dv = new DataView(dt);
             dv.Sort = ("Course level" + "ASC");
             rsDataView.DataSource = dv;*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvlCombo.SelectedIndex = 0;
           // Console.WriteLine(Environment.UserName);
            rsDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newResult nr = new newResult();
            nr.Visible = true;
        }

        private void lvlCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rsDataGridView();
        }
    }
}
