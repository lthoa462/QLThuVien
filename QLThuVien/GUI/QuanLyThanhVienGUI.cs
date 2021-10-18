using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.BUS;
using QLThuVien.DTO;

namespace QLThuVien.GUI
{
    public partial class QuanLyThanhVienGUI : Form
    {
        ThanhVienBUS bus = new ThanhVienBUS();

        public QuanLyThanhVienGUI()
        {
            InitializeComponent();
            view_ThanhVien.DataSource = bus.getThanhVien();
        }


        private void ThanhVienGUI_Load(object sender, EventArgs e)
        {
            view_ThanhVien.DataSource = bus.getThanhVien();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_Hoten.Text != "" && txt_SDT.Text != "" && txt_Email.Text != "")
            {
                ThanhVienDTO tv = new ThanhVienDTO(0, txt_Hoten.Text, txt_SDT.Text, txt_Email.Text);
                if (bus.addThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công!");
                    view_ThanhVien.DataSource = bus.getThanhVien();
                }
                else MessageBox.Show("Thêm thất bại!");
            }
            else MessageBox.Show("Vui lóng nhập đầy đủ thông tin!");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (view_ThanhVien.SelectedRows.Count > 0)
            {
                if (txt_Hoten.Text != "" && txt_SDT.Text != "" && txt_Email.Text != "")
                {
                    DataGridViewRow row = view_ThanhVien.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    ThanhVienDTO tv = new ThanhVienDTO(ID, txt_Hoten.Text, txt_SDT.Text, txt_Email.Text);
                    if (bus.editThanhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công!");
                        view_ThanhVien.DataSource = bus.getThanhVien();
                    }
                    else MessageBox.Show("Sửa không thành công!");
                }
                else MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else MessageBox.Show("Hãy chọn thành viên muốn sửa!");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (view_ThanhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = view_ThanhVien.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (bus.deletThanhVien(ID))
                {
                    MessageBox.Show("Xóa thành công!");
                    view_ThanhVien.DataSource = bus.getThanhVien();
                }
                else MessageBox.Show("Xóa không thành công!");
            }
            else MessageBox.Show("Hãy chọn thành viên muốn xóa!");
        }
    }
}
