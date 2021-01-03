namespace DoAnDBMS.view
{
    partial class FrmQuanLiHopDong
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
            this.dtgv_HopDong = new System.Windows.Forms.DataGridView();
            this.btn_SaveToExcel = new System.Windows.Forms.Button();
            this.lb_TongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_HopDong
            // 
            this.dtgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HopDong.Location = new System.Drawing.Point(-1, -1);
            this.dtgv_HopDong.Name = "dtgv_HopDong";
            this.dtgv_HopDong.Size = new System.Drawing.Size(554, 278);
            this.dtgv_HopDong.TabIndex = 0;
            // 
            // btn_SaveToExcel
            // 
            this.btn_SaveToExcel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveToExcel.Location = new System.Drawing.Point(12, 296);
            this.btn_SaveToExcel.Name = "btn_SaveToExcel";
            this.btn_SaveToExcel.Size = new System.Drawing.Size(155, 48);
            this.btn_SaveToExcel.TabIndex = 1;
            this.btn_SaveToExcel.Text = "Save To Excel";
            this.btn_SaveToExcel.UseVisualStyleBackColor = true;
            this.btn_SaveToExcel.Click += new System.EventHandler(this.btn_SaveToExcel_Click);
            // 
            // lb_TongDoanhThu
            // 
            this.lb_TongDoanhThu.Location = new System.Drawing.Point(363, 296);
            this.lb_TongDoanhThu.Name = "lb_TongDoanhThu";
            this.lb_TongDoanhThu.Size = new System.Drawing.Size(160, 48);
            this.lb_TongDoanhThu.TabIndex = 2;
            this.lb_TongDoanhThu.Text = "Tổng tiền:";
            // 
            // FrmQuanLiHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 369);
            this.Controls.Add(this.lb_TongDoanhThu);
            this.Controls.Add(this.btn_SaveToExcel);
            this.Controls.Add(this.dtgv_HopDong);
            this.Name = "FrmQuanLiHopDong";
            this.Text = "FrmQuanLiHopDong";
            this.Load += new System.EventHandler(this.FrmQuanLiHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_HopDong;
        private System.Windows.Forms.Button btn_SaveToExcel;
        private System.Windows.Forms.Label lb_TongDoanhThu;
    }
}