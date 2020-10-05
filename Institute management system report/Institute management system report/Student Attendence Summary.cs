using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_management_system_report
{
    public partial class Student_Attendence_Summary : MetroFramework.Forms.MetroForm
    {
        public Student_Attendence_Summary()
        {
            InitializeComponent();
        }

        private void Student_Attendence_Summary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.attendence' table. You can move, or remove it, as needed.
           
        }



        private void pictureBox_back_Click_1(object sender, EventArgs e)
        {
            Report re = new Report();
            this.Hide();
            re.Show();
        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_module.Clear();
            
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            this.attendenceTableAdapter.Fill(this.DataSet1.attendence,txt_id.Text,txt_module.Text);

            this.reportViewerattend.RefreshReport();
            if (rbn_id.Checked == true)
            {

                string query = "select * from attendence where stu_ID = '" + txt_id.Text + "'";



            }
            else if (rbn_module.Checked == true)
            {
                string query = "select * from attendence where module_code = '" + txt_module.Text + "'";

            }
            
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
