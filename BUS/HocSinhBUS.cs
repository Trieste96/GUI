using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DTO;
using DAO;

namespace BUS
{
    public class HocSinhBUS
    {
        private HocSinhDAO dao = new HocSinhDAO();
        public void themHS(HocSinhDTO hs)
        {
            try
            {
                dao.themHS(hs);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void suaHS(HocSinhDTO hs)
        {
            try
            {
                dao.suaHS(hs);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void xoaHS(HocSinhDTO hs)
        {
            try
            {
                dao.xoaHS(hs);
            }
            catch (Exception)
            {

                throw;
            }
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
