using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;

namespace Institute_management_system
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
           // Thread t = new Thread(new ThreadStart(Loading));
          //  t.Start();
            InitializeComponent();
            // for (int i = 0; i <= 550; i++)
            //      Thread.Sleep(10);
            // t.Abort();
            
        }

     /*   void Loading()
        {
            Splash_Screen frm = new Splash_Screen();
            Application.Run(new Splash_Screen());
        }*/

        private void Main_Load(object sender, EventArgs e)
        {
            logo1.BringToFront();
          
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
        }

       

        private void btn_about_Click(object sender, EventArgs e)
        {

            aboutus1.BringToFront();

        }

        private void UC_AboutUs_Load(object sender, EventArgs e)
        {
         
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            logo1.BringToFront();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
      information11.BringToFront();
        }

        private void btn_contus_Click(object sender, EventArgs e)
        {
          contactus11.BringToFront();
        }

        private void logo1_Load(object sender, EventArgs e)
        {

        }
    }
}
