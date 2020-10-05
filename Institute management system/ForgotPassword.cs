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
    public partial class ForgotPassword : MetroFramework.Forms.MetroForm
    {
        Database DB = new Database();

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_stuid.Text) || string.IsNullOrEmpty(txt_regnum.Text))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Please Enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string query = "select count(*) from student where stu_ID='" + txt_stuid.Text + "' and stu_reg_no='" + txt_regnum.Text + "'";
                    DataTable dt = DB.GetData(query);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your data has our Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Your data hasn't our Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_stuid.Text) & string.IsNullOrEmpty(txt_regnum.Text) & string.IsNullOrEmpty(txt_pw.Text) & string.IsNullOrEmpty(txt_conpw.Text))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_pw.Text.Length < 5)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please atleast five charcters in your password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (txt_pw.Text == txt_conpw.Text)
                    {
                        string query1 = "update login set password='"+txt_pw.Text+"' where username='"+txt_stuid.Text+"' ";
                        if (DB.signup(query1) == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Your password reset successsfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Your password didn't reset successsfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else
                        MetroFramework.MetroMessageBox.Show(this, "Password is not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            m.ShowDialog();
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.ShowDialog();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
