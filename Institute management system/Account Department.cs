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
    public partial class Account_Department : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Account_Department()
        {
            InitializeComponent();
        }

        private void Account_Department_Load(object sender, EventArgs e)
        {

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

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_stuid.Text) || string.IsNullOrEmpty(txt_sturegno.Text) || string.IsNullOrEmpty(cmb_paymethod.Text) || string.IsNullOrEmpty(metroDateTime.Text) || string.IsNullOrEmpty(txt_payamount.Text)|| string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_paycode.Text) || string.IsNullOrEmpty(txt_payamount.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter data for all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    string query0 = "select count(*) from student where stu_ID='" + txt_stuid.Text + "' and stu_reg_no='" + txt_sturegno.Text + "'";
                    DataTable dt1 = db.GetData(query0);

                    if (dt1.Rows[0][0].ToString() == "1")
                    {
                      //  MetroFramework.MetroMessageBox.Show(this, "Your data has our Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string query = "Insert into payment values('" + txt_paycode.Text + "','" + txt_payamount.Text + "','" + cmb_paymethod.Text + "','" + txt_stuid.Text + "','" + txt_batch.Text + "','" + txt_sturegno.Text + "','" + metroDateTime.Text + "')";
                        if (db.save_update_delete(query) == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Your data insert sucesssfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Your data didn't insert to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Do you really want update ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr.ToString() == "Yes")
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_paycode.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "update payment set pay_amount='" + txt_payamount.Text + "' , pay_date='" + metroDateTime.Value + "' where stu_ID='" + txt_stuid.Text + "' and pay_code='" + txt_paycode.Text + "' and stu_reg_no='" + txt_sturegno.Text + "'";
                        if (db.save_update_delete(query) == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Your data update sucesssfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Your data didn't update to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void pictureBox_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Do you really want delete data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr.ToString() == "Yes")
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_stuid.Text) & string.IsNullOrEmpty(txt_sturegno.Text) & string.IsNullOrEmpty(cmb_paymethod.Text) & string.IsNullOrEmpty(metroDateTime.Text) & string.IsNullOrEmpty(txt_payamount.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "delete from payment where stu_ID='" + txt_stuid.Text + "' and pay_code='" + txt_paycode.Text + "' and stu_reg_no='" + txt_sturegno.Text + "'";
                        if (db.save_update_delete(query) == 1)
                            MetroFramework.MetroMessageBox.Show(this, "Your data delete sucesssfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Your data didn't delete to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void pictureBox_view_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "select * from payment";

                metroGrid_account.DataSource = db.GetData(query);


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

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            txt_payamount.Clear();
            txt_paycode.Clear();
            cmb_paymethod.SelectedIndex = -1;
            txt_stuid.Clear();
            txt_sturegno.Clear();
            metroDateTime.Text = "";
            txt_batch.Clear();
        }

        private void metroGrid_account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_stuid.Text = metroGrid_account.CurrentRow.Cells["stu_ID"].Value.ToString();
            txt_sturegno.Text = metroGrid_account.CurrentRow.Cells["stu_reg_no"].Value.ToString();
            cmb_paymethod.Text = metroGrid_account.CurrentRow.Cells["pay_method"].Value.ToString();
            metroDateTime.Text = metroGrid_account.CurrentRow.Cells["pay_date"].Value.ToString();
            txt_paycode.Text = metroGrid_account.CurrentRow.Cells["pay_code"].Value.ToString();
            txt_payamount.Text = metroGrid_account.CurrentRow.Cells["pay_amount"].Value.ToString();
            txt_batch.Text= metroGrid_account.CurrentRow.Cells["batch"].Value.ToString();
         
        }

        private void txt_sturegno_Click(object sender, EventArgs e)
        {
            
        }
    }
}
