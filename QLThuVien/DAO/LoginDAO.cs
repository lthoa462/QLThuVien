using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static QLThuVien.DTO.LoginDTO;

namespace QLThuVien.DAO
{
    class LoginDAO:DBConnect
    {
        public bool getLogin(String username, String Pass)
        {
            try
            {
                conn.Open();
                String sql = String.Format("SELECT LGPASS FROM LOGIN WHERE LGUSERNAME='{0}'", username);
                SqlCommand cmd = new SqlCommand(sql, conn);
                var request = cmd.ExecuteScalar();
                String pass;
                try { pass = request.ToString(); }
                catch (Exception e)
                {
                     pass = "1";
                }
                if (pass.Equals(Pass)) return true;
            } catch (Exception e)
            {
                Console.WriteLine("Error Login");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        
    }
}
