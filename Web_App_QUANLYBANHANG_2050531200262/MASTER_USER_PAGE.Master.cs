using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App_QUANLYBANHANG_2050531200262
{
    public partial class MASTER_USER_PAGE : System.Web.UI.MasterPage
    {
        App_Code.XULYDULIEU xulydulieu;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_Code.XULYDULIEU();

            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MaDanhMuc", DBNull.Value);

            this.Repeater1.DataSource = xulydulieu.getTable("psGetDanhMuc",pr);
            this.Repeater1.DataBind();
        }
    }
}