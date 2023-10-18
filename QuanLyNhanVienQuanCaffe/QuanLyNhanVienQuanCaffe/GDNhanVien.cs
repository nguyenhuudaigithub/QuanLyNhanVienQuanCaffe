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
using QuanLyNhanVienQuanCaffe.model;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class GDNhanVien : Form
    {
        DbModel context;
        public bool isExit = true;
        public event EventHandler Logout;   
        public GDNhanVien()
        {
            InitializeComponent();
            context = new DbModel();
            // thời gian 
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }       
        private void GDNhanVien_Load(object sender, EventArgs e)
        { 
            // với ulog đã gán bên login thì chỉ cần tìm kiếm xem mã nhân viên nào trùng với ulog, nếu trùng thì xuất hết thông tin của nhân viên đó 
            List<NhanVien> nhanViens = context.NhanVien.ToList();
            List<NhanVien> tk = (from s in nhanViens where s.MaNV == ulog.type.ToString() select s).ToList();
            foreach (var item in tk)
            {
                txtMaNV.Text = item.MaNV;
                txtHoTen.Text = item.TenNV;
                txtChucVu.Text = item.ChucVu;
                txtEmail.Text = item.Email;
                txtLuongTG.Text = item.LuongTheoGio.ToString();
                txtNgaySinh.Text = item.NgaySinh.ToString();
                txtSDT.Text = item.SDT;
                //databse với giới tính là bit, nên khi giá trị giới tính là true thì đổi thành nam, và ngược lại . Sau đó hiện thị lên 
                if (item.GioiTinh == true)
                {
                    txtGioiTinh.Text = "Nam";
                }
                else
                {
                    txtGioiTinh.Text = "Nữ";
                }                
            }
            // với mã nhân viên tương ứng, thì sẽ xuất ra những ngày làm việc tương ứng và đổ lên cbb 
            List<LuongTheoNgay> luongTheoNgays = context.LuongTheoNgay.ToList();
            List<LuongTheoNgay> tk1 = (from s in luongTheoNgays where s.MaNV == ulog.type.ToString() select s).ToList();
            foreach (var item in tk1)
            {
                fill(tk1);
            }        
        }
        private void fill(List<LuongTheoNgay> listLuong)
        {
            this.cmbNgay.DataSource = listLuong;
            this.cmbNgay.DisplayMember = "MaLichTheoNgay";
        }
        private void bttnTimKiem_Click(object sender, EventArgs e)
        {
            // tìm tới mức lương tương ứng với cbb đã chọn và xuất ra 
            List<LuongTheoNgay> luongTheoNgays = context.LuongTheoNgay.ToList();
            List<LuongTheoNgay> tk = (from s in luongTheoNgays where s.MaLichTheoNgay == cmbNgay.Text select s).ToList();
            foreach (var item in tk)
            {
                txtSoGio.Text = item.SoGioLam.ToString();
                txtLuong.Text = item.Luong.ToString();
            }
        }
        private void bttnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.Show();
        }
        private void bttnHoTro_Click(object sender, EventArgs e)
        {
            HoTro hotro = new HoTro();
            hotro.Show();
        }

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

        private void GDNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }        
    }
}
