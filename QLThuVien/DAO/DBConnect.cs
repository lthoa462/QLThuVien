using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLThuVien.DAO
{
    class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-57PO3F8\\MSSQLSERVER01;Initial Catalog=QLTV;Integrated Security=True");
    }
}
