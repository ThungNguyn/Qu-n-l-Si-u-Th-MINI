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
    public partial class frmDMHangHoa : Form
    {
        DataTable tbl_hh;
        public frmDMHangHoa()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDMHangHoa_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblLoaiSanPham";
            txt_mahang.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            LoadDataGridView();
            Functions.fillCombo(sql, cbo_maloai, "maloai", "tenloai");
            cbo_maloai.SelectedIndex = -1;
            string sql1 = "select * from tblnhacungcap";
            Functions.fillCombo(sql1, cbo_mancc, "manc", "tennc");
            cbo_maloai.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txt_mahang.Text = "";
            txt_tenhang.Text = "";
            cbo_maloai.Text = "";
            txt_soluong.Text = "0";
            txt_dongianhap.Text = "0";
            txt_dongiaban.Text = "0";
            txt_soluong.Enabled = true;
            txt_dongianhap.Enabled = false;
            txt_dongiaban.Enabled = false;
            txt_ghichu.Text = "";
            cbo_mancc.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tblHang";
            tbl_hh = Functions.GetDataTable(sql);
            dgv_hanghoa.DataSource = tbl_hh;
            dgv_hanghoa.Columns[0].HeaderText = "Mã hàng";
            dgv_hanghoa.Columns[1].HeaderText = "Tên hàng";
            dgv_hanghoa.Columns[2].HeaderText = "Mã nhà cung cấp";
            dgv_hanghoa.Columns[3].HeaderText = "Số lượng";
            dgv_hanghoa.Columns[4].HeaderText = "Đơn giá nhập";
            dgv_hanghoa.Columns[5].HeaderText = "Đơn giá bán";
            dgv_hanghoa.Columns[6].HeaderText = "Ghi chú";
            dgv_hanghoa.Columns[7].HeaderText = "Mã loại";

            dgv_hanghoa.Columns[0].Width = 80;
            dgv_hanghoa.Columns[1].Width = 140;
            dgv_hanghoa.Columns[2].Width = 140;
            dgv_hanghoa.Columns[3].Width = 80;
            dgv_hanghoa.Columns[4].Width = 80;
            dgv_hanghoa.Columns[5].Width = 100;
            dgv_hanghoa.Columns[6].Width = 100;
            dgv_hanghoa.Columns[7].Width = 300;
            
            dgv_hanghoa.AllowUserToAddRows = false;
            dgv_hanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_hanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLoai ;
            string sql;
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            if (tbl_hh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_mahang.Text = dgv_hanghoa.CurrentRow.Cells["MaHang"].Value.ToString();
            txt_tenhang.Text = dgv_hanghoa.CurrentRow.Cells["TenHang"].Value.ToString();

            string mancc;
            mancc = dgv_hanghoa.CurrentRow.Cells["manc"].Value.ToString();
            sql = "SELECT tennc FROM tblnhacungcap WHERE Manc=N'" + mancc + "'";
            cbo_mancc.Text = Functions.GetFieldValues(sql);

            txt_soluong.Text = dgv_hanghoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_dongianhap.Text = dgv_hanghoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txt_dongiaban.Text = dgv_hanghoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            sql = "SELECT Ghichu FROM tblHang WHERE MaHang = N'" + txt_mahang.Text + "'";
            txt_ghichu.Text = Functions.GetFieldValues(sql);

            MaLoai= dgv_hanghoa.CurrentRow.Cells["MaLoai"].Value.ToString();
            sql = "SELECT TenLoai FROM tblloaisanpham WHERE MaLoai=N'" + MaLoai + "'";
            cbo_maloai.Text = Functions.GetFieldValues(sql);

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
            ResetValues();
            txt_mahang.Enabled = true;
            txt_mahang.Focus();
            txt_soluong.Enabled = true;
            txt_dongianhap.Enabled = true;
            txt_dongiaban.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_mahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            if (txt_tenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenhang.Focus();
                return;
            }
            if (cbo_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_maloai.Focus();
                return;
            }

            sql = "SELECT MaHang FROM tblHang WHERE MaHang=N'" + txt_mahang.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            sql = "INSERT INTO tblHang(MaHang,TenHang,Manc,SoLuong,DonGiaNhap, DonGiaBan,Ghichu,maloai) VALUES(N'"
                + txt_mahang.Text.Trim() + "',N'" + txt_tenhang.Text.Trim() +
                "',N'" + cbo_mancc.SelectedValue.ToString() +
                "'," + txt_soluong.Text.Trim() + "," + txt_dongianhap.Text +
                "," + txt_dongiaban.Text + ",N'" + txt_ghichu.Text.Trim() + "','"+cbo_maloai.SelectedValue.ToString()+"')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_hh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE MaHang=N'" + txt_mahang.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_hh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            if (txt_tenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenhang.Focus();
                return;
            }
            if (cbo_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_maloai.Focus();
                return;
            }

            sql = "UPDATE tblHang SET TenHang=N'" + txt_tenhang.Text.Trim().ToString() +
                "',Manc=N'" + cbo_mancc.SelectedValue.ToString() +
                "',SoLuong='"+ txt_soluong.Text + 
                "',Dongianhap ='"+txt_dongianhap.Text+
                "',Dongiaban ='"+txt_dongiaban.Text+
                "',Ghichu=N'" + txt_ghichu.Text +
                "',maloai='"+cbo_maloai.SelectedValue.ToString()+"' WHERE MaHang=N'" + txt_mahang.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btn_boqua.Enabled = false;
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_mahang.Text == "") && (txt_tenhang.Text == "") && (cbo_maloai.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblHang WHERE 1=1";
            if (txt_mahang.Text != "")
                sql += " AND MaHang LIKE N'%" + txt_mahang.Text + "%'";
            if (txt_tenhang.Text != "")
                sql += " AND TenHang LIKE N'%" + txt_tenhang.Text + "%'";
            if (cbo_maloai.Text != "")
                sql += " AND Maloai LIKE N'%" + cbo_maloai.SelectedValue + "%'";
            tbl_hh = Functions.GetDataTable(sql);
            if (tbl_hh.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tbl_hh.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_hanghoa.DataSource = tbl_hh;
            ResetValues();
        }

        private void btn_hienthids_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHang,TenHang,Manc,SoLuong,DonGiaNhap,DonGiaBan,Ghichu, maloai FROM tblHang";
            tbl_hh = Functions.GetDataTable(sql);
            dgv_hanghoa.DataSource = tbl_hh;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
