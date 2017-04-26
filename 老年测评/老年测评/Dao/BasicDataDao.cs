using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 老年测评
{
    class BasicDataDao
    {
        //保存信息
        public int save(string lb1, string tb1, string tb2, string tb3, string tb22, string cb1, string rb1, string tb4, string tb5, string tb6, string tb7, string tb77, string rb2, string tb8, string tb9, string tb10, string tb11, string tb12, string tb13, string tb14, string cb2, string rb3, string tb16, string tb17, string tb18,string rb4,string tb21,string tb20,string tb19,string a1)
        {
            string sql = "insert into basicdata(bd_time, bd_name,bd_birth,bd_jiguan,bd_sex,bd_culture,bd_job,bd_id,bd_phone,bd_telephone,bd_address,bd_num, bd_zy,bd_zyh,bd_ks,bd_ch,bd_byh,bd_height,bd_weight,bd_BMI,bd_ybxs,bd_smoke,bd_snum,bd_stime,bd_sstime,bd_drink,bd_dnum,bd_dtime,bd_ddtime,u_name)  values(@bd_time,@bd_name,@bd_birth,@bd_jiguan,@bd_sex,@bd_culture,@bd_job,@bd_id,@bd_phone,@bd_telephone,@bd_address,@bd_num,@bd_zy,@bd_zyh,@bd_ks,@bd_ch,@bd_byh,@bd_height,@bd_weight,@bd_BMI,@bd_ybxs,@bd_smoke,@bd_snum,@bd_stime,@bd_sstime,@bd_drink,@bd_dnum,@bd_dtime,@bd_ddtime,@u_name)";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_time",lb1),
                 new SqlParameter("bd_name",tb1),
                 new SqlParameter("bd_birth",tb2),
                 new SqlParameter("bd_jiguan",tb3),
                 new SqlParameter("bd_sex",tb22),
                 new SqlParameter("bd_culture",cb1),
                 new SqlParameter("bd_job",rb1),
                 new SqlParameter("bd_id",tb4),
                 new SqlParameter("bd_phone",tb5),
                 new SqlParameter("bd_telephone",tb6),
                 new SqlParameter("bd_address",tb7),
                 new SqlParameter("bd_num",tb77),
                 new SqlParameter("bd_zy",rb2),
                 new SqlParameter("bd_zyh",tb8),
                 new SqlParameter("bd_ks",tb9),
                 new SqlParameter("bd_ch",tb10),
                 new SqlParameter("bd_byh",tb11),
                 new SqlParameter("bd_height",tb12),
                 new SqlParameter("bd_weight",tb13),
                 new SqlParameter("bd_BMI",tb14),
                 new SqlParameter("bd_ybxs",cb2),
                 new SqlParameter("bd_smoke",rb3),
                 new SqlParameter("bd_snum",tb16),
                 new SqlParameter("bd_stime",tb17),
                 new SqlParameter("bd_sstime",tb18),
                 new SqlParameter("bd_drink",rb4),
                 new SqlParameter("bd_dnum",tb21),
                 new SqlParameter("bd_dtime",tb20),
                 new SqlParameter("bd_ddtime",tb19),
                 new SqlParameter("u_name",a1),
             };
            return sqlcontent.content(sql, para);
        }

        //更新信息
        public int update(string lb1, string tb1, string tb2, string tb3, string tb22, string cb1, string rb1, string tb4, string tb5, string tb6, string tb7, string tb77, string rb2, string tb8, string tb9, string tb10, string tb11, string tb12, string tb13, string tb14, string cb2, string rb3, string tb16, string tb17, string tb18, string rb4, string tb21, string tb20, string tb19, string a1)
        {
            string sql = "update basicdata set bd_time=@bd_time, bd_name=@bd_name,bd_birth=@bd_birth,bd_jiguan=@bd_jiguan,bd_sex=@bd_sex,bd_culture=@bd_culture,bd_job=@bd_job,bd_id=@bd_id,bd_phone=@bd_phone,bd_telephone=@bd_telephone,bd_address=@bd_address,bd_num=@bd_num, bd_zy=@bd_zy,bd_zyh=@bd_zyh,bd_ks=@bd_ks,bd_ch=@bd_ch,bd_byh=@bd_byh,bd_height=@bd_height,bd_weight=@bd_weight,bd_BMI=@bd_BMI,bd_ybxs=@bd_ybxs,bd_smoke=@bd_smoke,bd_snum=@bd_snum,bd_stime=@bd_stime,bd_sstime=@bd_sstime,bd_drink=@bd_drink,bd_dnum=@bd_dnum,bd_dtime=@bd_dtime,bd_ddtime=@bd_ddtime,u_name=@u_name";  
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_time",lb1),
                 new SqlParameter("bd_name",tb1),
                 new SqlParameter("bd_birth",tb2),
                 new SqlParameter("bd_jiguan",tb3),
                 new SqlParameter("bd_sex",tb22),
                 new SqlParameter("bd_culture",cb1),
                 new SqlParameter("bd_job",rb1),
                 new SqlParameter("bd_id",tb4),
                 new SqlParameter("bd_phone",tb5),
                 new SqlParameter("bd_telephone",tb6),
                 new SqlParameter("bd_address",tb7),
                 new SqlParameter("bd_num",tb77),
                 new SqlParameter("bd_zy",rb2),
                 new SqlParameter("bd_zyh",tb8),
                 new SqlParameter("bd_ks",tb9),
                 new SqlParameter("bd_ch",tb10),
                 new SqlParameter("bd_byh",tb11),
                 new SqlParameter("bd_height",tb12),
                 new SqlParameter("bd_weight",tb13),
                 new SqlParameter("bd_BMI",tb14),
                 new SqlParameter("bd_ybxs",cb2),
                 new SqlParameter("bd_smoke",rb3),
                 new SqlParameter("bd_snum",tb16),
                 new SqlParameter("bd_stime",tb17),
                 new SqlParameter("bd_sstime",tb18),
                 new SqlParameter("bd_drink",rb4),
                 new SqlParameter("bd_dnum",tb21),
                 new SqlParameter("bd_dtime",tb20),
                 new SqlParameter("bd_ddtime",tb19),
                 new SqlParameter("u_name",a1),
             };
            return sqlcontent.content(sql, para);
        }
        //显示信息1
        public DataTable getName(string Name)
        {
            string sql = "select u_cn,u_birth,u_sex,u_image from users where u_name=@Name";
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@Name", Name),
            };
            return sqlcontent.dt(sql, para);
        }
        //显示信息2
        public DataTable Show(string Name)
        {
            string sql = "select  bd_name,bd_birth,bd_jiguan,bd_sex,bd_culture,bd_job,bd_id,bd_phone,bd_telephone,bd_address,bd_num, bd_zy,bd_zyh,bd_ks,bd_ch,bd_byh,bd_height,bd_weight,bd_BMI,bd_ybxs,bd_smoke,bd_snum,bd_stime,bd_sstime,bd_drink,bd_dnum,bd_dtime,bd_ddtime from basicdata where u_name=@Name";
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@Name", Name),
            };
            return sqlcontent.dt(sql, para);
        }

        //验证有无重复项
        public DataTable userNameYanzheng(string name)
        {
            string sql = "select u_name from basicdata where u_name=@u_name";
            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@u_name", name) };
            return sqlcontent.dt(sql, para);      
        }

        /// <summary>
        ///     功能数据导入
        /// </summary>
         public int gn(string gn_s, string gn_r, string id1)
        {
            string sql = "update basicdata set bd_gn_s=@bd_gn_s,bd_gn_r=@bd_gn_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_gn_s",gn_s),
                 new SqlParameter("bd_gn_r",gn_r),
                 new SqlParameter("@u_name", id1),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        ///     指数衰弱数据导入
        /// </summary>
        public int shuairuo(string sr_r,string id2)
        {
            string sql = "update basicdata set bd_sr_r=@bd_sr_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_sr_r",sr_r),
                 new SqlParameter("@u_name", id2),
              };
             return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 焦虑数据导入
        /// </summary>
        public int jiaolv(string jl_s, string jl_r, string id3)
        {
            string sql = "update basicdata set bd_jl_s=@bd_jl_s,bd_jl_r=@bd_jl_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_jl_s",jl_s),
                 new SqlParameter("bd_jl_r",jl_r),
                  new SqlParameter("@u_name", id3),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 抑郁症数据导入
        /// </summary>
        public int yiyuzheng(string yyz_s, string yyz_r, string id4)
        {
            string sql = "update basicdata set bd_yyz_s=@bd_yyz_s,bd_yyz_r=@bd_yyz_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_yyz_s",yyz_s),
                 new SqlParameter("bd_yyz_r",yyz_r),
                  new SqlParameter("@u_name", id4),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 营养数据导入
        /// </summary>
        public int yingyang(string yy_s, string yy_r, string id5)
        {
            string sql = "update basicdata set bd_yy_s=@bd_yy_s,bd_yy_r=@bd_yy_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_yy_s",yy_s),
                 new SqlParameter("bd_yy_r",yy_r),
                  new SqlParameter("@u_name", id5),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 平衡数据导入
        /// </summary>
        public int pinghen(string ph_s, string ph_r, string id6)
        {
            string sql = "update basicdata set bd_ph_s=@bd_ph_s,bd_ph_r=@bd_ph_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_ph_s",ph_s),
                 new SqlParameter("bd_ph_r",ph_r),
                  new SqlParameter("@u_name", id6),
              };
            return sqlcontent.content(sql, para);
        }
        /// <summary>
        /// 步态数据导入
        /// </summary>
        public int butai(string bt_s, string bt_r, string id7)
        {
            string sql = "update basicdata set bd_bt_s=@bd_bt_s,bd_bt_r=@bd_bt_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_bt_s",bt_s),
                 new SqlParameter("bd_bt_r",bt_r),
                  new SqlParameter("@u_name", id7),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 跌倒数据导入
        /// </summary>
        public int diedao(string dd_s, string dd_r, string id8)
        {
            string sql = "update basicdata set bd_dd_s=@bd_dd_s,bd_dd_r=@bd_dd_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_dd_s",dd_s),
                 new SqlParameter("bd_dd_r",dd_r),
                  new SqlParameter("@u_name", id8),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 便秘数据导入
        /// </summary>
        public int bianmi(string bm_s, string bm_r, string id9)
        {
            string sql = "update basicdata set bd_bm_s=@bd_bm_s,bd_bm_r=@bd_bm_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_bm_s",bm_s),
                 new SqlParameter("bd_bm_r",bm_r),
                  new SqlParameter("@u_name", id9),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 膀胱数据导入
        /// </summary>
        public int pangguang(string pg_s, string pg_r, string id10)
        {
            string sql = "update basicdata set bd_pg_s=@bd_pg_s,bd_pg_r=@bd_pg_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_pg_s",pg_s),
                 new SqlParameter("bd_pg_r",pg_r),
                  new SqlParameter("@u_name", id10),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 尿失禁数据导入
        /// </summary>
        public int niaoshijing(string nsj_s, string nsj_r, string id11)
        {
            string sql = "update basicdata set bd_nsl_s=@bd_nsj_s,bd_nsj_r=@bd_nsj_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_nsj_s",nsj_s),
                 new SqlParameter("bd_nsj_r",nsj_r),
                  new SqlParameter("@u_name", id11),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 前列腺数据导入
        /// </summary>
        public int qianliexian(string qlx_s, string qlx_r, string id12)
        {
            string sql = "update basicdata set bd_qlx_s=@bd_qlx_s,bd_qlx_r=@bd_qlx_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_qlx_s",qlx_s),
                 new SqlParameter("bd_qlx_r",qlx_r),
                  new SqlParameter("@u_name", id12),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// MMSE认知数据导入
        /// </summary>
        public int mmserenzhi(string mmrz_s, string mmrz_r, string id13)
        {
            string sql = "update basicdata set bd_mmrz_s=@bd_mmrz_s,bd_mmrz_r=@bd_mmrz_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_mmrz_s",mmrz_s),
                 new SqlParameter("bd_mmrz_r",mmrz_r),
                  new SqlParameter("@u_name", id13),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// MINI认知数据导入
        /// </summary>
        public int mirenzhi(string mirz_s, string mirz_r, string id14)
        {
            string sql = "update basicdata set bd_mirz_s=@bd_mirz_s,bd_mirz_r=@bd_mirz_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_mirz_s",mirz_s),
                 new SqlParameter("bd_mirz_r",mirz_r),
                  new SqlParameter("@u_name", id14),
              };
            return sqlcontent.content(sql, para);
        }

        /// <summary>
        /// 睡眠质量数据导入
        /// </summary>
        public int shuimian(string sm_s, string sm_r, string id15)
        {
            string sql = "update basicdata set bd_sm_s=@bd_sm_s,bd_sm_r=@bd_sm_r where u_name=@u_name ";
            SqlParameter[] para = new SqlParameter[]
             {
                 new SqlParameter("bd_sm_s",sm_s),
                 new SqlParameter("bd_sm_r",sm_r),
                  new SqlParameter("@u_name", id15),
              };
            return sqlcontent.content(sql, para);
        }

        //显示汇总表分数
        public DataTable huizong(string Name)
        {
            string sql = "select bd_gn_s,bd_sr_s,bd_jl_s,bd_yyz_s,bd_yy_s,bd_ph_s,bd_bt_s,bd_dd_s,bd_bm_s,bd_bg_s,bd_nsj_s,bd_qlx_s,db_mmrz_s,bd_mirz_s,bd_sm_s from basicdata where u_name=@Name";
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@Name", Name),
            };
            return sqlcontent.dt(sql, para);
        }

        
    }
}
