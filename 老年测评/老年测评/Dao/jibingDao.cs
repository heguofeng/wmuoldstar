using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace 老年测评.Dao
{
    class jibingDao
    {
        //保存信息
        public int save(string tb1, string a1, string tb2, string cb1, string tb3, string tb4, string cb2, string cb3, string cb4, string cb5, string chb1, string rb1, string tb5, string tb6, string tb7, string tb9, string tb8, string tb11, string tb10, string tb13, string tb12, string tb15, string tb14, string tb17, string tb16, string tb19, string tb18, string cb7, string cb8,string cb9,string rtb1)
        {
            string sql = "insert into jibing(jb_listenL,u_name,jb_listenR,jb_mainlisten,jb_visionL,jb_visionR,jb_mainvision,jb_teeth,jb_eat,jb_sleep,jb_glasses,jb_gxy,jb_gxytime,jb_mostA,jb_mostB,jb_nowA,jb_nowB,jb_lyingA,jb_lyingB,jb_standA,jb_standB,jb_oneA,jb_oneB,jb_threeA,jb_threeB,jb_fiveA,jb_fiveB,jb_low,jb_high,jb_gbqk,jb_zd) values(@jb_listenL,@u_name,@jb_listenR,@jb_mainlisten,@jb_visionL,@jb_visionR,@jb_mainvision,@jb_teeth,@jb_eat,@jb_sleep,@jb_glasses,@jb_gxy,@jb_gxytime,@jb_mostA,@jb_mostB,@jb_nowA,@jb_nowB,@jb_lyingA,@jb_lyingB,@jb_standA,@jb_standB,@jb_oneA,@jb_oneB,@jb_threeA,@jb_threeB,@jb_fiveA,@jb_fiveB,@jb_low,@jb_high,@jb_gbqk,@jb_zd)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("jb_listenL",tb1),
                new SqlParameter("u_name",a1),
                new SqlParameter("jb_listenR",tb2),
                new SqlParameter("jb_mainlisten",cb1),
                new SqlParameter("jb_visionL",tb3),
                new SqlParameter("jb_visionR",tb4),
                new SqlParameter("jb_mainvision",cb2),
                new SqlParameter("jb_teeth",cb3),
                new SqlParameter("jb_eat",cb4),
                new SqlParameter("jb_sleep",cb5),
                new SqlParameter("jb_glasses",chb1),
                new SqlParameter("jb_gxy",rb1),
                new SqlParameter("jb_gxytime",tb5),
                new SqlParameter("jb_mostA",tb6),
                new SqlParameter("jb_mostB",tb7),
                new SqlParameter("jb_nowA",tb9),
                new SqlParameter("jb_nowB",tb8),
                new SqlParameter("jb_lyingA",tb11),
                new SqlParameter("jb_lyingB",tb10),
                new SqlParameter("jb_standA",tb13),
                new SqlParameter("jb_standB",tb12),
                new SqlParameter("jb_oneA",tb15),
                new SqlParameter("jb_oneB",tb14),
                new SqlParameter("jb_threeA",tb17),
                new SqlParameter("jb_threeB",tb16),
                new SqlParameter("jb_fiveA",tb19),
                new SqlParameter("jb_fiveB",tb18),
                new SqlParameter("jb_low",cb7),
                new SqlParameter("jb_high",cb8),
                new SqlParameter("jb_gbqk",cb9),
                new SqlParameter("jb_zd",rtb1),
            };
            return sqlcontent.content(sql, para);
        }
        //更新信息
        public int update(string tb1, string a1, string tb2, string cb1, string tb3, string tb4, string cb2, string cb3, string cb4, string cb5, string chb1, string rb1, string tb5, string tb6, string tb7, string tb9, string tb8, string tb11, string tb10, string tb13, string tb12, string tb15, string tb14, string tb17, string tb16, string tb19, string tb18, string cb7, string cb8, string cb9, string rtb1)
        {
            string sql = "update jibing set jb_listenL=@jb_listenL,u_name=@u_name,jb_listenR=@jb_listenR,jb_mainlisten=@jb_mainlisten,jb_visionL=@jb_visionL,jb_visionR=@jb_visionR,jb_mainvision=@jb_mainvision,jb_teeth=@jb_teeth,jb_eat=@jb_eat,jb_sleep=@jb_sleep,jb_glasses=@jb_glasses,jb_gxy=@jb_gxy,jb_gxytime=@jb_gxytime,jb_mostA=@jb_mostA,jb_mostB=@jb_mostB,jb_nowA=@jb_nowA,jb_nowB=@jb_nowB,jb_lyingA=@jb_lyingA,jb_lyingB=@jb_lyingB,jb_standA=@jb_standA,jb_standB=@jb_standB,jb_oneA=@jb_oneA,jb_oneB=@jb_oneB,jb_threeA=@jb_threeA,jb_threeB=@jb_threeB,jb_fiveA=@jb_fiveA,jb_fiveB=@jb_fiveB,jb_low=@jb_low,jb_high=@jb_high,jb_gbqk=@jb_gbqk,jb_zd=@jb_zd ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("jb_listenL",tb1),
                new SqlParameter("u_name",a1),
                new SqlParameter("jb_listenR",tb2),
                new SqlParameter("jb_mainlisten",cb1),
                new SqlParameter("jb_visionL",tb3),
                new SqlParameter("jb_visionR",tb4),
                new SqlParameter("jb_mainvision",cb2),
                new SqlParameter("jb_teeth",cb3),
                new SqlParameter("jb_eat",cb4),
                new SqlParameter("jb_sleep",cb5),
                new SqlParameter("jb_glasses",chb1),
                new SqlParameter("jb_gxy",rb1),
                new SqlParameter("jb_gxytime",tb5),
                new SqlParameter("jb_mostA",tb6),
                new SqlParameter("jb_mostB",tb7),
                new SqlParameter("jb_nowA",tb9),
                new SqlParameter("jb_nowB",tb8),
                new SqlParameter("jb_lyingA",tb11),
                new SqlParameter("jb_lyingB",tb10),
                new SqlParameter("jb_standA",tb13),
                new SqlParameter("jb_standB",tb12),
                new SqlParameter("jb_oneA",tb15),
                new SqlParameter("jb_oneB",tb14),
                new SqlParameter("jb_threeA",tb17),
                new SqlParameter("jb_threeB",tb16),
                new SqlParameter("jb_fiveA",tb19),
                new SqlParameter("jb_fiveB",tb18),
                new SqlParameter("jb_low",cb7),
                new SqlParameter("jb_high",cb8),
                new SqlParameter("jb_gbqk",cb9),
                new SqlParameter("jb_zd",rtb1),
            };
            return sqlcontent.content(sql, para);
        }
        //验证有无重复项
        public DataTable userNameYanzheng(string name)
        {
            string sql = "select u_name from jibing where u_name=@u_name";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@u_name", name) };
            return sqlcontent.dt(sql, para);
        }
        //显示信息
        public DataTable Show(string Name)
        {
            string sql = "select jb_listenL,jb_listenR,jb_mainlisten,jb_visionL,jb_visionR,jb_mainvision,jb_teeth,jb_eat,jb_sleep,jb_glasses,jb_gxy,jb_gxytime,jb_mostA,jb_mostB,jb_nowA,jb_nowB,jb_lyingA,jb_lyingB,jb_standA,jb_standB,jb_oneA,jb_oneB,jb_threeA,jb_threeB,jb_fiveA,jb_fiveB,jb_low,jb_high,jb_gbqk,jb_zd from jibing where u_name=@Name";
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@Name", Name),
            };
            return sqlcontent.dt(sql, para);
        }


    }
}
