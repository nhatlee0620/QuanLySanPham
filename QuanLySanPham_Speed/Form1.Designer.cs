namespace QuanLySanPham_Speed
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTSP = new System.Windows.Forms.TextBox();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToTal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnGioHangMoi = new System.Windows.Forms.Button();
            this.btnThemVaoGioHang = new System.Windows.Forms.Button();
            this.txtSoLuongLay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToTal2 = new System.Windows.Forms.TextBox();
            this.dtgGioHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGioHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.AllowUserToAddRows = false;
            this.dtgSanPham.AllowUserToDeleteRows = false;
            this.dtgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanPham.Location = new System.Drawing.Point(24, 86);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.ReadOnly = true;
            this.dtgSanPham.RowHeadersWidth = 51;
            this.dtgSanPham.RowTemplate.Height = 24;
            this.dtgSanPham.Size = new System.Drawing.Size(1008, 420);
            this.dtgSanPham.TabIndex = 0;
            this.dtgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanPham_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1187, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(1171, 271);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(242, 22);
            this.txtViTri.TabIndex = 30;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(1171, 233);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(242, 22);
            this.txtSL.TabIndex = 28;
            // 
            // txtTSP
            // 
            this.txtTSP.Location = new System.Drawing.Point(1171, 195);
            this.txtTSP.Name = "txtTSP";
            this.txtTSP.Size = new System.Drawing.Size(242, 22);
            this.txtTSP.TabIndex = 26;
            // 
            // txtMSP
            // 
            this.txtMSP.Location = new System.Drawing.Point(1171, 157);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(242, 22);
            this.txtMSP.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1057, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Vị Trí:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1057, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1057, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1057, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // txtToTal
            // 
            this.txtToTal.Location = new System.Drawing.Point(1267, 119);
            this.txtToTal.Name = "txtToTal";
            this.txtToTal.ReadOnly = true;
            this.txtToTal.Size = new System.Drawing.Size(146, 22);
            this.txtToTal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1057, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tổng số mặt hàng trong kho:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1057, 425);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(358, 36);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1057, 382);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(358, 36);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1057, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(358, 36);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm sản phẩm mới vào kho";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(1057, 468);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(358, 36);
            this.btnXoa1.TabIndex = 35;
            this.btnXoa1.Text = "Xóa 1 sản phẩm khỏi kho";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnGioHangMoi
            // 
            this.btnGioHangMoi.Location = new System.Drawing.Point(1057, 675);
            this.btnGioHangMoi.Name = "btnGioHangMoi";
            this.btnGioHangMoi.Size = new System.Drawing.Size(358, 40);
            this.btnGioHangMoi.TabIndex = 41;
            this.btnGioHangMoi.Text = "Tạo giỏ hàng mới";
            this.btnGioHangMoi.UseVisualStyleBackColor = true;
            this.btnGioHangMoi.Click += new System.EventHandler(this.btnGioHangMoi_Click);
            // 
            // btnThemVaoGioHang
            // 
            this.btnThemVaoGioHang.Location = new System.Drawing.Point(1057, 629);
            this.btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            this.btnThemVaoGioHang.Size = new System.Drawing.Size(358, 40);
            this.btnThemVaoGioHang.TabIndex = 40;
            this.btnThemVaoGioHang.Text = "Thêm vào giỏ hàng";
            this.btnThemVaoGioHang.UseVisualStyleBackColor = true;
            this.btnThemVaoGioHang.Click += new System.EventHandler(this.btnThemVaoGioHang_Click);
            // 
            // txtSoLuongLay
            // 
            this.txtSoLuongLay.Location = new System.Drawing.Point(1057, 598);
            this.txtSoLuongLay.Name = "txtSoLuongLay";
            this.txtSoLuongLay.Size = new System.Drawing.Size(356, 22);
            this.txtSoLuongLay.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1057, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Số lượng hàng muốn lấy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1057, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tổng số mặt hàng trong giỏ:";
            // 
            // txtToTal2
            // 
            this.txtToTal2.Location = new System.Drawing.Point(1251, 539);
            this.txtToTal2.Name = "txtToTal2";
            this.txtToTal2.ReadOnly = true;
            this.txtToTal2.Size = new System.Drawing.Size(162, 22);
            this.txtToTal2.TabIndex = 36;
            // 
            // dtgGioHang
            // 
            this.dtgGioHang.AllowUserToAddRows = false;
            this.dtgGioHang.AllowUserToDeleteRows = false;
            this.dtgGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGioHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGioHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGioHang.Location = new System.Drawing.Point(24, 541);
            this.dtgGioHang.Name = "dtgGioHang";
            this.dtgGioHang.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGioHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgGioHang.RowHeadersWidth = 51;
            this.dtgGioHang.RowTemplate.Height = 24;
            this.dtgGioHang.Size = new System.Drawing.Size(1008, 224);
            this.dtgGioHang.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1057, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tìm kiếm theo tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1057, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1171, 302);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(242, 22);
            this.txtStatus.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "KHO HÀNG:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "GIỎ HÀNG:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(1057, 721);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(358, 40);
            this.btnExportExcel.TabIndex = 47;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 51);
            this.panel1.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1450, 51);
            this.label12.TabIndex = 0;
            this.label12.Text = "QUẢN LÝ KHO HÀNG";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 806);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgGioHang);
            this.Controls.Add(this.btnGioHangMoi);
            this.Controls.Add(this.btnThemVaoGioHang);
            this.Controls.Add(this.txtSoLuongLay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtToTal2);
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTSP);
            this.Controls.Add(this.txtMSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToTal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHO HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGioHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSanPham;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTSP;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToTal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnGioHangMoi;
        private System.Windows.Forms.Button btnThemVaoGioHang;
        private System.Windows.Forms.TextBox txtSoLuongLay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtToTal2;
        private System.Windows.Forms.DataGridView dtgGioHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}

