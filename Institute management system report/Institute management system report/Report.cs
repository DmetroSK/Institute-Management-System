using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_management_system_report
{
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_attenSum_Click(object sender, EventArgs e)
        {
            Student_Attendence_Summary a = new Student_Attendence_Summary();
            this.Hide();
            a.ShowDialog();
        }

        private void btn_resSum_Click(object sender, EventArgs e)
        {
            Examination_Result_Summary r = new Examination_Result_Summary();
            this.Hide();
            r.ShowDialog();

        }

        private void btn_paySum_Click(object sender, EventArgs e)
        {

           Payment_Summary p = new Payment_Summary();
            this.Hide();
            p.ShowDialog();
        }

       
    }
}
