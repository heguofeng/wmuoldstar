using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 老年测评
{
    public class confactory
    {
        private static string constr=conString.connstr; 

        //获取连接
        public static SqlConnection getcon()
        {
            return creatcon();
        }
        //创建连接
        public static SqlConnection creatcon()
        {
            SqlConnection conn = new SqlConnection(constr);
            return conn;
        }
        //打开连接
        public static void openconn(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //关闭连接
        public static void closeconn(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
