using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_App_QUANLYBANHANG_2050531200262.App_Code;
using Web_App_QUANLYBANHANG_2050531200262.App_Code.BL;

namespace Web_App_QUANLYBANHANG_2050531200262.ADMIN
{
    public partial class pageQUANLYDANHMUC : System.Web.UI.Page
    {
        bl_QUANLYDANHMUC bl_quanlydanhmuc;

        protected void Page_Load(object sender, EventArgs e)
        {
            bl_quanlydanhmuc = new bl_QUANLYDANHMUC(this);
            if (!IsPostBack)
                bl_quanlydanhmuc.hienthi();
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            bl_quanlydanhmuc.themmoi();
            bl_quanlydanhmuc.hienthi();
        }

        protected void grvDANHMUC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grvDANHMUC.PageIndex = e.NewPageIndex;
            bl_quanlydanhmuc.hienthi();
        }
        protected void btnXoa_Click(object sender, EventArgs e)
        {
            bl_quanlydanhmuc.Xoa();
            bl_quanlydanhmuc.hienthi();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            bl_quanlydanhmuc.Capnhat();
            bl_quanlydanhmuc.hienthi();
        }

        protected void grvDANHMUC_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            bl_quanlydanhmuc.XoaFromGRV(e);
            bl_quanlydanhmuc.hienthi();
        }

        protected void grvDANHMUC_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvDANHMUC.EditIndex = e.NewEditIndex;
            bl_quanlydanhmuc.hienthi();
        }

        protected void grvDANHMUC_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            bl_quanlydanhmuc.CapnhatGRV(e);
            grvDANHMUC.EditIndex = -1;
            bl_quanlydanhmuc.hienthi();
        }

        protected void grvDANHMUC_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvDANHMUC.EditIndex = -1;
            bl_quanlydanhmuc.hienthi();
        }
    }
}