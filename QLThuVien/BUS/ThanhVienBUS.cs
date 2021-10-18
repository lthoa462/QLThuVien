using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DAO;
using QLThuVien.DTO;

namespace QLThuVien.BUS
{
    class ThanhVienBUS
    {
        ThanhVienDAO dao = new ThanhVienDAO();
        public DataTable getThanhVien()
        {
            return dao.getThanhVien();
        }
        public bool addThanhVien(ThanhVienDTO tv)
        {
            return dao.addThanhVien(tv);
        }
        public bool editThanhVien(ThanhVienDTO tv)
        {
            return dao.editThanhVien(tv);
        }
        public bool deletThanhVien(int id)
        {
            return dao.deleteThanhVien(id);
        }

    }
}
