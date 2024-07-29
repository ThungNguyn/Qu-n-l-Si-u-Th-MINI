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
    public partial class frmDMKhachHang : Form
    {
        DataTable tbl_Kh;
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            txt_makhach.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "select * from tblKhach";
            tbl_Kh = Functions.GetDataTable(sql); //Lấy dữ liệu từ bảng
            dgv_khachhang.DataSource = tbl_Kh; //Hiển thị vào dataGridView
            dgv_khachhang.Columns[0].HeaderText = "Mã khách";
            dgv_khachhang.Columns[1].HeaderText = "Tên khách";
            dgv_khachhang.Columns[2].HeaderText = "Địa chỉ";
            dgv_khachhang.Columns[3].HeaderText = "Điện thoại";
            dgv_khachhang.Columns[4].HeaderText = "Điểm";
            dgv_khachhang.Columns[0].Width = 100;
            dgv_khachhang.Columns[1].Width = 150;
            dgv_khachhang.Columns[2].Width = 150;
            dgv_khachhang.Columns[3].Width = 150;
            dgv_khachhang.Columns[4].Width = 150;
            dgv_khachhang.AllowUserToAddRows = false; // khong cho nguoi dung chi them vao
            dgv_khachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_khachhang_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhach.Focus();
                return;
            }
            if (tbl_Kh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int i;
            i = dgv_khachhang.CurrentRow.Index;
            txt_makhach.Text = dgv_khachhang.Rows[i].Cells[0].Value.ToString();
            txt_tenkhach.Text = dgv_khachhang.Rows[i].Cells[1].Value.ToString();
            txt_diachi.Text = dgv_khachhang.Rows[i].Cells[2].Value.ToString();
            mask_dienthoai.Text = dgv_khachhang.Rows[i].Cells[3].Value.ToString();
            numericUpDown1.Text = dgv_khachhang.Rows[i].Cells[4].Value.ToString();

            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            Reset();
            txt_makhach.Enabled = true;
            txt_makhach.Focus();
        }

        private void Reset()
        {
            txt_makhach.Text = "";
            txt_tenkhach.Text = "";
            txt_diachi.Text = "";
            mask_dienthoai.Text = "";
            numericUpDown1.Value= 0;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_makhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhach.Focus();
                return;
            }
            if (txt_tenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkhach.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            if (mask_dienthoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mask_dienthoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "select MaKhach from tblKhach where MaKhach=N'" + txt_makhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makhach.Focus();
                return;
            }
            //Chèn thêm
            sql = "insert into tblKhach values (N'" + txt_makhach.Text.Trim() +
                "',N'" + txt_tenkhach.Text.Trim() + "',N'" + txt_diachi.Text.Trim() + "','" + mask_dienthoai.Text + "','"+numericUpDown1.Value.ToString()+"')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            Reset();

            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_makhach.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_Kh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makhach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkhach.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            if (mask_dienthoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mask_dienthoai.Focus();
                return;
            }
            sql = "update tblKhach set TenKhach=N'" + txt_tenkhach.Text.Trim().ToString() + "',DiaChi=N'" +
                txt_diachi.Text.Trim().ToString() + "',DienThoai='" + mask_dienthoai.Text.ToString() +
                "',diem='"+numericUpDown1.Value.ToString()+"' where MaKhach=N'" + txt_makhach.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            Reset();
            btn_boqua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_Kh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_makhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhach WHERE MaKhach=N'" + txt_makhach.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
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
            txt_makhach.Enabled = false;
        }

        private void txt_makhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
