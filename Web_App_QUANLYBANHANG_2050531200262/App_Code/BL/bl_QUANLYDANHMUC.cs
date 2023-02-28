using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App_QUANLYBANHANG_2050531200262.App_Code.BL
{
    public class bl_QUANLYDANHMUC
    {
        PD.pd_QUANLYDANHMUC pd_quanlydanhmuc;
        Page pageDanhmuc;
        public bl_QUANLYDANHMUC(Page page)
        {
            pd_quanlydanhmuc = new PD.pd_QUANLYDANHMUC();
            pageDanhmuc = page;
        }
        public void hienthi()
        {
            ((GridView)this.pageDanhmuc.FindControl("grvDANHMUC")).DataSource = pd_quanlydanhmuc.BangDanhMuc();
            ((GridView)this.pageDanhmuc.FindControl("grvDANHMUC")).DataBind();
        }
        public void themmoi()
        {
            String tendanhmuc = ((TextBox)this.pageDanhmuc.FindControl("txtTenDanhMuc")).Text;
            int k = pd_quanlydanhmuc.themMoiDanhMuc(tendanhmuc);
        }
        public void Xoa()
        {
            String madanhmuc = ((TextBox)this.pageDanhmuc.FindControl("txtMaDanhMuc")).Text;
            int k = pd_quanlydanhmuc.xoaDanhMuc(madanhmuc);
        }
        public void Capnhat()
        {
            String madanhmuc = ((TextBox)this.pageDanhmuc.FindControl("txtMaDanhMuc")).Text;
            String tendanhmuc = ((TextBox)this.pageDanhmuc.FindControl("txtMaDanhMuc")).Text;
            int k = pd_quanlydanhmuc.suaDanhMuc(madanhmuc, tendanhmuc);
        }

        public void XoaFromGRV(GridViewDeleteEventArgs e)
        {
            String madanhmuc = ((GridView)this.pageDanhmuc.FindControl("grvDANHMUC")).Rows[e.RowIndex].Cells[1].Text;
            int k = pd_quanlydanhmuc.xoaDanhMuc(madanhmuc);
        }

        public void CapnhatGRV(GridViewUpdateEventArgs e)
        {
            String madanhmuc = ((TextBox)((GridView)this.pageDanhmuc.FindControl("grvDANHMUC")).Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            String tendanhmuc = ((TextBox)((GridView)this.pageDanhmuc.FindControl("grvDANHMUC")).Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            int k = pd_quanlydanhmuc.suaDanhMuc(madanhmuc, tendanhmuc);
        }
    }
}