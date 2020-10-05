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
    public partial class ExamDate : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public ExamDate()
        {
            InitializeComponent();
        }

        private void ExamDate_Load(object sender, EventArgs e)
        {

        }


        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            this.Hide();
            s.Show();
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            this.Hide();
            s.Show();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            if (chkbox_view.Checked == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_course.Text) )
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
                        string query = "select Date,module_code from exam_dates where course_ID='" + txt_course.Text + "' and batch='" + txt_batch.Text + "' ";

                        metroGrid_examdates.DataSource = db.GetData(query);
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
                try
                {
                    if (string.IsNullOrEmpty(txt_batch.Text) || string.IsNullOrEmpty(txt_course.Text) || string.IsNullOrEmpty(txt_module.Text))
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
                        string query = "select Date,module_code from exam_dates where course_ID='" + txt_course.Text + "' and batch='" + txt_batch.Text + "' and module_code='" + txt_module.Text + "' ";

                        metroGrid_examdates.DataSource = db.GetData(query);
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

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            txt_batch.Clear();
            txt_course.Clear();
            txt_module.Clear();
        }
    }
}
