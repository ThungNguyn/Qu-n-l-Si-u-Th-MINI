using QuanLyCuaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmMainEdit : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        DataTable tblNhanVien;
        string TenDangNhap = "", TenNhanVien = "", MatKhau = "", Quyen = "";
        public frmMainEdit(string TenDangNhap, string TenNhanVien, string MatKhau, string Quyen)
        {
            InitializeComponent();
            cutomizeDesing();
            this.TenDangNhap = TenDangNhap;
            this.TenNhanVien = TenNhanVien;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }
        private void cutomizeDesing()
        {
            panelbaocao.Visible = false;
            paneldanhmuc.Visible = false;
            panelhoadon.Visible = false;
            paneltaptin.Visible = false;
            //paneltimkiem.Visible = false;
            
        }
        private void hideSubMenu()
        {
            if (panelbaocao.Visible == true)
                panelbaocao.Visible = false;
            if (paneldanhmuc.Visible == true)
                paneldanhmuc.Visible = false;
            if (panelhoadon.Visible == true)
                panelhoadon.Visible = false;
            //if (paneltimkiem.Visible == true)
            //    paneltimkiem.Visible = false;
            if (paneltaptin.Visible == true)
                paneltaptin.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //Show Tap tin
        #region Tap tin
        private void btn_taptin_Click(object sender, EventArgs e)
        {
            
            showSubMenu(paneltaptin);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
            hideSubMenu();
        }
#endregion
        // Show danh muc
        #region Danh Muc
        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            showSubMenu(paneldanhmuc);
        }

        private void btn_chatlieu_Click(object sender, EventArgs e)
        {
         
            openFormChill(new frmDMLoai());

            hideSubMenu();
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            //if(Quyen =="user" || Quyen =="admin")
            //{
            //}    
             openFormChill(new frmDMHangHoa());
    
            hideSubMenu();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {

                openFormChill(new frmDMNhanVien());
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập");
            }

            hideSubMenu();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            //if (Quyen == "user" || Quyen == "admin")
            //{
            //}
            openFormChill(new frmDMKhachHang());
            hideSubMenu();
        }
#endregion
        // Show hoa don
        #region hoa Don
        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelhoadon);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            openFormChill(new frmHoaDonBan(TenDangNhap, TenNhanVien, MatKhau, Quyen));
            hideSubMenu();
        }
#endregion
        // Show tim kiem
        #region Tiem Kiem
        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            //showSubMenu(paneltimkiem);
           
        }

        private void btn_timhoadon_Click(object sender, EventArgs e)
        {
            //openFormChill(new frmTimHDBan());
            //hideSubMenu();
        }

        private void btn_timhanghoa_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_timkhachhang_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        //Show bao cao
        #region Bao cao
        private void btn_baocao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelbaocao);
        }

       
       
        private void btn_trogiup_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        #endregion

        private void btn_ncc_Click(object sender, EventArgs e)
        {
            openFormChill(new frmDMNhaCC());

            hideSubMenu();
        }

        private void panelChillForm_Paint(object sender, PaintEventArgs e)
        {

        }

        // hiển thị form report nhân viên
        private void btn_bcnhanvien_Click(object sender, EventArgs e)
        {
            openFormChill(new FormReport());
            hideSubMenu();
        }

        #region Event
        private void frmMainEdit_FormClose(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
                Application.Exit();
        }
        private void frmMainEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit == true)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes) ;
                e.Cancel = true;
            }

        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        #endregion
        private Form activeForm = null;
        private void openFormChill(Form chill)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = chill;
            chill.TopLevel = false;
            chill.FormBorderStyle = FormBorderStyle.None;
            chill.Dock = DockStyle.Fill;
            panelChillForm.Controls.Add(chill);
            panelChillForm.Tag = chill;
            chill.BringToFront();
            chill.Show();
        }
        private void frmMainEdit_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            string s = "Xin Chào: ";
            lbl_tendangnhap.Text = s + TenNhanVien;
        }
    }
}

