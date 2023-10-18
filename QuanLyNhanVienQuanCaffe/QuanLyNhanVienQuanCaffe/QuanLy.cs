using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class QuanLy : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        
        public QuanLy()
        {
            InitializeComponent();
            //thời gian 
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            // show màn hình thông số (chart)
            Home home = new Home();
            home.MdiParent = this;
            home.Show();
        }
        // các thao tác với cửa sổ và đăng xuất 
        private void Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxMinSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
           if (isExit)
                Application.Exit();
        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn Muốn Thoát Chương Trình", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        
        private void bttnDangXuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        // sắp xếp các cửa sổ trong form cha 
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        // chuyển tới cửa số khác 
        private void bttnDSNhanVien_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien thongTinNhanVien = new ThongTinNhanVien();
            thongTinNhanVien.MdiParent = this;
            thongTinNhanVien.Show();
        }

        private void bttnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.MdiParent = this;
            baoCao.Show();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            if (ulog.type == "Quản Lý")
            {
                bttnLuong.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void bttnHoTro_Click(object sender, EventArgs e)
        {
            HoTro hoTro = new HoTro();  
            hoTro.MdiParent = this;
            hoTro.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.MdiParent = this;
            home.Show();
        }

        private void bttnLuong_Click(object sender, EventArgs e)
        {
            DieuChinhLuong dieuChinhLuong = new DieuChinhLuong();
            dieuChinhLuong.MdiParent = this;
            dieuChinhLuong.Show();
        }

        private void bttnExcel_Click(object sender, EventArgs e)
        {
            XuatExcel xuatExcel = new XuatExcel();
            xuatExcel.MdiParent = this;
            xuatExcel.Show();
        }
    }
}
