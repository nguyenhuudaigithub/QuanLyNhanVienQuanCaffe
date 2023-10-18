namespace QuanLyNhanVienQuanCaffe
{
    partial class BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnInXem = new System.Windows.Forms.Button();
            this.radioLuongTheoNgay = new System.Windows.Forms.RadioButton();
            this.radioLichLamViec = new System.Windows.Forms.RadioButton();
            this.radioDanhSachNV = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.bttnInXem);
            this.groupBox1.Controls.Add(this.radioLuongTheoNgay);
            this.groupBox1.Controls.Add(this.radioLichLamViec);
            this.groupBox1.Controls.Add(this.radioDanhSachNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bttnInXem
            // 
            this.bttnInXem.BackColor = System.Drawing.Color.LightGreen;
            this.bttnInXem.Location = new System.Drawing.Point(439, 47);
            this.bttnInXem.Name = "bttnInXem";
            this.bttnInXem.Size = new System.Drawing.Size(110, 38);
            this.bttnInXem.TabIndex = 3;
            this.bttnInXem.Text = "In/Xem";
            this.bttnInXem.UseVisualStyleBackColor = false;
            this.bttnInXem.Click += new System.EventHandler(this.bttnInXem_Click);
            // 
            // radioLuongTheoNgay
            // 
            this.radioLuongTheoNgay.AutoSize = true;
            this.radioLuongTheoNgay.ForeColor = System.Drawing.Color.Transparent;
            this.radioLuongTheoNgay.Location = new System.Drawing.Point(19, 91);
            this.radioLuongTheoNgay.Name = "radioLuongTheoNgay";
            this.radioLuongTheoNgay.Size = new System.Drawing.Size(179, 29);
            this.radioLuongTheoNgay.TabIndex = 2;
            this.radioLuongTheoNgay.TabStop = true;
            this.radioLuongTheoNgay.Text = "Lương theo ngày";
            this.radioLuongTheoNgay.UseVisualStyleBackColor = true;
            // 
            // radioLichLamViec
            // 
            this.radioLichLamViec.AutoSize = true;
            this.radioLichLamViec.ForeColor = System.Drawing.Color.Transparent;
            this.radioLichLamViec.Location = new System.Drawing.Point(19, 56);
            this.radioLichLamViec.Name = "radioLichLamViec";
            this.radioLichLamViec.Size = new System.Drawing.Size(155, 29);
            this.radioLichLamViec.TabIndex = 1;
            this.radioLichLamViec.TabStop = true;
            this.radioLichLamViec.Text = "Lịch làm việc. ";
            this.radioLichLamViec.UseVisualStyleBackColor = true;
            // 
            // radioDanhSachNV
            // 
            this.radioDanhSachNV.AutoSize = true;
            this.radioDanhSachNV.Checked = true;
            this.radioDanhSachNV.ForeColor = System.Drawing.Color.Transparent;
            this.radioDanhSachNV.Location = new System.Drawing.Point(19, 21);
            this.radioDanhSachNV.Name = "radioDanhSachNV";
            this.radioDanhSachNV.Size = new System.Drawing.Size(265, 29);
            this.radioDanhSachNV.TabIndex = 0;
            this.radioDanhSachNV.TabStop = true;
            this.radioDanhSachNV.Text = "Xem danh sách nhân viên.";
            this.radioDanhSachNV.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 232);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1131, 547);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Báo Cáo";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 791);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDanhSachNV;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button bttnInXem;
        private System.Windows.Forms.Label label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.RadioButton radioLichLamViec;
        private System.Windows.Forms.RadioButton radioLuongTheoNgay;
    }
}