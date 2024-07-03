using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class NhanVien : Nguoi
    {
        private string maNhanVien;
        private DateTime ngayVaoCoQuan;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public DateTime NgayVaoCoQuan { get => ngayVaoCoQuan; set => ngayVaoCoQuan = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma nhan vien: ");
            maNhanVien = Console.ReadLine();
            Console.Write("Nhap ngay vao co quan: ");
            ngayVaoCoQuan = DateTime.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien: " + maNhanVien);
            Console.WriteLine("Ngay vao co quan: " + ngayVaoCoQuan);
        }
    }

}
