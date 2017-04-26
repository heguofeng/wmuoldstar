using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 老年测评.Dao
{
    class jiatingDao
    {
        //添加数据
        public int save(string a1, string cb1, string cb2, string cb3, string cb4, string cb5, string tb1, string chb1)
        {
            string sql = "insert into jiating(u_name,jt_marry,jt_cqzs,jt_ks,jt_zjxy,jt_child,jt_times,jt_care) values (@u_name,@jt_marry,@jt_cqzs,@jt_ks,@jt_zjxy,@jt_child,@jt_times,@jt_care)";
            SqlParameter[] para=new SqlParameter[]
            {
                new SqlParameter("@u_name", a1), 
                new SqlParameter("@jt_marry", cb1), 
                new SqlParameter("@jt_cqzs", cb2), 
                new SqlParameter("@jt_ks", cb3), 
                new SqlParameter("@jt_zjxy", cb4), 
                new SqlParameter("@jt_child", cb5), 
                new SqlParameter("@jt_times", tb1), 
                new SqlParameter("@jt_care", chb1),    
            };//将以上控件内的内容分别通过参数添加到数据库的相应表格中
            return sqlcontent.content(sql, para);
        }

        //更新数据
        public int update(string a1, string cb1, string cb2, string cb3, string cb4, string cb5, string tb1, string chb1)
        {
            string sql = "update jiating set u_name=@u_name,jt_marry=@jt_marry,jt_cqzs=@jt_cqzs,jt_ks=@jt_ks,jt_zjxy=@jt_zjxy,jt_child=@jt_child,jt_times=@jt_times,jt_care=@jt_care";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@u_name", a1), 
                new SqlParameter("@jt_marry", cb1), 
                new SqlParameter("@jt_cqzs", cb2), 
                new SqlParameter("@jt_ks", cb3), 
                new SqlParameter("@jt_zjxy", cb4), 
                new SqlParameter("@jt_child", cb5), 
                new SqlParameter("@jt_times", tb1), 
                new SqlParameter("@jt_care", chb1),    
            };//将以上控件内的内容分别通过参数添加到数据库的相应表格中
            return sqlcontent.content(sql, para);
        }

        //验证有无重复项
        public DataTable userNameYanzheng(string name)
        {
            string sql = "select u_name from jiating where u_name=@u_name";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@u_name", name) };
            return sqlcontent.dt(sql, para);
        }
        //显示信息
        public DataTable Show(string Name)
        {
            string sql = "select jt_marry,jt_cqzs,jt_ks,jt_zjxy,jt_child,jt_times,jt_care from jiating where u_name=@Name";
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@Name", Name),
            };
            return sqlcontent.dt(sql, para);
        }
    }
}
