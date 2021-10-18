using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLThuVien.DTO;

namespace QLThuVien.DAO
{
    class ThanhVienDAO:DBConnect
    {
        public DataTable getThanhVien()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM THANHVIEN", conn);
            DataTable dtThanhvien = new DataTable();
            adapter.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public bool addThanhVien(ThanhVienDTO tv)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO THANHVIEN(TVNAME,TVPHONE, TVEMAIL VALUE('{0}','{1}','{2}'", tv.Name, tv.Phone, tv.Email);
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0) return true;

            } catch (Exception e)
            {
                Console.WriteLine("Error addThanhVien");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool editThanhVien(ThanhVienDTO tv)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE THANHVIEN SET TVNAME='{0}', TVPHONE='{1}', TVEMAIL='{2}' WHERE ID={3}", tv.Phone, tv.Email, tv.id);
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0) return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error editThanhVien");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteThanhVien(int id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("DELETE FROM THANHVIEN WHERE ID={0}",id);
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error delelteThanhVien");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
