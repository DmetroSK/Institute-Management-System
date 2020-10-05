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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Registration()
        {
            InitializeComponent();
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.ShowDialog();
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_add.Text) || string.IsNullOrEmpty(metroDateTime.Text) || string.IsNullOrEmpty(txt_tel.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_gname.Text) || string.IsNullOrEmpty(txt_gtel.Text) || string.IsNullOrEmpty(txt_qualifi.Text) || string.IsNullOrEmpty(cmb_course.Text) || string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_stuid.Text) || string.IsNullOrEmpty(txt_sturegno.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data into all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_name.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Full Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_add.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Address in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_nic.Text.Any(char.IsLetter))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter NIC in Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_tel.Text.Any(char.IsLetter))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Telephone Number in Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_gname.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Parent Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_gtel.Text.Any(char.IsLetter))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Parent Telephone Number in Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_qualifi.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Qualification in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               

                else
                {
                    string query = "Insert into student values('" + txt_stuid.Text + "','" + txt_sturegno.Text + "','" + txt_name.Text + "','" + txt_nic.Text + "','" + txt_tel.Text + "','" + txt_add.Text + "','" + txt_email.Text + "','" + metroDateTime.Text + "','" + txt_qualifi.Text + "','" + txt_gname.Text + "','" + txt_gtel.Text + "','" + txt_batch.Text + "','" + cmb_course.Text + "')";
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
