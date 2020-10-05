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
    public partial class Student_Details : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Student_Details()
        {
            InitializeComponent();
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

       
        private void Student_Details_Load(object sender, EventArgs e)
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

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            if (rbn_stuid.Checked == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_stuid.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter Student ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                    else
                    {
                        string query = "select stu_ID,stu_name,course_ID,batch,email,tel from student where stu_ID='" + txt_stuid.Text + "'";

                        metroGrid_stuDetails.DataSource = db.GetData(query);
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

           else if (rbn_course.Checked == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_course.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter Course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txt_course.Text.Any(char.IsDigit))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter Course in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        string query = "select stu_ID,stu_name,course_ID,batch,email,tel from student where course_ID='" + txt_course.Text + "'";

                        metroGrid_stuDetails.DataSource = db.GetData(query);
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

            else if (rbn_batch.Checked == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_batch.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter Batch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "select stu_ID,stu_name,course_ID,batch,email,tel from student where batch='" + txt_batch.Text + "'";

                        metroGrid_stuDetails.DataSource = db.GetData(query);
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
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select atleast one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            txt_batch.Clear();
            txt_course.Clear();
            txt_stuid.Clear();

            if (rbn_stuid.Checked == true || rbn_course.Checked == true || rbn_batch.Checked == true)
            { rbn_stuid.Checked = false;
                rbn_course.Checked = false;
                rbn_batch.Checked = false;
            }
        }
    }
    
}
