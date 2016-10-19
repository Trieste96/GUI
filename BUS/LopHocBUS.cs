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
        public DataTable loadDSHS()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dao.loadDSHS();
            }
            catch(SqlException)
            {
                
                throw;
            }
            return dt;
        }
        public void themSV(SinhVienDTO sv)
        {
            dao.themSV(sv);
        }

        public void suaSV(SinhVienDTO sv)
        {
            dao.suaSV(sv);
        }
        public void xoaSV(SinhVienDTO sv)
        {
            dao.xoaSV(sv);
        }
        public bool validateName(string name)
        {
            string pattern = @"^(\p{Lu}[\p{Ll}]+\s)+\p{Lu}[\p{Ll}]+$";
            return Regex.IsMatch(name.Trim(), pattern);
        }
        public bool validatePhoneNumber(string number)
        {
            string pattern = @"^\d{8,15}$";
            return Regex.IsMatch(number, pattern);
        }
    }
}
