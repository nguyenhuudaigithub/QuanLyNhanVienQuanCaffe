using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace QuanLyNhanVienQuanCaffe
{
    public partial class HoTro : Form
    {
        Attachment Attachment = null;
        public HoTro()
        {
            InitializeComponent();
            
        }

        private void HoTro_Load(object sender, EventArgs e)
        {

        }
        
        private void bttnGui_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text != "" && txtChuDe.Text != "" && txtNoiDung.Text != "")
            {
                try
                {
                    // cố gắng gán file vào nếu có 
                    FileInfo file = new FileInfo(txtGan.Text);
                    Attachment = new Attachment(txtGan.Text);
                }
                catch
                {
                }
                // gửi mail từ hệ thống tới người phụ trách hệ thống 
                GuiMail("quanlynhanviencuahangcaffe@gmail.com", "nguyenhuudaihs@gmail.com", txtChuDe.Text, "- Gmail người gửi : " + txtGmail.Text + "@gmail.com" + "\n- Nội dung : " + txtNoiDung.Text);
                MessageBox.Show("Gửi mail hỗ trợ thành công.", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin !!!",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        void GuiMail(string from, string to, string subject, string messager, Attachment file = null)
        {
           
            MailMessage mess = new MailMessage(from,to,subject,messager);
            // nếu có file đính kèm thì cho thêm file đính kèm vào mess để gửi đi, nếu không có thì bỏ qua và attachmen vẫn là null 
            if (Attachment!=null)
            {
                mess.Attachments.Add(Attachment);
            }
            // thiết lập smtp của gmail 
            SmtpClient client = new SmtpClient("smtp.gmail.com",587);
            client.EnableSsl = true;
            //gmail hệ thống. đây tài khoản và mật khẩu để đăng nhập, đã sử dụng password smpt để đăng nhập với phần mềm thứ 3 
            client.Credentials = new NetworkCredential("quanlynhanviencuahangcaffe@gmail.com", "pqrqailzcdxlyuyk");
            client.Send(mess);
        }
        
        private void bttnGan_Click(object sender, EventArgs e)
        {
            // người dùng muốn có file đính kèm thì sẽ cho người dùng đính kèm file 
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // hiện lên đường dẫn 
                txtGan.Text = dialog.FileName;
            }

        }
    }
}
