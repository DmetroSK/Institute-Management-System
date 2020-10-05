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
    public partial class Staff_Registration : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();


        public Staff_Registration()
        {
            InitializeComponent();
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {

            Register RE = new Register();
            this.Hide();
            RE.Show();
        }

        private void Staff_Registration_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(cmb_dep.Text) || string.IsNullOrEmpty(metroDateTime.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_qualifi.Text) || string.IsNullOrEmpty(txt_staffid.Text) )
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data into all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_name.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Full Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
               
                else if (txt_qualifi.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Qualification in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    string query = "Insert into staff values('" + txt_staffid.Text + "','" + txt_name.Text + "','" + cmb_dep.Text + "','" + txt_email.Text + "','" + metroDateTime.Text + "','" + txt_qualifi.Text + "')";
                    if (db.save_update_delete(query) == 1)
                        MetroFramework.MetroMessageBox.Show(this, "Your data insert sucesssfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Your data didn't insert to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
