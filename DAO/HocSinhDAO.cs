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
        public void themHS(HocSinhDTO hs)
        {
            try
            {
                SqlConnection connection = DBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("sp_themHS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@SoDT", SqlDbType.VarChar);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
                cmd.Parameters.Add("@MaLop", SqlDbType.Int);

                cmd.Parameters["@HoTen"].Value = hs.tenHS;
                cmd.Parameters["@DiaChi"].Value = hs.diaChi;
                cmd.Parameters["@SoDT"].Value = hs.soDT;
                cmd.Parameters["@NgaySinh"].Value = hs.ngaySinh;
                cmd.Parameters["@MaLop"].Value = hs.maLop;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public void suaHS(HocSinhDTO hs)
        {
            try
            {
                SqlConnection connection = DBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("sp_suaHS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHS", SqlDbType.Int);
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@SoDT", SqlDbType.VarChar);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime);
                cmd.Parameters.Add("@MaLop", SqlDbType.Int);

                cmd.Parameters["@MaHS"].Value = hs.maHS;
                cmd.Parameters["@HoTen"].Value = hs.tenHS;
                cmd.Parameters["@DiaChi"].Value = hs.diaChi;
                cmd.Parameters["@SoDT"].Value = hs.soDT;
                cmd.Parameters["@NgaySinh"].Value = hs.ngaySinh;
                cmd.Parameters["@MaLop"].Value = hs.maLop;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        public void xoaHS(HocSinhDTO hs)
        {
            try
            {
                SqlConnection connection = DBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("sp_xoaHS", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHS", SqlDbType.Int);
                cmd.Parameters["@MaHS"].Value = hs.maHS;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
