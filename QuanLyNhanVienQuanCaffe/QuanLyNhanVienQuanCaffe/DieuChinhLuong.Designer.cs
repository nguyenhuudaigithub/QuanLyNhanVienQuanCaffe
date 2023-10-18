namespace QuanLyNhanVienQuanCaffe
{
    partial class DieuChinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieuChinhLuong));
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LuongTheoGioHT = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.ChucVu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnTimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.Label();
            this.bttnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(326, 240);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(248, 34);
            this.txtLuong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(10, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lương Theo Giờ Hiện Tại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điều Chỉnh Lương";
            // 
            // LuongTheoGioHT
            // 
            this.LuongTheoGioHT.AutoSize = true;
            this.LuongTheoGioHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LuongTheoGioHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuongTheoGioHT.ForeColor = System.Drawing.Color.White;
            this.LuongTheoGioHT.Location = new System.Drawing.Point(317, 198);
            this.LuongTheoGioHT.Name = "LuongTheoGioHT";
            this.LuongTheoGioHT.Size = new System.Drawing.Size(0, 29);
            this.LuongTheoGioHT.TabIndex = 3;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(204, 68);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(231, 37);
            this.cbbMaNV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Nhân Viên :";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Nhân Viên :";
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSize = true;
            this.ChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVu.ForeColor = System.Drawing.Color.White;
            this.ChucVu.Location = new System.Drawing.Point(131, 157);
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Size = new System.Drawing.Size(0, 29);
            this.ChucVu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(10, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lương Theo Giờ Mới :";
            // 
            // bttnTimKiem
            // 
            this.bttnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnTimKiem.Location = new System.Drawing.Point(455, 70);
            this.bttnTimKiem.Name = "bttnTimKiem";
            this.bttnTimKiem.Size = new System.Drawing.Size(107, 33);
            this.bttnTimKiem.TabIndex = 6;
            this.bttnTimKiem.Text = "Tìm kiếm";
            this.bttnTimKiem.UseVisualStyleBackColor = true;
            this.bttnTimKiem.Click += new System.EventHandler(this.bttnTimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(8, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chức Vụ :";
            // 
            // TenNV
            // 
            this.TenNV.AutoSize = true;
            this.TenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNV.ForeColor = System.Drawing.Color.White;
            this.TenNV.Location = new System.Drawing.Point(204, 115);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(0, 29);
            this.TenNV.TabIndex = 3;
            // 
            // bttnLuu
            // 
            this.bttnLuu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bttnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLuu.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.bttnLuu.Location = new System.Drawing.Point(244, 328);
            this.bttnLuu.Name = "bttnLuu";
            this.bttnLuu.Size = new System.Drawing.Size(107, 33);
            this.bttnLuu.TabIndex = 6;
            this.bttnLuu.Text = "Lưu";
            this.bttnLuu.UseVisualStyleBackColor = false;
            this.bttnLuu.Click += new System.EventHandler(this.bttnLuu_Click);
            // 
            // DieuChinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 404);
            this.Controls.Add(this.bttnLuu);
            this.Controls.Add(this.bttnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.ChucVu);
            this.Controls.Add(this.LuongTheoGioHT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuong);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DieuChinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều Chỉnh Lương";
            this.Load += new System.EventHandler(this.DieuChinhLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LuongTheoGioHT;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Label label3;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TenNV;
        private System.Windows.Forms.Button bttnLuu;
    }
}