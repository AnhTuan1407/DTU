using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN
{
    public class SinhVienDienTu : SinhVienKCNTT
    {
        private double diemEE200;
        private double diemEE201;
        private double diemEE205;

        public double DiemEE200 { get => diemEE200; set => diemEE200 = value; }
        public double DiemEE201 { get => diemEE201; set => diemEE201 = value; }
        public double DiemEE205 { get => diemEE205; set => diemEE205 = value; }
    }
}
