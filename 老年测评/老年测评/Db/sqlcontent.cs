using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace 老年测评
{
    public class sqlcontent
    {
        //带参数的查询
        public static DataTable dt(string sql, SqlParameter[] para)
        {
            if (concmd.table(sql, para) != null)
            {
                return concmd.table(sql, para);
            }
            else { return null; }
        }
        //不带参数的查询
        public static DataTable dt(string sql)
        {
            if (concmd.table(sql, null) != null)
            {
                return concmd.table(sql, null);
            }
            else { return null; }
        }
        //不带参数的增删改
        public static int content(string sql)
        {
            return concmd.content(sql, null);
        }
        //带参数的增删改
        public static int content(string sql, SqlParameter[] para)
        {
            return concmd.content(sql, para);
        }

    }
}
