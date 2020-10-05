using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Institute_management_system
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public void openCon()
        {
            con.Open();
        }

        public void closeCon()
        {
            con.Close();
        }

        public Database()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=RITdb;Integrated Security=True");
        }

      public DataTable GetData(string query)
        {
            
                openCon();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeCon();
            return dt;
        }
         public int signupCheck(string query)
        {
            openCon();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
          int line= da.Fill(dt);
            closeCon();
            return line;
        }

        public int signup(string query1)
        {

            openCon();
            cmd = new SqlCommand(query1,con);
            DataTable dt = new DataTable();
            int line = cmd.ExecuteNonQuery();

            closeCon();
            return line;
        }

        public int save_update_delete(string query)
        {
            openCon();
            cmd = new SqlCommand(query, con);
            int line = cmd.ExecuteNonQuery();
            closeCon();
            return line;
        }

       
    }
}
