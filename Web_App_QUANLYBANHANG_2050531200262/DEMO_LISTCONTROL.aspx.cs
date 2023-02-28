using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_App_QUANLYBANHANG_2050531200262.App_Code;

namespace Web_App_QUANLYBANHANG_2050531200262
{
    public partial class DEMO_LISTCONTROL : System.Web.UI.Page
    {
        XULYDULIEU xulydulieu;
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new XULYDULIEU();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MaDanhMuc", DBNull.Value);

            DataTable tb = xulydulieu.getTable("psGetDanhMuc", pr);
            ListBox1.DataSource = tb;
            ListBox1.DataTextField = "TENDANHMUC";
            ListBox1.DataValueField = "MADANHMUC";
            ListBox1.DataBind();

            DropDownList1.DataSource = tb;
            DropDownList1.DataTextField = "TENDANHMUC";
            DropDownList1.DataValueField = "MADANHMUC";
            DropDownList1.DataBind();

            CheckBoxList1.DataSource = tb;
            CheckBoxList1.DataTextField = "TENDANHMUC";
            CheckBoxList1.DataValueField = "MADANHMUC";
            CheckBoxList1.DataBind();

            RadioButtonList1.DataSource = tb;
            RadioButtonList1.DataTextField = "TENDANHMUC";
            RadioButtonList1.DataValueField = "MADANHMUC";
            RadioButtonList1.DataBind();
            
            //for (int i = 0; i < 10; i++)
            //{
            //    ListItem item = new ListItem();
            //    item.Text = i.ToString();
            //    item.Value = i.ToString();
            //    ListBox1.Items.Add(item);
            //    DropDownList1.Items.Add(item);
            //    CheckBoxList1.Items.Add(item);
            //    RadioButtonList1.Items.Add(item);
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(ListBox1.SelectedItem);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int indexitem = ListBox1.SelectedIndex;
            ListBox1.Items.RemoveAt(indexitem);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int indexitem = ListBox1.SelectedIndex;
            ListBox1.Items[indexitem].Enabled = false;
        }
    }
}