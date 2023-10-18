using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVienQuanCaffe.model;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class Home : Form
    {
        DbModel context;
        public Home()
        {
            InitializeComponent();
            context = new DbModel();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // xuất chart tên nhân viên và lương theo ngày 
            chart.DataSource = context.LuongTheoNgay.ToList();
            chart.Series["Luong"].YValueMembers = "Luong";
            chart.Series["Luong"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart.Series["Luong"].XValueMember = "TenNV";
            chart.Series["Luong"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            // xuất chart ngày sinh và tên nhân viên 
            chart1.DataSource = context.NhanVien.ToList();
            chart1.Series["NămSinh"].YValueMembers = "NgaySinh";
            chart1.Series["NămSinh"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series["NămSinh"].XValueMember = "TenNV";
            chart1.Series["NămSinh"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            // xuất lương theo giờ và tên nhân viên 
            chart2.DataSource = context.NhanVien.ToList();
            chart2.Series["ChucVu"].YValueMembers = "LuongTheoGio";
            chart2.Series["ChucVu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series["ChucVu"].XValueMember = "TenNV";
            chart2.Series["ChucVu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }
    }
}
