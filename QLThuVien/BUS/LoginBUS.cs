using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DAO;
namespace QLThuVien.BUS
{
    class LoginBUS
    {
        LoginDAO dao = new LoginDAO();
        public bool login(String Username, String Pass)
        {
            return dao.getLogin(Username, Pass);
        }
    }
}
