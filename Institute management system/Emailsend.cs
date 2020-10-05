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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace Institute_management_system
{
    public partial class Emailsend : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();

        public Emailsend()
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

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            Lecturer l = new Lecturer();
            this.Hide();
            l.Show();
        }


        private void btn_send_Click_2(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(txt_add.Text,txt_pw.Text);
                MailMessage msg = new MailMessage();
                msg.To.Add(txt_to.Text);
                msg.From = new MailAddress(txt_add.Text);
                msg.Subject = txt_sub.Text;
                msg.Body = txt_body.Text;
                client.Send(msg);
                MetroFramework.MetroMessageBox.Show(this, "Successfully sent message", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter correct data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
