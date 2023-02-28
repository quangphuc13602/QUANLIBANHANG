using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App_QUANLYBANHANG_2050531200262
{
    public partial class page_CHITIETSANPHAM : System.Web.UI.Page
    {
        App_Code.XULYDULIEU xulydulieu;
        DataTable tbSANPHAM;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_Code.XULYDULIEU();
            string masanpham = Request.QueryString.Get("MASANPHAM");

            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] { new SqlParameter("@MASANPHAM", masanpham) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MASANPHAM", DBNull.Value) };

            tbSANPHAM = xulydulieu.getTable("psGetCHITIETSANPHAM", pr);
            Repeater2.DataSource = tbSANPHAM;
            Repeater2.DataBind();
            int soluong = Convert.ToInt32(tbSANPHAM.Rows[0]["SOLUONG"].ToString());
            for (int i = 1; i <= soluong; i++)
                this.drSOLUONG.Items.Add(i.ToString());
        }

        protected void btn_GIOHANG_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_Code.CART cart = new App_Code.CART();
            if (tbSANPHAM != null)
            {
                String masanpham = tbSANPHAM.Rows[0]["MASANPHAM"].ToString();
                String tensanpham = tbSANPHAM.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Double.Parse(tbSANPHAM.Rows[0]["DONGIA"].ToString());
                String hinhanh = tbSANPHAM.Rows[0]["HINHANH"].ToString();
                int soluong = Int16.Parse(this.drSOLUONG.SelectedItem.Text);
                
                if (Session["CART"] != null)
                    cart = (App_Code.CART)Session["CART"];

                cart.AddCart(masanpham, tensanpham, soluong, dongia, hinhanh);

                Session["CART"] = cart;

                Response.Redirect("page_GIOHANG.aspx");
            }
        }
    }
}