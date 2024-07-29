using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHang.Class;
namespace QuanLyCuaHang
{
    public partial class frmDMNhanVien : Form
    {
        DataTable tblNV; // lưu dữ liệu vào bảng nhân viên
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            loadDataGridview();
            txt_manhanvien.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            cbo_quyen.SelectedIndex = -1;
            string[] lst = new string[] { "admin", "user" };
            cbo_quyen.Items.Clear();  
            cbo_quyen.Items.AddRange(lst);  

        }
      


        private void loadDataGridview()
        {

            string sql;
            sql = "select MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,TenDangNhap,Quyen,MatKhau from tblNhanVien";
            tblNV = Functions.GetDataTable(sql); //lấy dữ liệu
           dgv_NhanVien.DataSource = tblNV;
           dgv_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
           dgv_NhanVien.Columns[1].HeaderText = "Tên nhân viên";
           dgv_NhanVien.Columns[2].HeaderText = "Giới tính";
           dgv_NhanVien.Columns[3].HeaderText = "Địa chỉ";
           dgv_NhanVien.Columns[4].HeaderText = "Điện thoại";
           //dgv_NhanVien.Columns[5].HeaderText = "Ngày sinh";
           dgv_NhanVien.Columns[5].HeaderText = "Tên đăng nhập";
           dgv_NhanVien.Columns[6].HeaderText = "Quyền";
           dgv_NhanVien.Columns[7].HeaderText = "Mật khẩu";
           dgv_NhanVien.Columns[0].Width = 100;
           dgv_NhanVien.Columns[1].Width = 150;
           dgv_NhanVien.Columns[2].Width = 100;
           dgv_NhanVien.Columns[3].Width = 150;
           dgv_NhanVien.Columns[4].Width = 100;
           dgv_NhanVien.Columns[5].Width = 100;
           dgv_NhanVien.Columns[6].Width = 100;
           dgv_NhanVien.Columns[7].Width = 100;
           //dgv_NhanVien.Columns[8].Width = 100;
           
           dgv_NhanVien.AllowUserToAddRows = false; // ngăn chặn người dùng thêm dòng mới
           dgv_NhanVien.EditMode = DataGridViewEditMode.EditProgrammatically; // chỉ thay đổi, không được thêm mới vào
        }

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int i;
            i = dgv_NhanVien.CurrentRow.Index;
            txt_manhanvien.Text = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
            txt_tennhanvien.Text = dgv_NhanVien.Rows[i].Cells[1].Value.ToString();
            if (dgv_NhanVien.Rows[i].Cells[2].Value.ToString() == "Nam") chk_gioitinh.Checked = true;
            else chk_gioitinh.Checked = false;
            txt_diachi.Text = dgv_NhanVien.Rows[i].Cells[3].Value.ToString();
            mask_dienthoai.Text = dgv_NhanVien.Rows[i].Cells[4].Value.ToString();
            //dtp_ngaysinh.Text = dgv_NhanVien.Rows[i].Cells[5].Value.ToString();
            txt_tendangnhap.Text= dgv_NhanVien.Rows[i].Cells[6].Value.ToString();
            cbo_quyen.Text= dgv_NhanVien.Rows[i].Cells[6].Value.ToString();
            txt_matkhau.Text= dgv_NhanVien.Rows[i].Cells[7].Value.ToString();
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_dong.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            Reset();
            txt_manhanvien.Enabled = true;
            txt_manhanvien.Focus();
        }

        private void Reset()
        {
            txt_manhanvien.Text = "";
            txt_tennhanvien.Text = "";
            chk_gioitinh.Checked = false;
            txt_diachi.Text = "";
            //dtp_ngaysinh.Text = "";
            mask_dienthoai.Text = "";
            txt_tendangnhap.Text = "";
            cbo_quyen.Text="";
            txt_matkhau.Text = "";

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txt_manhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manhanvien.Focus();
                return;
            }
            if (txt_tennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennhanvien.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (mask_dienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mask_dienthoai.Focus();
                return;
            }
           
            if (chk_gioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "select MaNhanVien from tblNhanVien where MaNhanVien=N'" + txt_manhanvien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manhanvien.Focus();
                txt_manhanvien.Text = "";
                return;
            }
            // thêm các trường vào bảng
            sql = "insert into tblNhanVien(MaNhanVien,TenNhanVien,GioiTinh, DiaChi,DienThoai,TenDangNhap,Quyen,MatKhau) VALUES (N'" + txt_manhanvien.Text.Trim() + "',N'" + txt_tennhanvien.Text.Trim() + "',N'" + gt + "',N'" + txt_diachi.Text.Trim() + "','" + mask_dienthoai.Text + "','"+txt_tendangnhap.Text+"','"+cbo_quyen.SelectedItem.ToString()+"','"+txt_matkhau.Text+"')";
            Functions.RunSQL(sql);
            loadDataGridview();
            Reset();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_manhanvien.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennhanvien.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (mask_dienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mask_dienthoai.Focus();
                return;
            }
           
            if (chk_gioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            // cập nhật lại record
            sql = "update tblNhanVien set  TenNhanVien=N'" + txt_tennhanvien.Text.Trim().ToString() +
                    "',DiaChi=N'" + txt_diachi.Text.Trim().ToString() +
                    "',DienThoai='" +mask_dienthoai.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',TenDangNhap='"+txt_tendangnhap.Text+
                    "',Quyen='"+cbo_quyen.SelectedItem.ToString()+
                    "',MatKhau='"+txt_matkhau.Text+
                    "' where MaNhanVien=N'" + txt_manhanvien.Text + "'";
            Functions.RunSQL(sql);
            loadDataGridview();
            Reset();
            btn_boqua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_manhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE MaNhanVien=N'" + txt_manhanvien.Text + "'";
                Functions.RunSQL(sql);
               loadDataGridview();
                Reset();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            Reset();
            btn_boqua.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            txt_manhanvien.Enabled = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_manhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

    }
}
