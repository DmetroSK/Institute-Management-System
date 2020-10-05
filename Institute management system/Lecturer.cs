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
    public partial class Lecturer : MetroFramework.Forms.MetroForm
    {
        public Lecturer()
        {
            InitializeComponent();
        }

      
        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void tile_lecturershedule_Click(object sender, EventArgs e)
        {
            LecturerShedule l = new LecturerShedule();
            this.Close();
            l.Show();
          
        }

        private void tile_email_Click(object sender, EventArgs e)
        {
            Emailsend se = new Emailsend();
            this.Hide();
            se.Show();
        }

        private void tile_studetails_Click(object sender, EventArgs e)
        {
            Student_Details sd = new Student_Details();
            this.Hide();
            sd.Show();

        }

        private void tile_examdates_Click(object sender, EventArgs e)
        {
            ExamDate ed = new ExamDate();
            this.Hide();
            ed.Show();
            
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void tile_stuattendence_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "This report goes to other software", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tile_examresultsum_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "This report goes to other software", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
