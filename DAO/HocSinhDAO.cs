using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class HocSinhDAO
    {
        public void themSV(SinhVienDTO sv)
        {
            SqlConnection connection = DBConnection.openConnection();
            SqlCommand cmd = new SqlCommand("sp_themSV", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SoDT", SqlDbType.VarChar);
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
            cmd.Parameters.Add("@MaLop", SqlDbType.Int);

            cmd.Parameters["@HoTen"].Value = sv.tenSV;
            cmd.Parameters["@DiaChi"].Value = sv.diaChi;
            cmd.Parameters["@SoDT"].Value = sv.soDT;
            cmd.Parameters["@NgaySinh"].Value = sv.ngaySinh;
            cmd.Parameters["@MaLop"].Value = sv.maLop;
            connection.Open();
            cmd.ExecuteNonQuery();
        }
        public void suaSV(SinhVienDTO sv)
        {
            SqlConnection connection = DBConnection.openConnection();
            SqlCommand cmd = new SqlCommand("sp_suaSV", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.Int);
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SoDT", SqlDbType.VarChar);
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
            cmd.Parameters.Add("@MaLop", SqlDbType.Int);

            cmd.Parameters["@MaSV"].Value = sv.maSV;
            cmd.Parameters["@HoTen"].Value = sv.tenSV;
            cmd.Parameters["@DiaChi"].Value = sv.diaChi;
            cmd.Parameters["@SoDT"].Value = sv.soDT;
            cmd.Parameters["@NgaySinh"].Value = sv.ngaySinh;
            cmd.Parameters["@MaLop"].Value = sv.maLop;
            connection.Open();
            cmd.ExecuteNonQuery();
        }
        public void xoaSV(SinhVienDTO sv)
        {
            SqlConnection connection = DBConnection.openConnection();
            SqlCommand cmd = new SqlCommand("sp_xoaSV", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.Int);
            cmd.Parameters["@MaSV"].Value = sv.maSV;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
