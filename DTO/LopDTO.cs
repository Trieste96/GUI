using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        private int ma_lop;
        private string ten_lop;
        private int si_so;
        public int MaLop
        {
            get { return ma_lop; }
            set { ma_lop = value; }
        }
        public string TenLop
        {
            get { return ten_lop; }
            set { ten_lop = value; }
        }
        public int SiSo
        {
            get { return si_so; }
            set { si_so = value; }
        }
        public LopDTO(int _ma_lop, string _ten_lop, int _si_so)
        {
            _ma_lop = ma_lop;
            _ten_lop = ten_lop;
            _si_so = si_so;
        }
    }
}
