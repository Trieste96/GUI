
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhDTO
    {
        public HocSinhDTO(int mahs, string ten, string diachi, string sodt, string ngaysinh, int malop)
        {
            maHS    = mahs;
            tenHS   = ten;
            diaChi  = diachi;
            soDT    = sodt;
            ngaySinh= ngaysinh;
            maLop   = malop;
        }
        public int maHS { get; set; }
        public string tenHS { get; set; }
        public string diaChi { get; set; }
        public string soDT { get; set; }
        public string ngaySinh { get; set; }
        public int maLop { get; set; }
    }

}
