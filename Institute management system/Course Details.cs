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
    public partial class Course_Details : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Course_Details()
        {
            InitializeComponent();
        }

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_courseid.Text) || string.IsNullOrEmpty(txt_coursename.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_courseid.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Course ID in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_coursename.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Course Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "Insert into course values('" + txt_courseid.Text + "','" + txt_coursename.Text + "')";
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
                    if (string.IsNullOrEmpty(txt_courseid.Text) & string.IsNullOrEmpty(txt_coursename.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "update course set course_name='" + txt_coursename.Text + "' where course_ID='" + txt_courseid.Text + "'";
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
                    if (string.IsNullOrEmpty(txt_courseid.Text) & string.IsNullOrEmpty(txt_coursename.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "delete from course where course_ID='" + txt_courseid.Text + "'";
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

                string query = "select * from course";

                metroGrid_coursedetails.DataSource = db.GetData(query);


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
            txt_courseid.Clear();
            txt_coursename.Clear();
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {

            MIS mI = new MIS();
            this.Hide();
            mI.Show();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void metroGrid_coursedetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_courseid.Text = metroGrid_coursedetails.CurrentRow.Cells["course_ID"].Value.ToString();
            txt_coursename.Text = metroGrid_coursedetails.CurrentRow.Cells["course_name"].Value.ToString();
        }
    }
}
