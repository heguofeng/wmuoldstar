using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace 老年测评.Dao
{
    class itemsDao
    {
        public DataTable items()
        {
            string sql = "select * from items";
            SqlParameter[] para = new SqlParameter[] 
            { 
              
            };
            return sqlcontent.dt(sql, para);
        }

        //显示汇总表结果
        public DataTable huizongB(string Name1)
        {
            // string sql = "select bd_gn_s,bd_sr_s,bd_jl_s,bd_yyz_s,bd_yy_s,bd_ph_s,bd_bt_s,bd_dd_s,bd_bm_s,bd_bg_s,bd_nsj_s,bd_qlx_s,db_mmrz_s,bd_mirz_s,bd_sm_s from basicdata where u_name=@Name";
            string sql = "select bd_gn_r,bd_sr_r,bd_jl_r,bd_yyz_r,bd_yy_r,bd_ph_r,bd_bt_r,bd_dd_r,bd_bm_r,bd_bg_r,bd_nsj_r,bd_qlx_r,bd_mmrz_r,bd_mirz_r,bd_sm_r from basicdata where u_name=@Name";
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@Name", Name1),
            };
            return sqlcontent.dt(sql, para);
        }
    }
}
