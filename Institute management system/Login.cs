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



namespace Institute_management_system
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
      // SqlConnection con;
       // SqlCommand cmd;

        Database db = new Database();

        static Login _instance;

        public void StrartForm()
        {
          
        }

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
        }
        public Login()
        {   
   
            InitializeComponent();
            
        }

      
      

        private void Form1_Load(object sender, EventArgs e)
        {
        //  con = new SqlConnection("Data Source=.;Initial Catalog=RITdb;Integrated Security=True");

        }
       

        private void pic_logo_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userName.Text) & string.IsNullOrEmpty(txt_password.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter Details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else if (string.IsNullOrEmpty(txt_userName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if(string.IsNullOrEmpty(txt_password.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               string search= txt_userName.Text;
               string ss = new string(search.Take(2).ToArray());

                string query = "select count(*) from login where username='" + txt_userName.Text + "' and password='" + txt_password.Text + "'";
                 /* con.Open();
                  SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username='" + txt_userName.Text + "' and password='" + txt_password.Text + "'", con);
                  con.Close();
                  DataTable dt = new DataTable();
                  sda.Fill(dt);*/
               // DataTable dt = new DataTable();
               DataTable dt= db.GetData(query);

               if (dt.Rows[0][0].ToString() == "1")
                {
                    if (ss == "ST")
                    {
                        this.Hide();
                        Student s = new Student();
                        s.Show();
                    }
                    else if (ss == "LE")
                    {
                        this.Hide();
                        Lecturer l = new Lecturer();
                        l.Show();
                    }
                    else if (ss == "EX")
                    {
                        this.Hide();
                        Examination_Department ex = new Examination_Department();
                        ex.Show();
                    }
                    else if (ss == "MI")
                    {
                        this.Hide();
                        MIS M = new MIS();
                        M.Show();
                    }
                    else if (ss == "AC")
                    {
                        this.Hide();
                        Account_Department a = new Account_Department();
                        a.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please check your User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
     
            }
        }

      

        private void link_signup_Click_1(object sender, EventArgs e)
        {
            Sign_Up s = new Sign_Up();
            this.Hide();
            s.Show();
        }

        private void link_forgot_Click(object sender, EventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            this.Hide();
            f.Show();
        }


        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.ShowDialog();
        }
    }
}
