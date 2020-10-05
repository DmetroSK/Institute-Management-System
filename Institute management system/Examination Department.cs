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
    public partial class Examination_Department : MetroFramework.Forms.MetroForm
    {
        public Examination_Department()
        {
            InitializeComponent();
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

       

        private void tile_results_Click(object sender, EventArgs e)
        {
            Acc_Results ar = new Acc_Results();
            this.Hide();
            ar.Show();
        }

        private void tile_examdates_Click(object sender, EventArgs e)
        {
            Acc_examDates ad = new Acc_examDates();
            this.Hide();
            ad.Show();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }
    }
}
