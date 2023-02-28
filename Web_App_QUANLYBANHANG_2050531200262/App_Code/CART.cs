using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_App_QUANLYBANHANG_2050531200262.App_Code
{
    public class CART
    {
        Dictionary<string, ITEM> listcarts;

        public Dictionary<string, ITEM> LISTCARTS
        {
            get { return listcarts; }
        }

        public CART()
        {
            listcarts = new Dictionary<string, ITEM>();
        }

        public void AddCart(String masanpham, string tensanpham, int soluong, double dongia, string hinhanh)
        {
            ITEM item = new ITEM(masanpham, tensanpham, soluong, dongia, hinhanh);
            if (listcarts.ContainsKey(item.MASANPHAM))
                listcarts[item.MASANPHAM].SOLUONG += item.SOLUONG;
            else
                listcarts.Add(item.MASANPHAM, item);
        }

        public void RemoveCart(String masanpham)
        {
            listcarts.Remove(masanpham);
        }

        public double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listcarts.Values)
                total += item.THANHTIEN;
            return total;
        }
    }
}