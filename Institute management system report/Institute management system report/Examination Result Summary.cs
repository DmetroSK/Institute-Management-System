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
    public partial class Examination_Result_Summary : MetroFramework.Forms.MetroForm
    {
        public Examination_Result_Summary()
        {
            InitializeComponent();
        }

        private void Examination_Result_Summary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.exam_result' table. You can move, or remove it, as needed.

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
            txt_batch.Clear();
            txt_course.Clear();
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            this.exam_resultTableAdapter.Fill(this.DataSet1.exam_result,txt_id.Text,txt_module.Text,txt_batch.Text,txt_course.Text);

            this.reportViewerresult.RefreshReport();
            if (rbn_id.Checked == true)
            {

                string query = "select * from exam_result where stu_ID = '" + txt_id.Text + "'";



            }
            else if (rbn_module.Checked == true)
            {
                string query = "select * from exam_result where module_code = '" + txt_module.Text + "'";

            }
            else if (rbn_batch.Checked == true)
            {
                string query = "select * from exam_result where module_code = '" + txt_batch.Text + "'";

            }
            else if (rbn_course.Checked == true)
            {
                string query = "select * from exam_result where module_code = '" + txt_course.Text + "'";

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
