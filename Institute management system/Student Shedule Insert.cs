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
    public partial class Student_Shedule_Insert : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Student_Shedule_Insert()
        {
            InitializeComponent();
        }

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_course.Text) || string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(metroDateTime.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txt_course.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Course in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_morning.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Morning Module in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_afternoon.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Afternoon Module in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "Insert into stu_shedule values('" + metroDateTime.Text + "','" + txt_batch.Text + "','" + txt_course.Text + "','" + txt_morning.Text + "','" + txt_afternoon.Text + "')";
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
                        string query = "update stu_shedule set lec_date='" + metroDateTime.Text + "' , m_lec_module='" + txt_morning.Text + "',a_lec_module='" + txt_afternoon.Text + "' where course_ID='" + txt_course.Text + "' and  batch='" + txt_batch.Text + "'";
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
                        string query = "delete from stu_shedule where lec_date='" + metroDateTime.Text + "' and batch='" + txt_batch.Text + "' and course_ID='" + txt_course.Text + "'";
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

                string query = "select * from stu_shedule";

                metroGrid_studentsheduleinsert.DataSource = db.GetData(query);


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

        private void metroGrid_attendenceinsert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid_studentsheduleinsert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_course.Text = metroGrid_studentsheduleinsert.CurrentRow.Cells["course_ID"].Value.ToString();
            txt_batch.Text = metroGrid_studentsheduleinsert.CurrentRow.Cells["batch"].Value.ToString();
           
            metroDateTime.Text = metroGrid_studentsheduleinsert.CurrentRow.Cells["lec_date"].Value.ToString();
            txt_morning.Text = metroGrid_studentsheduleinsert.CurrentRow.Cells["m_lec_module"].Value.ToString();
            txt_afternoon.Text = metroGrid_studentsheduleinsert.CurrentRow.Cells["a_lec_module"].Value.ToString();
        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            txt_batch.Clear();
            txt_course.Clear();
            txt_morning.Clear();
            txt_afternoon.Clear();
      
            metroDateTime.Text = "";
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

           MIS mI = new MIS();
            this.Hide();
            mI.Show();
        }

        private void Student_Shedule_Insert_Load(object sender, EventArgs e)
        {

        }
    }
}
