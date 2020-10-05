using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute_Management_System_Report
{
    public partial class Examination_Result_Summery : MetroFramework.Forms.MetroForm
    {
        public Examination_Result_Summery()
        {
            InitializeComponent();
        }

        private void Examination_Result_Summery_Load(object sender, EventArgs e)
        {

        }

        private void pic_rlogo_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            this.Close();
            r.Show()
        }
    }
}
