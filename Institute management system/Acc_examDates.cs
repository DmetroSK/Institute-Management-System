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
    public partial class Acc_examDates : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Acc_examDates()
        {
            InitializeComponent();
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            Examination_Department ad = new Examination_Department();
            this.Hide();
            ad.Show();
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

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_module.Text) || string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_course.Text) || string.IsNullOrEmpty(metroDateTime.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_course.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Course in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_module.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Module in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "Insert into exam_dates values('" + txt_course.Text + "','" + txt_batch.Text + "','" + txt_module.Text + "','" + metroDateTime.Text + "')";
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
                    if (string.IsNullOrEmpty(txt_module.Text) || string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_course.Text) || string.IsNullOrEmpty(metroDateTime.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "update exam_dates set module_code='" + txt_module.Text + "' , date='" + metroDateTime.Value + "'where batch='" + txt_batch.Text + "' and course_ID='" + txt_course.Text + "'";
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
                    if (string.IsNullOrEmpty(txt_module.Text) || string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_course.Text) || string.IsNullOrEmpty(metroDateTime.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "delete from exam_dates where course_ID='" + txt_course.Text + "' and batch='" + txt_batch.Text + "' and module_code='" + txt_module.Text + "'";
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

                string query = "select * from exam_dates";

                metroGrid_examdates.DataSource = db.GetData(query);


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
            txt_batch.Clear();
            txt_course.Clear();
            txt_module.Clear();
            metroDateTime.Text = "";

        }

        private void metroGrid_examdates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_course.Text = metroGrid_examdates.CurrentRow.Cells["course_ID"].Value.ToString();
            txt_batch.Text = metroGrid_examdates.CurrentRow.Cells["batch"].Value.ToString();
            txt_module.Text = metroGrid_examdates.CurrentRow.Cells["module_code"].Value.ToString();
            metroDateTime.Text = metroGrid_examdates.CurrentRow.Cells["Date"].Value.ToString();
        }

        private void Acc_examDates_Load(object sender, EventArgs e)
        {

        }
    }
    }
