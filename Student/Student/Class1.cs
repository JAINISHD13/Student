using System;
using System.Data.SqlClient;
using System.Data;

namespace Student
{
    class Class1
    {
        public SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Class1()
        {
            cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Admin\Documents\Visual Studio 2015\Samples\Student\Student\Registration.mdf; Integrated Security = True";
        }

        public void ins_updt_del(String str)
        {
            cn.Open();
            cmd.CommandText = str;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable sel(String str)
        {
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            cn.Close();
            return dt;

        }

    }
}
