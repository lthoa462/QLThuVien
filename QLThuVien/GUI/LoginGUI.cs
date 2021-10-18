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
using QLThuVien.GUI;

namespace QLThuVien
{
    public partial class Form1 : Form
    {
        LoginBUS bus = new LoginBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text != "" && txt_Password.Text != "")
            {
                if (bus.login(txt_Username.Text, txt_Password.Text))
                {
                    QuanLyThanhVienGUI f = new QuanLyThanhVienGUI();
                    f.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng!!!");
                }
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin");   
        }
    }
}
