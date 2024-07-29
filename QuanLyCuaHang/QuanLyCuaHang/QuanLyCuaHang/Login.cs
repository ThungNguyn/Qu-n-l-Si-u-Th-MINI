using QuanLyCuaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHang
{

    public partial class Login : Form
    {
        DataTable tblNhanVien;
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            string sql = "select * from tblnhanvien where TenDangNhap=N'" + txtUser.Text + "'and MatKhau =N'" + txtPassword.Text + "'";
            tblNhanVien = Functions.GetDataTable(sql);
            if (tblNhanVien.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMainEdit main = new frmMainEdit(tblNhanVien.Rows[0][5].ToString(), tblNhanVien.Rows[0][1].ToString(), tblNhanVien.Rows[0][7].ToString(), tblNhanVien.Rows[0][6].ToString());
                frmHoaDonBan hdban = new frmHoaDonBan(tblNhanVien.Rows[0][5].ToString(), tblNhanVien.Rows[0][1].ToString(), tblNhanVien.Rows[0][7].ToString(), tblNhanVien.Rows[0][6].ToString());
               
                main.Show();
                main.Logout += Main_Logout;
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đăng nhập");
            }
        }
        private void Main_Logout(object sender, EventArgs e)
        {
            (sender as frmMainEdit).isExit = true;
            (sender as frmMainEdit).Close();
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
            this.Show();

        }
        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
