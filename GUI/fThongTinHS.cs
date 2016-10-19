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
using System.Text.RegularExpressions;
using BUS;
using DTO;

namespace GUI
{
    public partial class fThongTinHS : Form
    {
        LopHocBUS bus;
        public fThongTinHS()
        {
            InitializeComponent();
            bus = new LopHocBUS();
        }
       
        private void btnThemHS_Click(object sender, EventArgs e)
        {
            if (!(bus.validateName(txtHoTen.Text) && bus.validatePhoneNumber(txtSoDT.Text)))
            {
                MessageBox.Show("Xin hãy điền lại thông tin hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn thêm thông tin sinh viên này?","Xác nhận",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
                {
                    SinhVienDTO sv = new SinhVienDTO(0, txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                                                        Convert.ToInt32(cbLop.SelectedValue.ToString()));
                    bus.themSV(sv);
                    btnTaiLai_Click(new Object(), new EventArgs());
                }

            }
            
        }

        private void fThongTinHS_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = bus.load_tenLop();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối được!");
                return;
            }
            cbLop.DataSource = dt;
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            btnTaiLai_Click(new Object(), new EventArgs());

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("DSLop");
            try
            {
                dt = bus.loadDSHS();
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối thất bại!");
                return;
            }
            tableSV.DataSource = dt;
            tableSV.Columns[0].HeaderText = "Mã SV";
            tableSV.Columns[1].HeaderText = "Họ tên";
            tableSV.Columns[2].HeaderText = "Địa chỉ";
            tableSV.Columns[3].HeaderText = "Số điện thoại";
            tableSV.Columns[4].HeaderText = "Ngày sinh";
            tableSV.Columns[5].HeaderText = "Lớp";
            for (int i = 0; i < tableSV.ColumnCount; i++)
                tableSV.AutoResizeColumn(i);
            tableSV.ReadOnly = true;
        }

        private void tableSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Dòng hiện tại: " + tableSV.CurrentRow.Index);
            txtMSSV.Text    = tableSV.CurrentRow.Cells[0].FormattedValue.ToString();
            txtHoTen.Text   = tableSV.CurrentRow.Cells[1].FormattedValue.ToString();
            txtDiaChi.Text  = tableSV.CurrentRow.Cells[2].FormattedValue.ToString();
            txtSoDT.Text    = tableSV.CurrentRow.Cells[3].FormattedValue.ToString();
            cbLop.Text      = tableSV.CurrentRow.Cells[5].FormattedValue.ToString();
            try
            {
                dtpNgaySinh.Value = DateTime.ParseExact(tableSV.CurrentRow.Cells[4].FormattedValue.ToString(), "dd/MM/yyyy", 
                    System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            }
            catch (FormatException)
            {

                dtpNgaySinh.Value = DateTime.Today;
            }
            btnSua.Enabled = true;
        }

        private void tableSV_Leave(object sender, EventArgs e)
        {
            //txtMSSV.Clear();
            //txtHoTen.Clear();
            //txtDiaChi.Clear();
            //txtSoDT.Clear();
            //cbLop.SelectedIndex = 0;
            //dtpNgaySinh.Value = DateTime.Today;

        }

        private void fThongTinHS_Click(object sender, EventArgs e)
        {
            tableSV_Leave(new Object(), new EventArgs());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ( !(bus.validateName(txtHoTen.Text) && bus.validatePhoneNumber(txtSoDT.Text)) )
            {
                MessageBox.Show("Xin hãy điền lại thông tin hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(String.Format("Bạn có chắc chắn làm mình muốn sửa đổi thông tin của SV mã {0}?", txtMSSV.Text), "Xác nhận",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && txtMSSV.Text.Equals("") == false)
                {
                    SinhVienDTO sv = new SinhVienDTO(Convert.ToInt32(txtMSSV.Text), txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                            Convert.ToInt32(cbLop.SelectedValue.ToString()));
                    bus.suaSV(sv);
                    btnTaiLai_Click(new Object(), new EventArgs());
                }
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(String.Format("Bạn có chắc chắn muốn xoá SV mã {0} ra khỏi danh sách?", txtMSSV.Text), "Xác nhận", 
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && txtMSSV.Text.Equals("") == false)
            {
                SinhVienDTO sv = new SinhVienDTO(Convert.ToInt32(txtMSSV.Text), null, null, null, null, 0);
                LopHocBUS bus = new LopHocBUS();
                bus.xoaSV(sv);

                txtMSSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtSoDT.Clear();
                cbLop.SelectedIndex = 0;
                dtpNgaySinh.Value = DateTime.Today;
                btnTaiLai_Click(new Object(), new EventArgs());
            }
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (bus.validateName(txtHoTen.Text) == false)
            {
                epHoTen.SetError(txtHoTen, "Họ tên không hợp lệ");
            }
            else
                epHoTen.Clear();
        }

        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if (bus.validatePhoneNumber(txtSoDT.Text) == false)
            {
                epSoDT.SetError(txtSoDT, "Số điện thoại không hợp lệ (Số điện thoại hợp lệ gồm 8-15 ký tự số)!");
            }
            else
                epSoDT.Clear();
        }
    }
}
