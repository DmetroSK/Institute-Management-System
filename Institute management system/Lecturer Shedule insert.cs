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
    public partial class Lecturer_Shedule_insert : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Lecturer_Shedule_insert()
        {
            InitializeComponent();
        }

        private void Lecturer_Shedule_insert_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_course.Text) || string.IsNullOrEmpty(txt_batch.Text)  || string.IsNullOrEmpty(metroDateTime.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_course.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Course Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_morning.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Morning Lecturer Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_afternoon.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Afternoon Lecturer Name in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "Insert into lec_shedule values('" + metroDateTime.Text + "','" + txt_batch.Text + "','" + txt_morning.Text + "','" + txt_afternoon.Text + "','" + txt_course.Text + "')";
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
                    if (string.IsNullOrEmpty(txt_course.Text) & string.IsNullOrEmpty(txt_batch.Text) & string.IsNullOrEmpty(txt_morning.Text) & string.IsNullOrEmpty(txt_afternoon.Text) & string.IsNullOrEmpty(metroDateTime.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "update lec_shedule set date='" + metroDateTime.Text + "' , Morning_Lecture='" + txt_morning.Text + "',Afternoon_Lecture='" + txt_afternoon.Text + "' where course_ID='" + txt_course.Text + "' and  Batch='" + txt_batch.Text + "'";
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
                    if (string.IsNullOrEmpty(txt_course.Text) & string.IsNullOrEmpty(txt_batch.Text) & string.IsNullOrEmpty(txt_morning.Text) & string.IsNullOrEmpty(txt_afternoon.Text) & string.IsNullOrEmpty(metroDateTime.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "delete from lec_shedule where Date='" + metroDateTime.Text + "' and Batch='" + txt_batch.Text + "' and course_ID='" + txt_course.Text + "'";
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

                string query = "select * from lec_shedule";

                metroGrid_lecturersheduleinsert.DataSource = db.GetData(query);


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
            txt_morning.Clear();
            txt_afternoon.Clear();

            metroDateTime.Text = "";
        }

        private void metroGrid_lecturersheduleinsert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_course.Text = metroGrid_lecturersheduleinsert.CurrentRow.Cells["course_ID"].Value.ToString();
            txt_batch.Text = metroGrid_lecturersheduleinsert.CurrentRow.Cells["Batch"].Value.ToString();

            metroDateTime.Text = metroGrid_lecturersheduleinsert.CurrentRow.Cells["Date"].Value.ToString();
            txt_morning.Text = metroGrid_lecturersheduleinsert.CurrentRow.Cells["Morning_Lecture"].Value.ToString();
            txt_afternoon.Text = metroGrid_lecturersheduleinsert.CurrentRow.Cells["Afternoon_Lecture"].Value.ToString();
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
    }
}
