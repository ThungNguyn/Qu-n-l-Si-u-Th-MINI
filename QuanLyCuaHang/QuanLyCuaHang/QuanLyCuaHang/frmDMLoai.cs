using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHang.Class;
using System.Data.SqlClient;

namespace QuanLyCuaHang
{
    public partial class frmDMLoai : Form
    {
        DataTable tblL;

        public frmDMLoai()
        {
            InitializeComponent();

        }

        private void frmDMChatLieu_Load(object sender, EventArgs e)
        {
            txtMaloai.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();


        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblLoaiSanPham";
            tblL = Functions.GetDataTable(sql); //Đọc dữ liệu từ bảng
            dgv_Loaisp.DataSource = tblL; //Nguồn dữ liệu            
            dgv_Loaisp.Columns[0].HeaderText = "Mã loại";
            dgv_Loaisp.Columns[1].HeaderText = "Tên loại";
            dgv_Loaisp.Columns[0].Width = 100;
            dgv_Loaisp.Columns[1].Width = 300;
            dgv_Loaisp.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_Loaisp.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
            Reset();// xóa các textbox
            txtMaloai.Enabled = true; // cho nhập mới
            txtMaloai.Focus();

        }
        public void Reset()
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; // chuỗi thực thi kết nối

            if (txtMaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vào mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloai.Focus();
                return;
            }
            if (txtTenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập vào tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenloai.Focus();
                return;
            }
            sql = "select MaLoai from tblLoaiSanPham where MaLoai ='" + txtMaloai.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã loại này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloai.Focus();
                return;
            }

            sql = "insert into tblLoaiSanPham values('" + txtMaloai.Text + "',N'" + txtTenloai.Text + "')";
            Functions.RunSQL(sql);// thực hiện câu lệnh sql
            LoadDataGridView();// cập nhật lại
            Reset(); // xóa các textbox
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaloai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql; //Lưu câu lệnh sql
            if (tblL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenloai.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update tblLoaiSanPham set TenLoai =N'" +
                txtTenloai.Text.ToString() +
                "' where MaLoai = '" + txtMaloai.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            Reset();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete tblLoaiSanPham where MaLoai = N'" + txtMaloai.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                Reset();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Reset();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaloai.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaloai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dgv_Loaisp_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloai.Focus();
                return;
            }
            if (tblL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaloai.Text = dgv_Loaisp.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTenloai.Text = dgv_Loaisp.CurrentRow.Cells["TenLoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
    }
}
