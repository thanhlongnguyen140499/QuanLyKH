using _102170286_NguyenThanhLong_17TCLC2.BLL;
using _102170286_NguyenThanhLong_17TCLC2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _102170286_NguyenThanhLong_17TCLC2.MainForm;

namespace _102170286_NguyenThanhLong_17TCLC2
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
            this.Sender = new SendHoTen(getHoTen);
        }
        public delegate void SendHoTen(string HoTen);
        public SendHoTen Sender { get; set; }

        public delegate void SendKhachHang(KhachHang sKH);
        public SendKhachHang sendKH { get; set; }

        public void getHoTen(string HoTen)
        {
            txtbox_HoTen.Text = HoTen;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang newKH = new KhachHang();

                newKH.MSKH = txtbox_MSKH.Text;
                newKH.HoTen = txtbox_HoTen.Text;
                if (radioButton_Nam.Checked)
                {
                    newKH.GioiTinh = true;
                }
                else
                {
                    newKH.GioiTinh = false;
                }

                this.sendKH(newKH);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
