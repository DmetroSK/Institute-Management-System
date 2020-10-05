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
    public partial class Attendents : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Attendents()
        {
            InitializeComponent();
        }

        private void Attendents_Load(object sender, EventArgs e)
        {

        }

      

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            m.ShowDialog();
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_stuid.Text) || string.IsNullOrEmpty(txt_module.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_module.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Module in charachters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "select module_code,attendence from attendence where stu_ID='" + txt_stuid.Text + "' and module_code='" + txt_module.Text + "'";

                    metroGrid_attendence.DataSource = db.GetData(query);
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

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            txt_module.Clear();
            txt_stuid.Clear();
        
        }
    }
}
