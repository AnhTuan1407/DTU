using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_xe
{
    class XeDuLich : Xe
    {
        private int soChoNgoi;

        public XeDuLich(int soChoNgoi)
        {
            SoChoNgoi = soChoNgoi;
        }

        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }


    }
}
