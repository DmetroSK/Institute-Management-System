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
    public partial class Payment_Summary : MetroFramework.Forms.MetroForm
    {
        public Payment_Summary()
        {
            InitializeComponent();
        }

        private void Payment_Summary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.payment' table. You can move, or remove it, as needed.
      
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
            txt_batch.Clear();
           
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            this.paymentTableAdapter.Fill(this.DataSet1.payment,txt_id.Text,txt_batch.Text);

            this.reportViewerpayment.RefreshReport();
            if (rbn_id.Checked == true)
            {

                string query = "select * from payment where stu_ID = '" + txt_id.Text + "'";



            }
           
            else if (rbn_batch.Checked == true)
            {
                string query = "select * from payment where module_code = '" + txt_batch.Text + "'";

            }
         
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
