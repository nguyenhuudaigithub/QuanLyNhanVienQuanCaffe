using Microsoft.Reporting.WinForms;
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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class BaoCao : Form
    {
        DbModel context;
        public BaoCao()
        {
            InitializeComponent();
            context = new DbModel();
            radioDanhSachNV.Enabled = false;
            radioLuongTheoNgay.Enabled = false;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            // ulog của login có lưu lại chức vụ, nếu không phải quản lý hoặc admin thì khóa chức năng là danh sách nhân viên và lương theo ngày
            if (ulog.type == "Admin" || ulog.type == "Quản Lý")
            {
                radioDanhSachNV.Enabled = true;
                radioLuongTheoNgay.Enabled = true;
            }
        }
        
        private void bttnInXem_Click(object sender, EventArgs e)
        {
            // khi chọn chức năng bên radio thì sẽ xuất tương ứng 
            this.reportViewer1.Visible = true;
            if (radioDanhSachNV.Checked)
            {
                List<NhanVien> listNV = context.NhanVien.ToList();               
                this.reportViewer1.LocalReport.ReportPath = "./report/ReportDSNV.rdlc";
                var reportDataSource = new ReportDataSource("DataSetDSNhanVien", listNV);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Bảng danh sách nhân viên";
                this.reportViewer1.RefreshReport();
            }
            else if (radioLichLamViec.Checked)
            {
                List<LichTheoNgay> listTN = context.LichTheoNgay.ToList();
                List<CaSangTheoNgay> listS = context.CaSangTheoNgay.ToList();
                List<CaToiTheoNgay> listT = context.CaToiTheoNgay.ToList();
                List<CaTruaTheoNgay> listTr = context.CaTruaTheoNgay.ToList();
                this.reportViewer1.LocalReport.ReportPath = "./report/Report.rdlc";
                var sang = new ReportDataSource("DataSet1", listS);
                var trua = new ReportDataSource("DataSet2", listTr);
                var toi = new ReportDataSource("DataSet3", listT);
                var TN = new ReportDataSource("DataSet4", listTN);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(sang);
                this.reportViewer1.LocalReport.DataSources.Add(trua);
                this.reportViewer1.LocalReport.DataSources.Add(toi);
                this.reportViewer1.LocalReport.DataSources.Add(TN);
                this.reportViewer1.LocalReport.DisplayName = "Bảng ca làm";
                this.reportViewer1.RefreshReport();
            } 
            else if (radioLuongTheoNgay.Checked)
            {
                List<LuongTheoNgay> listL = context.LuongTheoNgay.ToList();
                this.reportViewer1.LocalReport.ReportPath = "./report/ReportLuong.rdlc";
                var reportDataSource = new ReportDataSource("DataSetLuong", listL);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Lương theo ngày";
                this.reportViewer1.RefreshReport();
            }
        }      
    }
}
