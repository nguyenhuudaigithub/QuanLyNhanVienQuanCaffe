using QuanLyNhanVienQuanCaffe.model;
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
using System.Security.AccessControl;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Migrations;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class DieuChinhLuong : Form
    {
        DbModel context;
        
        public DieuChinhLuong()
        {
            InitializeComponent();
            context = new DbModel();
        }

        private void DieuChinhLuong_Load(object sender, EventArgs e)
        {
           List<NhanVien> listNV = context.NhanVien.ToList();
           fill(listNV);
        }
        private void fill(List<NhanVien> listMNV)
        {
            this.cbbMaNV.DataSource = listMNV;            
            this.cbbMaNV.DisplayMember = "MaNV";
        }
        private void clear()
        {
            cbbMaNV.Text = "";
            txtLuong.Clear();
            LuongTheoGioHT.Text = "";
            TenNV.Text = "";
            ChucVu.Text = "";           
        }
        private void bttnTimKiem_Click(object sender, EventArgs e)
        {
            // tìm kiếm và xuất các thông tin của nhân viên ứng với mã nhân viên đã chọn 
            List<NhanVien> nhanViens = context.NhanVien.ToList();
            List<NhanVien> tk = (from s in nhanViens where s.MaNV == cbbMaNV.Text select s).ToList();           
            foreach (var item in tk )
            {
                TenNV.Text = item.TenNV;
                ChucVu.Text = item.ChucVu;
                LuongTheoGioHT.Text = item.LuongTheoGio.ToString();
            }
        }

        private void bttnLuu_Click(object sender, EventArgs e)
        {
            // cập nhập lại mức lương theo giờ của nhân viên 
            NhanVien update = context.NhanVien.FirstOrDefault(p => p.MaNV == cbbMaNV.Text);
            if (update!= null)
            {
                update.LuongTheoGio = Convert.ToDecimal(txtLuong.Text);
                context.NhanVien.AddOrUpdate(update);
                context.SaveChanges();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                clear();
            }
            else
            {
                MessageBox.Show("Không tìm tháy khoa cần sửa.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
