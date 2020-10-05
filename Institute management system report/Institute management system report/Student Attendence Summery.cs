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

namespace Institute_Management_System_Report
{
    public partial class Student_Attendence_Summery : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
     
        public Student_Attendence_Summery()
        {
            InitializeComponent();
        }

        private void Student_Attendence_Summery_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-55LTBAN;Initial Catalog=NIBM;Integrated Security=True");
        }

        private void pic_rlogo_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            this.Close();
            r.Show();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into student values('" + txt_name.Text + "','" + txt_nic.Text + "','" + txt_mark.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
