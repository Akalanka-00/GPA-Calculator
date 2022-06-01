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
    public partial class newResult : Form
    {
        public newResult()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            resultData rsData = new resultData();

            rsData.lvl = lvlCombo.SelectedItem.ToString();
            rsData.Id = idTxt.Text;
            rsData.name = nameTxt.Text;
            rsData.isGPA = isGPACombo.SelectedIndex==0?true:false;
            rsData.result = resCombo.SelectedItem.ToString();
            rsData.credit = Convert.ToDouble(crTxt.Text);

            firebaseConn conn = new firebaseConn();
            conn.startConn();
            Console.WriteLine(
                rsData.lvl + 
                "\n" + rsData.Id + 
                "\n" + rsData.name + 
                "\n" + rsData.isGPA + 
                "\n" + rsData.result + 
                "\n" + rsData.credit + "\n" );
            conn.insertData(idTxt.Text, rsData);

            this.Close();
        }

        private void newResult_Load(object sender, EventArgs e)
        {
            lvlCombo.SelectedIndex = 0;
            resCombo.SelectedIndex = 0;
            isGPACombo.SelectedIndex = 0;
        }
    }
}
