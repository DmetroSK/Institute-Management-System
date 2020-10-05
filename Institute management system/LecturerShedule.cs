using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Institute_management_system
{
    public partial class LecturerShedule : MetroFramework.Forms.MetroForm
    {
        Database d = new Database();

        public LecturerShedule()
        {
            InitializeComponent();
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        

        private void LecturerShedule_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(metroDateTime.Text))
                    {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
                    else
                    {
                    string query = "select Date,Morning_Lecture,Afternoon_Lecture from lec_shedule where Date='" + metroDateTime.Text + "' and Batch='" + txt_batch.Text + "'";

                    metroGrid_lecshedule.DataSource = d.GetData(query);
                }
               
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Please check the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            metroDateTime.Text="";
            txt_batch.Clear();
        }

        private void metroDateTime_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            Lecturer l = new Lecturer();
            this.Hide();
            l.Show();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }
    }
}
