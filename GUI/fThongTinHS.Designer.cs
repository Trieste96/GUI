namespace GUI
{
    partial class fThongTinHS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoTenHS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tableSV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMSHS = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.epHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSoDT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableSV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTenHS
            // 
            this.lblHoTenHS.AutoSize = true;
            this.lblHoTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenHS.Location = new System.Drawing.Point(49, 64);
            this.lblHoTenHS.Name = "lblHoTenHS";
            this.lblHoTenHS.Size = new System.Drawing.Size(61, 20);
            this.lblHoTenHS.TabIndex = 0;
            this.lblHoTenHS.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(152, 169);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(824, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(152, 64);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(274, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(152, 99);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(274, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(152, 134);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(274, 20);
            this.txtSoDT.TabIndex = 3;
            this.txtSoDT.Leave += new System.EventHandler(this.txtSoDT_Leave);
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbLop.Location = new System.Drawing.Point(874, 46);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(148, 21);
            this.cbLop.TabIndex = 5;
            this.cbLop.SelectionChangeCommitted += new System.EventHandler(this.cbLop_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÔNG TIN HỌC SINH";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSV.Location = new System.Drawing.Point(11, 254);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(138, 41);
            this.btnThemSV.TabIndex = 6;
            this.btnThemSV.Text = "Thêm HS";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(318, 254);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá HS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(162, 254);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 41);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa HS";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tableSV
            // 
            this.tableSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tableSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSV.Location = new System.Drawing.Point(515, 73);
            this.tableSV.Name = "tableSV";
            this.tableSV.ReadOnly = true;
            this.tableSV.Size = new System.Drawing.Size(545, 223);
            this.tableSV.TabIndex = 13;
            this.tableSV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableSV_CellMouseClick);
            this.tableSV.Leave += new System.EventHandler(this.tableSV_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMSHS);
            this.panel1.Controls.Add(this.lblMSSV);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThemSV);
            this.panel1.Controls.Add(this.txtSoDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHoTenHS);
            this.panel1.Location = new System.Drawing.Point(2, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 310);
            this.panel1.TabIndex = 14;
            // 
            // txtMSHS
            // 
            this.txtMSHS.Location = new System.Drawing.Point(152, 35);
            this.txtMSHS.Name = "txtMSHS";
            this.txtMSHS.ReadOnly = true;
            this.txtMSHS.Size = new System.Drawing.Size(274, 20);
            this.txtMSHS.TabIndex = 14;
            this.txtMSHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(49, 35);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(83, 20);
            this.lblMSSV.TabIndex = 13;
            this.lblMSSV.Text = "Mã số HS:";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(706, 302);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(172, 32);
            this.btnTaiLai.TabIndex = 15;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // epHoTen
            // 
            this.epHoTen.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.epHoTen.ContainerControl = this;
            // 
            // epSoDT
            // 
            this.epSoDT.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.epSoDT.ContainerControl = this;
            // 
            // fThongTinHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 429);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label5);
            this.Name = "fThongTinHS";
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.fThongTinHS_Load);
            this.Click += new System.EventHandler(this.fThongTinHS_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tableSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTenHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView tableSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.TextBox txtMSHS;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.ErrorProvider epHoTen;
        private System.Windows.Forms.ErrorProvider epSoDT;
    }
}

