using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_App_QUANLYBANHANG_2050531200262.App_Code
{
    public class ITEM
    {
        private String masanpham;
        private String tensanpham;
        private int soluong;
        private double dongia;
        private String hinhanh;
        
        public String MASANPHAM
        {
            get { return masanpham; }
            set { masanpham = value; }
        }

        public String TENSANPHAM
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }

        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public double DONGIA
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public String HINHANH
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }

        public double THANHTIEN
        {
            get { return soluong * dongia; }
        }

        public ITEM(String masanpham, String tensanpham, int soluong, double dongia, String hinhanh)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.soluong = soluong;
            this.dongia = dongia;
            this.hinhanh = hinhanh;
        }

        public ITEM() { }
    }
}