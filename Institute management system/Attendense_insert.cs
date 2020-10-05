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
    public partial class Attendense_insert : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Attendense_insert()
        {
            InitializeComponent();
        }

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_stuid.Text) || string.IsNullOrEmpty(txt_module.Text) || string.IsNullOrEmpty(txt_attendence.Text) )
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_module.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Module Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_attendence.Text.Any(char.IsLetter))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Attendence in Numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    string query = "Insert into attendence values('" + txt_stuid.Text + "','" + txt_module.Text + "','" + txt_attendence.Text + "')";
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

        private void pictureBox_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Do you really want update ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr.ToString() == "Yes")
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_stuid.Text) & string.IsNullOrEmpty(txt_module.Text) & string.IsNullOrEmpty(txt_attendence.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "update attendence set attendence='" + txt_attendence.Text + "' , module_code='" + txt_module.Text + "' where stu_ID='" + txt_stuid.Text + "'";
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
                    if (string.IsNullOrEmpty(txt_stuid.Text) & string.IsNullOrEmpty(txt_module.Text) & string.IsNullOrEmpty(txt_attendence.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "delete from attendence where stu_ID='" + txt_stuid.Text + "' and module_code='" + txt_module.Text + "'";
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

                string query = "select * from attendence";

                metroGrid_attendenceinsert.DataSource = db.GetData(query);


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
            txt_stuid.Clear();
            txt_module.Clear();
            txt_attendence.Clear();
        }

        private void metroGrid_attendenceinsert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_stuid.Text = metroGrid_attendenceinsert.CurrentRow.Cells["stu_ID"].Value.ToString();
            txt_module.Text = metroGrid_attendenceinsert.CurrentRow.Cells["module_code"].Value.ToString();
            txt_attendence.Text = metroGrid_attendenceinsert.CurrentRow.Cells["attendence"].Value.ToString();
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
            MIS MI=new MIS();
            this.Hide();
            MI.Show();
        }
    }
}
