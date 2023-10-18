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
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class Login : Form
    {
        public bool isExit = true;
        DbModel model;

        public Login()
        {
            InitializeComponent();
            model = new DbModel();
            // thời gian 
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
                  
        }
        // Đăng nhập
        private void bttnLogin_Click(object sender, EventArgs e)
        {
        // nhập tài khoản và mật khẩu, sau đó xem trong database có không.
            string taikhoan = txtUserName.Text;
            string matkhau = txtPassword.Text;
            var rec = model.Login.Where(a => a.UserName == taikhoan && a.Password == matkhau).FirstOrDefault();
            if (rec != null)
            {
                // tới bảng nhân viên, tìm tới cột chức vụ.
                // dùng ulog để gán chức vụ 
                if (rec.NhanVien.ChucVu == "Admin" || rec.NhanVien.ChucVu == "Quản Lý")
                {
                    if (rec.NhanVien.ChucVu == "Admin")
                    {
                        ulog.type = "Admin";
                    }
                    else if (rec.NhanVien.ChucVu == "Quản Lý")
                    {
                        ulog.type = "Quản Lý";
                    }

                    this.Hide();
                    QuanLy quanLy = new QuanLy();
                    quanLy.Show();
                    quanLy.Logout += QuanLy_Logout;
                }
                else
                {   
                    // dùng ulog để gán mã nhân viên.
                    ulog.type = rec.NhanVien.MaNV;
                    this.Hide();
                    GDNhanVien gDNhanVien = new GDNhanVien();
                    gDNhanVien.Show();
                    gDNhanVien.Logout += GDNhanVien_Logout;
                }
            }
            else
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Tài Khoản Hoặc Mật Khẩu !!!",
                    "Sai Thông Tin Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void GDNhanVien_Logout(object sender, EventArgs e)
        {
            (sender as GDNhanVien).isExit = false;
            (sender as GDNhanVien).Close();
            this.Show();
        }

        private void QuanLy_Logout(object sender, EventArgs e)
        {
            (sender as QuanLy).isExit = false;
            (sender as QuanLy).Close();
            this.Show();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn Muốn Thoát Chương Trình", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void checkShowPassord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassord.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;  
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; 
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaxMinSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }     
    }
}
