using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_App_QUANLYBANHANG_2050531200262.App_Code;

namespace Web_App_QUANLYBANHANG_2050531200262
{
    public partial class page_GIOHANG : System.Web.UI.Page
    {

        public void LoadCart()
        {
            CART cart = (CART)Session["CART"];
            this.grvCART.DataSource = cart.LISTCARTS.Values.ToList();
            this.grvCART.DataBind();
            if (grvCART.FooterRow != null)
            {
                this.grvCART.FooterRow.Cells[0].Text = "Tổng tiền = ";
                this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        protected void btnDELETE_Click(object sender, EventArgs e)
        {
            CART cart = (CART)Session["CART"];
            foreach (GridViewRow row in grvCART.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (ckb.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
            }
            Session["CART"] = cart;
            LoadCart();
        }
    }
}