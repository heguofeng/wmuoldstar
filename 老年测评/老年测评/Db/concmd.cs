using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 老年测评
{
    public class concmd
    {
        //创建并初始化操作句柄SQLCommand
        public static SqlCommand creatcmd(string sql)
        {
            SqlConnection conn = confactory.getcon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText=sql;
            return cmd;
        }

        //查询操作
        public static DataTable table(string sql, SqlParameter[] para)
        {
            SqlCommand cmd = creatcmd(sql);
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            DataTable datatable = new DataTable("table");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(datatable);
            cmd.Dispose();
            cmd.Parameters.Clear();
            return datatable;
            
        }

        //adapter
        public static SqlDataAdapter adapter(string sql, SqlParameter[] para)
        {
            SqlCommand cmd = creatcmd(sql);
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            DataTable datatable = new DataTable("table");
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(datatable);
            cmd.Dispose();
            cmd.Parameters.Clear();
            return sda;
        }

        //非查询操作
        public static int content(string sql,SqlParameter[] para)
        {
            SqlCommand cmd = creatcmd(sql);
            try
            { 
                cmd.Connection.Open();
                if (para != null)
                {
                    cmd.Parameters.AddRange(para);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
