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
    public class LopHocDAO
    {
        public DataTable executeSP(string cmdText)
        {
            DataTable dt = new DataTable();
            SqlConnection conn;
            try
            {
                conn = DBConnection.openConnection();
            }
            catch (SqlException)
            {
                throw;
                //return null;
            }
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable loadDSLop()
        {
            return executeSP("sp_load_lop");
        }
        public DataTable loadDSSVtheoLop(int maLop)
        {
            SqlConnection conn = DBConnection.openConnection();
            SqlCommand cmd = new SqlCommand("sp_DSSV_theo_lop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLop", SqlDbType.Int);
            cmd.Parameters["@MaLop"].Value = maLop;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        
    }
}
