using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex1
{
    class Xe
    {
        private String bienso;
        private string tenxe;
        private DateTime ngaydangkiem;
        private int tieuchuanban;

        public Xe(string bienso, string tenxe, DateTime ngaydangkiem, int tieuchuanban)
        {
            this.bienso = bienso;
            this.tenxe = tenxe;
            this.ngaydangkiem = ngaydangkiem;
            this.tieuchuanban = tieuchuanban;
        }

        public string Bienso { get => bienso; set => bienso = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public DateTime Ngaydangkiem { get => ngaydangkiem; set => ngaydangkiem = value; }
        public int Tieuchuanban { get => tieuchuanban; set => tieuchuanban = value; }
    }
}
