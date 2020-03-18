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

namespace _102170286_NguyenThanhLong_17TCLC2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        QL_BLL ql_bll = new QL_BLL();
        private void btn_Showtest_Click(object sender, EventArgs e)
        {
            datagrview_1.DataSource = ql_bll.ShowTest_BLL(cbbox_HoTen.Text);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
                DetailForm f2 = new DetailForm();
                f2.Sender(cbbox_HoTen.Text);

                f2.sendKH += add;
                f2.ShowDialog();
            datagrview_1.DataSource = ql_bll.ShowTest_BLL(cbbox_HoTen.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void add(KhachHang kh)
        {
            ql_bll.Add_BLL(kh);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DetailForm f2 = new DetailForm();

                f2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            datagrview_1.DataSource = ql_bll.Search_BLL(txtBox_Search.Text);
        }

        private void cbBox_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ql_bll.Sort_BLL(datagrview_1,cbBox_Sort.Text);
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBox_Sort.Text != "MSKH" || cbBox_Sort.Text != "HoTen")
                {
                    MessageBox.Show("Chon thuoc tinh can Sort");
                }

                List<KhachHang> listkh = new List<KhachHang>();
                for (int i = 0; i < datagrview_1.RowCount; i++)
                {

                    listkh.Add(ql_bll.getKH(datagrview_1.Rows[i].Cells["MSKH"].Value.ToString()));
                }
                datagrview_1.DataSource = ql_bll.Sort(listkh.ToArray(), KhachHang.CompareHoTen);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection x = datagrview_1.SelectedRows;
                foreach (DataGridViewRow item in x)
                {

                    ql_bll.Del_BLL(item.Cells[0].Value.ToString());
                }

                btn_Showtest_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //datagrview_1.DataSource = ql_bll.ShowTest_BLL();
        }

        private void cbbox_HoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagrview_1.DataSource = ql_bll.ShowTest_BLL(cbbox_HoTen.Text);
        }
    }
}
