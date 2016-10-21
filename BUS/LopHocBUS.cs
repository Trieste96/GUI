using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DAO;
using DTO;
namespace BUS
{
    public class LopHocBUS
    {
        LopHocDAO dao;
        public LopHocBUS()
        {
            dao = new LopHocDAO();
        }
        public DataTable load_tenLop()
        { 
            DataTable dt = new DataTable();
            try
            {
                dt = dao.loadDSLop();
            }
            catch (Exception e)
            {
                
                throw e;
            }
            return dt;
        }
        public DataTable loadDSHStheoLop(object MaLop)
        {

            DataTable dt = new DataTable();
            try
            {
                dt = dao.loadDSHStheoLop(Convert.ToInt16(MaLop));
            }
            catch(SqlException)
            {
                
                throw;
            }
            return dt;
        }
    }
}
