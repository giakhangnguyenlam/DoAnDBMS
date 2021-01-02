namespace DoAnDBMS.view
{
    partial class FrmQuanLiKhachHang
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
            this.dtgv_quanlikhachhang = new System.Windows.Forms.DataGridView();
            this.lbl_CMND = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_Nhan = new System.Windows.Forms.Label();
            this.txb_CMND = new System.Windows.Forms.TextBox();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.txb_lname = new System.Windows.Forms.TextBox();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_quanlikhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_quanlikhachhang
            // 
            this.dtgv_quanlikhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_quanlikhachhang.Location = new System.Drawing.Point(471, 90);
            this.dtgv_quanlikhachhang.Name = "dtgv_quanlikhachhang";
            this.dtgv_quanlikhachhang.Size = new System.Drawing.Size(362, 303);
            this.dtgv_quanlikhachhang.TabIndex = 0;
            this.dtgv_quanlikhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_quanlikhachhang_CellClick);
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.AutoSize = true;
            this.lbl_CMND.Location = new System.Drawing.Point(19, 80);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(42, 13);
            this.lbl_CMND.TabIndex = 1;
            this.lbl_CMND.Text = "CMND:";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(19, 129);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(60, 13);
            this.lbl_fname.TabIndex = 2;
            this.lbl_fname.Text = "First Name:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(19, 184);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 3;
            this.lbl_lname.Text = "Last Name:";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(468, 57);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(44, 13);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Search:";
            // 
            // lbl_Nhan
            // 
            this.lbl_Nhan.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nhan.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Nhan.Location = new System.Drawing.Point(52, 0);
            this.lbl_Nhan.Name = "lbl_Nhan";
            this.lbl_Nhan.Size = new System.Drawing.Size(689, 46);
            this.lbl_Nhan.TabIndex = 5;
            this.lbl_Nhan.Text = "Quản lí khách hàng";
            this.lbl_Nhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_CMND
            // 
            this.txb_CMND.Location = new System.Drawing.Point(112, 80);
            this.txb_CMND.Name = "txb_CMND";
            this.txb_CMND.Size = new System.Drawing.Size(146, 20);
            this.txb_CMND.TabIndex = 6;
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.Location = new System.Drawing.Point(112, 129);
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(146, 20);
            this.txb_FirstName.TabIndex = 7;
            // 
            // txb_lname
            // 
            this.txb_lname.Location = new System.Drawing.Point(112, 184);
            this.txb_lname.Name = "txb_lname";
            this.txb_lname.Size = new System.Drawing.Size(146, 20);
            this.txb_lname.TabIndex = 8;
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(533, 57);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(119, 20);
            this.txb_Search.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(670, 50);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 35);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(49, 419);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(129, 50);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(239, 419);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(137, 50);
            this.btn_Xóa.TabIndex = 12;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.Location = new System.Drawing.Point(442, 419);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(157, 50);
            this.btn_Sửa.TabIndex = 13;
            this.btn_Sửa.Text = "Sửa";
            this.btn_Sửa.UseVisualStyleBackColor = true;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Location = new System.Drawing.Point(658, 419);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(149, 50);
            this.btn_TaoMoi.TabIndex = 14;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // FrmQuanLiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 481);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.btn_Sửa);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.txb_lname);
            this.Controls.Add(this.txb_FirstName);
            this.Controls.Add(this.txb_CMND);
            this.Controls.Add(this.lbl_Nhan);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_CMND);
            this.Controls.Add(this.dtgv_quanlikhachhang);
            this.Name = "FrmQuanLiKhachHang";
            this.Text = "Quản lí khách hàng";
            this.Load += new System.EventHandler(this.FrmQuanLiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_quanlikhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_quanlikhachhang;
        private System.Windows.Forms.Label lbl_CMND;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_Nhan;
        private System.Windows.Forms.TextBox txb_CMND;
        private System.Windows.Forms.TextBox txb_FirstName;
        private System.Windows.Forms.TextBox txb_lname;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Button btn_TaoMoi;
    }
}