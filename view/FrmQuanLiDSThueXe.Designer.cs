namespace DoAnDBMS.view
{
    partial class FrmQuanLiDSThueXe
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
            this.lbl_CMND = new System.Windows.Forms.Label();
            this.lbl_LoaiXe = new System.Windows.Forms.Label();
            this.lbl_BienSo = new System.Windows.Forms.Label();
            this.lbl_Anh = new System.Windows.Forms.Label();
            this.lbl_NgayHopDong = new System.Windows.Forms.Label();
            this.lbl_TriGiaHD = new System.Windows.Forms.Label();
            this.lbl_NgayGiaoXe = new System.Windows.Forms.Label();
            this.lbl_NgayHetHanThue = new System.Windows.Forms.Label();
            this.txb_CMND = new System.Windows.Forms.TextBox();
            this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.txb_BienSo = new System.Windows.Forms.TextBox();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            this.dtp_NgayHopDong = new System.Windows.Forms.DateTimePicker();
            this.txb_TriGiaHD = new System.Windows.Forms.TextBox();
            this.dtp_NgayGiaoXe = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayHetHanThue = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.txb_HieuXe = new System.Windows.Forms.TextBox();
            this.lbl_HieuXe = new System.Windows.Forms.Label();
            this.dtgv_quanlikhachhang = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_SearchXe = new System.Windows.Forms.Button();
            this.txb_SearchXe = new System.Windows.Forms.TextBox();
            this.lbl_SearchXe = new System.Windows.Forms.Label();
            this.dtgv_QuanLiThueXe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_quanlikhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QuanLiThueXe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.AutoSize = true;
            this.lbl_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CMND.Location = new System.Drawing.Point(24, 35);
            this.lbl_CMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(52, 15);
            this.lbl_CMND.TabIndex = 2;
            this.lbl_CMND.Text = "CMND:";
            // 
            // lbl_LoaiXe
            // 
            this.lbl_LoaiXe.AutoSize = true;
            this.lbl_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiXe.Location = new System.Drawing.Point(24, 94);
            this.lbl_LoaiXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiXe.Name = "lbl_LoaiXe";
            this.lbl_LoaiXe.Size = new System.Drawing.Size(60, 15);
            this.lbl_LoaiXe.TabIndex = 3;
            this.lbl_LoaiXe.Text = "Loại Xe:";
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BienSo.Location = new System.Drawing.Point(24, 211);
            this.lbl_BienSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(61, 15);
            this.lbl_BienSo.TabIndex = 4;
            this.lbl_BienSo.Text = "Biển Số:";
            // 
            // lbl_Anh
            // 
            this.lbl_Anh.AutoSize = true;
            this.lbl_Anh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anh.Location = new System.Drawing.Point(24, 274);
            this.lbl_Anh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Anh.Name = "lbl_Anh";
            this.lbl_Anh.Size = new System.Drawing.Size(35, 15);
            this.lbl_Anh.TabIndex = 6;
            this.lbl_Anh.Text = "Ảnh:";
            // 
            // lbl_NgayHopDong
            // 
            this.lbl_NgayHopDong.AutoSize = true;
            this.lbl_NgayHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayHopDong.Location = new System.Drawing.Point(24, 451);
            this.lbl_NgayHopDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayHopDong.Name = "lbl_NgayHopDong";
            this.lbl_NgayHopDong.Size = new System.Drawing.Size(111, 15);
            this.lbl_NgayHopDong.TabIndex = 7;
            this.lbl_NgayHopDong.Text = "Ngày Hợp Đồng:";
            // 
            // lbl_TriGiaHD
            // 
            this.lbl_TriGiaHD.AutoSize = true;
            this.lbl_TriGiaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TriGiaHD.Location = new System.Drawing.Point(24, 496);
            this.lbl_TriGiaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TriGiaHD.Name = "lbl_TriGiaHD";
            this.lbl_TriGiaHD.Size = new System.Drawing.Size(122, 15);
            this.lbl_TriGiaHD.TabIndex = 8;
            this.lbl_TriGiaHD.Text = "Trị Giá Hợp Đồng:";
            // 
            // lbl_NgayGiaoXe
            // 
            this.lbl_NgayGiaoXe.AutoSize = true;
            this.lbl_NgayGiaoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayGiaoXe.Location = new System.Drawing.Point(24, 544);
            this.lbl_NgayGiaoXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayGiaoXe.Name = "lbl_NgayGiaoXe";
            this.lbl_NgayGiaoXe.Size = new System.Drawing.Size(98, 15);
            this.lbl_NgayGiaoXe.TabIndex = 9;
            this.lbl_NgayGiaoXe.Text = "Ngày Giao Xe:";
            // 
            // lbl_NgayHetHanThue
            // 
            this.lbl_NgayHetHanThue.AutoSize = true;
            this.lbl_NgayHetHanThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayHetHanThue.Location = new System.Drawing.Point(18, 592);
            this.lbl_NgayHetHanThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayHetHanThue.Name = "lbl_NgayHetHanThue";
            this.lbl_NgayHetHanThue.Size = new System.Drawing.Size(135, 15);
            this.lbl_NgayHetHanThue.TabIndex = 10;
            this.lbl_NgayHetHanThue.Text = "Ngày Hết Hạn Thuê:";
            // 
            // txb_CMND
            // 
            this.txb_CMND.Location = new System.Drawing.Point(215, 32);
            this.txb_CMND.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CMND.Name = "txb_CMND";
            this.txb_CMND.Size = new System.Drawing.Size(208, 21);
            this.txb_CMND.TabIndex = 13;
            // 
            // cb_LoaiXe
            // 
            this.cb_LoaiXe.FormattingEnabled = true;
            this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe máy",
            "Xe  hơi"});
            this.cb_LoaiXe.Location = new System.Drawing.Point(217, 94);
            this.cb_LoaiXe.Margin = new System.Windows.Forms.Padding(4);
            this.cb_LoaiXe.Name = "cb_LoaiXe";
            this.cb_LoaiXe.Size = new System.Drawing.Size(208, 23);
            this.cb_LoaiXe.TabIndex = 14;
            // 
            // txb_BienSo
            // 
            this.txb_BienSo.Location = new System.Drawing.Point(217, 211);
            this.txb_BienSo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BienSo.Name = "txb_BienSo";
            this.txb_BienSo.Size = new System.Drawing.Size(208, 21);
            this.txb_BienSo.TabIndex = 15;
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.Location = new System.Drawing.Point(215, 274);
            this.ptb_Anh.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(210, 113);
            this.ptb_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Anh.TabIndex = 17;
            this.ptb_Anh.TabStop = false;
            // 
            // dtp_NgayHopDong
            // 
            this.dtp_NgayHopDong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayHopDong.Location = new System.Drawing.Point(215, 451);
            this.dtp_NgayHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayHopDong.Name = "dtp_NgayHopDong";
            this.dtp_NgayHopDong.Size = new System.Drawing.Size(208, 21);
            this.dtp_NgayHopDong.TabIndex = 18;
            // 
            // txb_TriGiaHD
            // 
            this.txb_TriGiaHD.Location = new System.Drawing.Point(215, 496);
            this.txb_TriGiaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txb_TriGiaHD.Name = "txb_TriGiaHD";
            this.txb_TriGiaHD.Size = new System.Drawing.Size(208, 21);
            this.txb_TriGiaHD.TabIndex = 19;
            // 
            // dtp_NgayGiaoXe
            // 
            this.dtp_NgayGiaoXe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayGiaoXe.Location = new System.Drawing.Point(215, 544);
            this.dtp_NgayGiaoXe.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayGiaoXe.Name = "dtp_NgayGiaoXe";
            this.dtp_NgayGiaoXe.Size = new System.Drawing.Size(208, 21);
            this.dtp_NgayGiaoXe.TabIndex = 20;
            // 
            // dtp_NgayHetHanThue
            // 
            this.dtp_NgayHetHanThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayHetHanThue.Location = new System.Drawing.Point(215, 592);
            this.dtp_NgayHetHanThue.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayHetHanThue.Name = "dtp_NgayHetHanThue";
            this.dtp_NgayHetHanThue.Size = new System.Drawing.Size(208, 21);
            this.dtp_NgayHetHanThue.TabIndex = 21;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(21, 637);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(181, 64);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.BackColor = System.Drawing.Color.Yellow;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.Location = new System.Drawing.Point(251, 637);
            this.btn_TaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(174, 64);
            this.btn_TaoMoi.TabIndex = 23;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = false;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(215, 412);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(99, 32);
            this.btn_Upload.TabIndex = 24;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Download.Location = new System.Drawing.Point(323, 412);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(102, 32);
            this.btn_Download.TabIndex = 25;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // txb_HieuXe
            // 
            this.txb_HieuXe.Location = new System.Drawing.Point(215, 151);
            this.txb_HieuXe.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HieuXe.Name = "txb_HieuXe";
            this.txb_HieuXe.Size = new System.Drawing.Size(208, 21);
            this.txb_HieuXe.TabIndex = 26;
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HieuXe.Location = new System.Drawing.Point(24, 151);
            this.lbl_HieuXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(62, 15);
            this.lbl_HieuXe.TabIndex = 27;
            this.lbl_HieuXe.Text = "Hiệu Xe:";
            // 
            // dtgv_quanlikhachhang
            // 
            this.dtgv_quanlikhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_quanlikhachhang.Location = new System.Drawing.Point(466, 79);
            this.dtgv_quanlikhachhang.Name = "dtgv_quanlikhachhang";
            this.dtgv_quanlikhachhang.Size = new System.Drawing.Size(371, 281);
            this.dtgv_quanlikhachhang.TabIndex = 31;
            this.dtgv_quanlikhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_quanlikhachhang_CellClick);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(712, 35);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 35);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(551, 42);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(119, 21);
            this.txb_Search.TabIndex = 33;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(475, 42);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(49, 15);
            this.lbl_Search.TabIndex = 32;
            this.lbl_Search.Text = "Search:";
            // 
            // btn_SearchXe
            // 
            this.btn_SearchXe.Location = new System.Drawing.Point(712, 389);
            this.btn_SearchXe.Name = "btn_SearchXe";
            this.btn_SearchXe.Size = new System.Drawing.Size(90, 35);
            this.btn_SearchXe.TabIndex = 37;
            this.btn_SearchXe.Text = "Search";
            this.btn_SearchXe.UseVisualStyleBackColor = true;
            this.btn_SearchXe.Click += new System.EventHandler(this.btn_SearchXe_Click);
            // 
            // txb_SearchXe
            // 
            this.txb_SearchXe.Location = new System.Drawing.Point(551, 396);
            this.txb_SearchXe.Name = "txb_SearchXe";
            this.txb_SearchXe.Size = new System.Drawing.Size(119, 21);
            this.txb_SearchXe.TabIndex = 36;
            // 
            // lbl_SearchXe
            // 
            this.lbl_SearchXe.AutoSize = true;
            this.lbl_SearchXe.Location = new System.Drawing.Point(475, 396);
            this.lbl_SearchXe.Name = "lbl_SearchXe";
            this.lbl_SearchXe.Size = new System.Drawing.Size(49, 15);
            this.lbl_SearchXe.TabIndex = 35;
            this.lbl_SearchXe.Text = "Search:";
            // 
            // dtgv_QuanLiThueXe
            // 
            this.dtgv_QuanLiThueXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_QuanLiThueXe.Location = new System.Drawing.Point(466, 451);
            this.dtgv_QuanLiThueXe.Name = "dtgv_QuanLiThueXe";
            this.dtgv_QuanLiThueXe.Size = new System.Drawing.Size(371, 250);
            this.dtgv_QuanLiThueXe.TabIndex = 38;
            this.dtgv_QuanLiThueXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_QuanLiThueXe_CellClick);
            // 
            // FrmQuanLiDSThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 718);
            this.Controls.Add(this.dtgv_QuanLiThueXe);
            this.Controls.Add(this.btn_SearchXe);
            this.Controls.Add(this.txb_SearchXe);
            this.Controls.Add(this.lbl_SearchXe);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.dtgv_quanlikhachhang);
            this.Controls.Add(this.lbl_HieuXe);
            this.Controls.Add(this.txb_HieuXe);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtp_NgayHetHanThue);
            this.Controls.Add(this.dtp_NgayGiaoXe);
            this.Controls.Add(this.txb_TriGiaHD);
            this.Controls.Add(this.dtp_NgayHopDong);
            this.Controls.Add(this.ptb_Anh);
            this.Controls.Add(this.txb_BienSo);
            this.Controls.Add(this.cb_LoaiXe);
            this.Controls.Add(this.txb_CMND);
            this.Controls.Add(this.lbl_NgayHetHanThue);
            this.Controls.Add(this.lbl_NgayGiaoXe);
            this.Controls.Add(this.lbl_TriGiaHD);
            this.Controls.Add(this.lbl_NgayHopDong);
            this.Controls.Add(this.lbl_Anh);
            this.Controls.Add(this.lbl_BienSo);
            this.Controls.Add(this.lbl_LoaiXe);
            this.Controls.Add(this.lbl_CMND);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLiDSThueXe";
            this.Text = "Thêm xe vào danh sách cho thuê";
            this.Load += new System.EventHandler(this.FrmThueXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_quanlikhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_QuanLiThueXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CMND;
        private System.Windows.Forms.Label lbl_LoaiXe;
        private System.Windows.Forms.Label lbl_BienSo;
        private System.Windows.Forms.Label lbl_Anh;
        private System.Windows.Forms.Label lbl_NgayHopDong;
        private System.Windows.Forms.Label lbl_TriGiaHD;
        private System.Windows.Forms.Label lbl_NgayGiaoXe;
        private System.Windows.Forms.Label lbl_NgayHetHanThue;
        private System.Windows.Forms.TextBox txb_CMND;
        private System.Windows.Forms.ComboBox cb_LoaiXe;
        private System.Windows.Forms.TextBox txb_BienSo;
        private System.Windows.Forms.PictureBox ptb_Anh;
        private System.Windows.Forms.DateTimePicker dtp_NgayHopDong;
        private System.Windows.Forms.TextBox txb_TriGiaHD;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiaoXe;
        private System.Windows.Forms.DateTimePicker dtp_NgayHetHanThue;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox txb_HieuXe;
        private System.Windows.Forms.Label lbl_HieuXe;
        private System.Windows.Forms.DataGridView dtgv_quanlikhachhang;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_SearchXe;
        private System.Windows.Forms.TextBox txb_SearchXe;
        private System.Windows.Forms.Label lbl_SearchXe;
        private System.Windows.Forms.DataGridView dtgv_QuanLiThueXe;
    }
}