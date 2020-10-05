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
    public partial class MIS : MetroFramework.Forms.MetroForm
    {
        public MIS()
        {
            InitializeComponent();
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void tile_attendence_Click(object sender, EventArgs e)
        {
            Attendense_insert at = new Attendense_insert();
            this.Hide();
            at.Show();
        }

        private void tile_examdate_Click(object sender, EventArgs e)
        {
            Student_Shedule_Insert sai = new Student_Shedule_Insert();
            this.Hide();
            sai.Show();
        }

        private void tile_examresult_Click(object sender, EventArgs e)
        {
            Lecturer_Shedule_insert lsi = new Lecturer_Shedule_insert();
            this.Hide();
            lsi.Show();
        }

        private void tile_email_Click(object sender, EventArgs e)
        {
            Course_Details cd = new Course_Details();
            this.Hide();
            cd.Show();
        }

        private void tile_lecshedule_Click(object sender, EventArgs e)
        {
            Login_insert LI = new Login_insert();
            this.Hide();
            LI.Show();
        }
    }
}
