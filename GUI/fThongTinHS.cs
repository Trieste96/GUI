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
        private LopHocBUS lop_hoc_bus;
        private HocSinhBUS hs_bus;
        public fThongTinHS()
        {
            InitializeComponent();
            lop_hoc_bus = new LopHocBUS();
            hs_bus = new HocSinhBUS();
        }
       
        private void btnThemHS_Click(object sender, EventArgs e)
        {
            if (!(hs_bus.validateName(txtHoTen.Text) && hs_bus.validatePhoneNumber(txtSoDT.Text)))
            {
                MessageBox.Show("Xin hãy điền lại thông tin hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn thêm thông tin học sinh này?","Xác nhận",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
                {
                    HocSinhDTO hs = new HocSinhDTO(0, txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                                                        Convert.ToInt32(cbLop.SelectedValue.ToString()));
                    hs_bus.themHS(hs);
                    btnTaiLai_Click(new Object(), new EventArgs());
                }

            }
            
        }

        private void fThongTinHS_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = lop_hoc_bus.load_tenLop();
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối không thành công!");
                Application.Exit();
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
                dt = lop_hoc_bus.loadDSHStheoLop(cbLop.SelectedValue);
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối thất bại!");
                return;
            }
            tableSV.DataSource = dt;
            tableSV.Columns[0].HeaderText = "Mã số HS";
            tableSV.Columns[1].HeaderText = "Họ tên";
            tableSV.Columns[2].HeaderText = "Địa chỉ";
            tableSV.Columns[3].HeaderText = "Số điện thoại";
            tableSV.Columns[4].HeaderText = "Ngày sinh";
            tableSV.Columns[5].HeaderText = "Lớp";

            tableSV.AutoResizeColumn(0);
            tableSV.AutoResizeColumn(3);
            tableSV.AutoResizeColumn(4);
            tableSV.AutoResizeColumn(5);
            tableSV.ReadOnly = true;
        }

        private void tableSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Dòng hiện tại: " + tableSV.CurrentRow.Index);
            txtMSHS.Text    = tableSV.CurrentRow.Cells[0].FormattedValue.ToString();
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
            if ( !(hs_bus.validateName(txtHoTen.Text) && hs_bus.validatePhoneNumber(txtSoDT.Text)) )
            {
                MessageBox.Show("Xin hãy điền lại thông tin hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(String.Format("Bạn có muốn sửa đổi thông tin của hoc sinh mã {0}?", txtMSHS.Text), "Xác nhận",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes && txtMSHS.Text.Equals("") == false)
                {
                    HocSinhDTO hs = new HocSinhDTO(Convert.ToInt32(txtMSHS.Text), txtHoTen.Text, txtDiaChi.Text, txtSoDT.Text, dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                            Convert.ToInt32(cbLop.SelectedValue.ToString()));
                    hs_bus.suaHS(hs);
                    btnTaiLai_Click(new Object(), new EventArgs());
                }
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(String.Format("Bạn có chắc chắn muốn xoá SV mã {0} ra khỏi danh sách?", txtMSHS.Text), "Xác nhận", 
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && txtMSHS.Text.Equals("") == false)
            {
                HocSinhDTO hs = new HocSinhDTO(Convert.ToInt32(txtMSHS.Text), null, null, null, null, 0);
                hs_bus.xoaHS(hs);

                txtMSHS.Clear();
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
            if (hs_bus.validateName(txtHoTen.Text) == false)
            {
                epHoTen.SetError(txtHoTen, "Họ tên không hợp lệ");
            }
            else
                epHoTen.Clear();
        }

        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if (hs_bus.validatePhoneNumber(txtSoDT.Text) == false)
            {
                epSoDT.SetError(txtSoDT, "Số điện thoại không hợp lệ (Số điện thoại hợp lệ gồm 8-15 ký tự số).");
            }
            else
                epSoDT.Clear();
        }

        private void cbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnTaiLai_Click(new object(), new EventArgs());
            txtMSHS.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            
        }
    }
}
