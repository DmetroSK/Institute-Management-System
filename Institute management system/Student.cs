using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_management_system
{
    public partial class Student : MetroFramework.Forms.MetroForm
    {
        public Student()
        {
            InitializeComponent();
           
        }

        private void Studentcs_Load(object sender, EventArgs e)
        {
           
        }

      
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tile_attendence_Click(object sender, EventArgs e)
        {

            Attendents a = new Attendents();
            this.Hide();
            a.Show();
        }

        private void tile_lecshedule_Click(object sender, EventArgs e)
        {
            LectureShedule l = new LectureShedule();
            this.Hide();
            l.Show();
        }

        private void tile_examdate_Click(object sender, EventArgs e)
        {
            ExamDate ed = new ExamDate();
            this.Hide();
            ed.Show();
        }

        private void tile_examresult_Click(object sender, EventArgs e)
        {

            ExamResult er = new ExamResult();
            this.Hide();
            er.Show();
        }

        private void tile_email_Click(object sender, EventArgs e)
        {

            Emailsend se = new Emailsend();
            this.Hide();
            se.Show();
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
    }
}
