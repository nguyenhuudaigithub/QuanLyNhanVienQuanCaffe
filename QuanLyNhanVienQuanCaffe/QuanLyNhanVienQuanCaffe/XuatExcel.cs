using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using Microsoft.Office.Interop.Excel;
using QuanLyNhanVienQuanCaffe.model;
using DbModel = QuanLyNhanVienQuanCaffe.model.DbModel;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class XuatExcel : Form
    {
        DbModel context = new DbModel();
        public XuatExcel()
        {
            InitializeComponent();
        }
        private void XuatExcel_Load(object sender, EventArgs e)
        {
            // Hiện thị bảng nhân viên 
            List<NhanVien> listNhanVien = context.NhanVien.ToList();
            dgvNhanVien.Rows.Clear();//xóa dữ liệu từ các hàng
            foreach (var item in listNhanVien)//xét từng phần tử trong listStudent
            {
                int index = dgvNhanVien.Rows.Add();//tạo chỉ mục hàng
                dgvNhanVien.Rows[index].Cells[0].Value = item.MaNV;
                dgvNhanVien.Rows[index].Cells[1].Value = item.TenNV;
                dgvNhanVien.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvNhanVien.Rows[index].Cells[3].Value = item.LuongTheoGio;
                if (item.GioiTinh == true)
                {
                    dgvNhanVien.Rows[index].Cells[4].Value = "Nữ".ToString();
                }
                else
                {
                    dgvNhanVien.Rows[index].Cells[4].Value = "Nam".ToString();
                }
                dgvNhanVien.Rows[index].Cells[5].Value = item.SDT;
                dgvNhanVien.Rows[index].Cells[6].Value = item.Email;
                dgvNhanVien.Rows[index].Cells[7].Value = item.Anh;
                dgvNhanVien.Rows[index].Cells[8].Value = item.ChucVu;
            }
            // Hiện thị lương theo ngày         
            List<LuongTheoNgay> listluong = context.LuongTheoNgay.ToList();
            dgvSalaryPerDay.Rows.Clear();//xóa dữ liệu từ các hàng
            foreach (var item in listluong)//xét từng phần tử trong listStudent
            {
                int index = dgvSalaryPerDay.Rows.Add();//tạo chỉ mục hàng
                dgvSalaryPerDay.Rows[index].Cells[0].Value = item.MaLichTheoNgay;
                dgvSalaryPerDay.Rows[index].Cells[1].Value = item.MaNV;
                dgvSalaryPerDay.Rows[index].Cells[2].Value = item.TenNV;
                dgvSalaryPerDay.Rows[index].Cells[3].Value = item.SoGioLam;
                dgvSalaryPerDay.Rows[index].Cells[4].Value = item.Luong;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exportApp;
            Microsoft.Office.Interop.Excel.Worksheet exportWorkSheet = null;
            Microsoft.Office.Interop.Excel.Workbook exportWorkBook;
            try
            {
                exportApp = new Microsoft.Office.Interop.Excel.Application();
                exportWorkBook = exportApp.Workbooks.Add(Type.Missing);//tạo workbook
                exportWorkSheet = exportWorkBook.Sheets["Sheet1"];//đặt tên worksheet
                exportWorkSheet = exportWorkBook.ActiveSheet;//khởi tạo worksheet
                exportWorkSheet.Name = "Export";
                //export Header của Rows trong datagridview
                for (int i = 1; i < dgvNhanVien.Columns.Count; i++)
                {
                    exportWorkSheet.Cells[1, i + 1] = dgvNhanVien.Columns[i].HeaderText;
                }
                //export nội dung
                for (int rows = 0; rows < dgvNhanVien.Rows.Count - 1; rows++)
                {
                    for (int col = 0; col < dgvNhanVien.Columns.Count; col++)
                    {
                        exportWorkSheet.Cells[rows + 2, col + 1] = dgvNhanVien.Rows[rows].Cells[col].Value.ToString();
                    }
                }
                //tuỳ chỉnh cửa sổ export
                SaveFileDialog exportSaveDialog = new SaveFileDialog();
                exportSaveDialog.DefaultExt = "*.xlsx";
                exportSaveDialog.Title = "Export Excel File";
                //exportSaveDialog.InitialDirectory = "D:/Visual Studio/Demo";
                exportSaveDialog.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm";
                exportSaveDialog.ShowDialog();
                if (exportSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    exportWorkSheet.SaveAs(exportSaveDialog.FileName, ReadOnlyRecommended: false);
                }
                exportWorkBook.Close();
                exportApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void bttnExportLuong_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exportApp;
            Microsoft.Office.Interop.Excel.Worksheet exportWorkSheet = null;
            Microsoft.Office.Interop.Excel.Workbook exportWorkBook;
            try
            {
                exportApp = new Microsoft.Office.Interop.Excel.Application();
                exportWorkBook = exportApp.Workbooks.Add(Type.Missing);//tạo workbook
                exportWorkSheet = exportWorkBook.Sheets["Sheet1"];//đặt tên worksheet
                exportWorkSheet = exportWorkBook.ActiveSheet;//khởi tạo worksheet
                exportWorkSheet.Name = "Export";
                //export Header của Rows trong datagridview
                for (int i = 1; i < dgvSalaryPerDay.Columns.Count; i++)
                {
                    exportWorkSheet.Cells[1, i+1] = dgvSalaryPerDay.Columns[i].HeaderText;
                }
                //export nội dung
                for (int rows = 0; rows < dgvSalaryPerDay.Rows.Count - 1; rows++)
                {
                    for (int col = 0; col < dgvSalaryPerDay.Columns.Count; col++)
                    {
                        exportWorkSheet.Cells[rows + 2, col + 1] = dgvSalaryPerDay.Rows[rows].Cells[col].Value.ToString();
                    }
                }
                //tuỳ chỉnh cửa sổ export
                SaveFileDialog exportSaveDialog = new SaveFileDialog();
                exportSaveDialog.DefaultExt = "*.xlsx";
                exportSaveDialog.Title = "Export Excel File";
                //exportSaveDialog.InitialDirectory = "D:/Visual Studio/Demo";
                exportSaveDialog.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm";
                exportSaveDialog.ShowDialog();
                if (exportSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    exportWorkSheet.SaveAs(exportSaveDialog.FileName, ReadOnlyRecommended: false);
                }
                exportWorkBook.Close();
                exportApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
