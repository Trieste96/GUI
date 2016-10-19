
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienDTO
    {
        public SinhVienDTO(int masv, string ten, string diachi, string sodt, string ngaysinh, int malop)
        {
            maSV    = masv;
            tenSV   = ten;
            diaChi  = diachi;
            soDT    = sodt;
            ngaySinh= ngaysinh;
            maLop   = malop;
        }
        public int maSV { get; set; }
        public string tenSV { get; set; }
        public string diaChi { get; set; }
        public string soDT { get; set; }
        public string ngaySinh { get; set; }
        public int maLop { get; set; }
    }

}
