using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTichDiem.Class
{
    class database
    {
        public static string connect = @"Data Source=125.212.201.52;Initial Catalog=NFC;Persist Security Info=True;User ID=coneknfc;Password=Conek@123;MultipleActiveResultSets=True";

        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                return conn;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Kết Nối Thất bại. Vui lòng kiểm tra lại đường truyền.", "Lỗi" + ex.Message);
                return null;
            }
        }

        public static DataTable getData(SqlCommand command)
        {
            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = command;
                cmd.Connection = con;
                cmd.CommandTimeout = 0;
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);

                if (con.State == ConnectionState.Open)
                    con.Close();

                return dt;
            }
        }
        public static int ExcuteNonQuery(SqlCommand command)
        {

            SqlCommand cmd = command;
            cmd.Connection = getConnection();
            if (cmd.Connection.State == 0)
                cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Connection.Dispose();
            return i;
        }

        public static string ExecuteScalar(SqlCommand cmdCommand)
        {
            SqlCommand cmd = cmdCommand;
            cmd.Connection = getConnection();
            if (cmd.Connection.State == 0)
                cmd.Connection.Open();
            string i = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
            cmd.Connection.Dispose();
            return i;
        }
    }
}
