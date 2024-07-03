using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYNV
{
    abstract class NhanVien
    {
        string hoten;
        int namsinh;
        string gioitinh;
        string cmnd;
        string manv;

        public string Hoten { get => hoten; set => hoten = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Manv { get => manv; set => manv = value; }

        public abstract void Nhap();
        public abstract void Xuat();
    }
}
