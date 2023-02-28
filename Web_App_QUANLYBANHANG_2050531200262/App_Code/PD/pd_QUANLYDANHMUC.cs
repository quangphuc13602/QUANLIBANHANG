using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web_App_QUANLYBANHANG_2050531200262.App_Code.PD
{
    public class pd_QUANLYDANHMUC
    {
        XULYDULIEU xulydulieu;

        public pd_QUANLYDANHMUC()
        {
            xulydulieu = new XULYDULIEU();
        }
        public DataTable BangDanhMuc()
        {
            DataTable tb;
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MADANHMUC", DBNull.Value);
            tb = xulydulieu.getTable("psGetDanhMuc", pr);
            return tb;
        }
        public int themMoiDanhMuc(String tendanhmuc)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@TENDANHMUC", tendanhmuc);
            int k = xulydulieu.ExeCute("psAddDanhmuc", pr);
            return k;
        }
        public int xoaDanhMuc(String madanhmuc)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MADANHMUC", madanhmuc);
            int k = xulydulieu.ExeCute("psDELETEDanhmuc", pr);
            return k;
        }
        public int suaDanhMuc(String madanhmuc, String tendanhmuc)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@MADANHMUC", madanhmuc);
            pr[1] = new SqlParameter("@TENDANHMUC", tendanhmuc);
            int k = xulydulieu.ExeCute("psUPDATEDanhmuc", pr);
            return k;
        }
    }
}