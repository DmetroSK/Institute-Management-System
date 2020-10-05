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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

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

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            MIS m = new MIS();
            this.Hide();
            m.Show();
        }

        private void tile_sturegister_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.Show();
        }

        private void tile_staffregister_Click(object sender, EventArgs e)
        {
            Staff_Registration sf = new Staff_Registration();
            this.Hide();
            sf.Show();
            
        }
    }
}
