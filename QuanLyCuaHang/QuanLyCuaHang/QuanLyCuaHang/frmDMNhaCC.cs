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
    public partial class frmDMNhaCC : Form
    {
        DataTable tblNCC; // lưu dữ liệu vào bảng nhân viên
        public frmDMNhaCC()
        {
            InitializeComponent();
        }

        private void frmDMNhaCC_Load(object sender, EventArgs e)
        {
            loaddataGridView();
            txtMancc.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void loaddataGridView()
        {
            string sql;
            sql = "select Manc,Tennc,Diachi,DienThoai from tblNhaCungcap";
            tblNCC = Functions.GetDataTable(sql); //lấy dữ liệu
            dgv_NCC.DataSource = tblNCC;
            dgv_NCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgv_NCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgv_NCC.Columns[2].HeaderText = "Địa chỉ";
            dgv_NCC.Columns[3].HeaderText = "Điện thoại";
            dgv_NCC.Columns[0].Width = 100;
            dgv_NCC.Columns[1].Width = 150;
            dgv_NCC.Columns[2].Width = 100;
            dgv_NCC.Columns[3].Width = 150;
            dgv_NCC.AllowUserToAddRows = false; // ngăn chặn người dùng thêm dòng mới
            dgv_NCC.EditMode = DataGridViewEditMode.EditProgrammatically; // chỉ thay đổi, không được thêm mới vào

        }

        private void dgv_NCC_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            Reset();
            txtMancc.Enabled = true;
            txtMancc.Focus();
        }
        private void Reset()
        {
            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtDiachi.Text = "";
            maskedDienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMancc.Focus();
                return;
            }
            if (txtMancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenncc.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (maskedDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedDienthoai.Focus();
                return;
            }
            sql = "select Manc from tblNhaCungcap where Manc = N'" + txtMancc.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMancc.Focus();
                txtMancc.Text = "";
                return;
            }
            // thêm các trường vào bảng
            sql = "insert into tblNhaCungcap(Manc,Tennc, Diachi,Dienthoai) VALUES (N'" + txtMancc.Text.Trim() + "',N'" + txtTenncc.Text.Trim() +"',N'" + txtDiachi.Text.Trim() + "','" + maskedDienthoai.Text + "')";
            Functions.RunSQL(sql);
            loaddataGridView();
            Reset();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMancc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql, gt;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMancc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenncc.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (maskedDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedDienthoai.Focus();
                return;
            }

            // cập nhật lại record
            sql = "update tblNhaCungcap set  Tennc=N'" + txtTenncc.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtDiachi.Text.Trim().ToString() +
                    "',Dienthoai='" + maskedDienthoai.Text.ToString() +
                    "' where Manc=N'" + txtMancc.Text + "'";
            Functions.RunSQL(sql);
            loaddataGridView();
            Reset();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhaCungcap WHERE Manc=N'" + txtMancc.Text + "'";
                Functions.RunSQL(sql);
                loaddataGridView();
                Reset();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Reset();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMancc.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtMancc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dgv_NCC_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMancc.Focus();
                return;
            }
            if (tblNCC.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMancc.Text = dgv_NCC.CurrentRow.Cells["Manc"].Value.ToString();
            txtTenncc.Text = dgv_NCC.CurrentRow.Cells["Tennc"].Value.ToString();
            txtDiachi.Text = dgv_NCC.CurrentRow.Cells["Diachi"].Value.ToString();
            maskedDienthoai.Text = dgv_NCC.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
    }
}
