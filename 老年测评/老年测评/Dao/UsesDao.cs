using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace 老年测评
{
    public class UsesDao
    {
        //查询用户名有效性
        public DataTable userNameYanzheng(string name)
        {
            string sql = "select u_name from users where u_name=@u_name";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@u_name", name) };
            return sqlcontent.dt(sql, para);
        }

        //注册信息
        public int zhuce(string tb1, string tb2, string tb3,string birth ,string sex, string tb5, string imgpath)
        {
            string sql = "insert into users(u_name,u_psw,u_cn,u_birth,u_sex,u_email,u_image) values(@u_name,@u_psw,@u_cn,@u_birth,@u_sex,@u_email,@u_image)";//添加命令
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@u_name", tb1), 
                new SqlParameter("@u_psw", tb2),
                new SqlParameter("@u_cn",tb3),     
                new SqlParameter("@u_birth", birth),
                new SqlParameter("@u_sex", sex),
                new SqlParameter("@u_email",tb5),
                new SqlParameter("@u_image",imgpath),  
            };//将以上控件内的内容分别通过参数添加到数据库的相应表格中

            return sqlcontent.content(sql, para);
        }
        
        //验证普通用户登录有效性
        public DataTable login(string name, string psw)
        {
            string sql = "select u_name from users where u_name=@u_name and u_psw=@u_psw";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@u_name", name), new SqlParameter("@u_psw", psw) };
            return sqlcontent.dt(sql, para);
        }
   
    }
}
