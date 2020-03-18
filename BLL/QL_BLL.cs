using _102170286_NguyenThanhLong_17TCLC2.DAL;
using _102170286_NguyenThanhLong_17TCLC2.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102170286_NguyenThanhLong_17TCLC2.BLL
{
    class QL_BLL
    {
        public QL_DAL ql_dal { get; set; }
        public QL_BLL()
        {
            this.ql_dal = new QL_DAL();
        }
        public IList ShowTest_BLL(string text)
        {
            return this.ql_dal.ShowTest_DAL(text);
        }
        
        public void Add_BLL(KhachHang kh)
        {
            ql_dal.Add_DAL(kh);
        }
        public void Del_BLL(string mskh)
        {
            ql_dal.Del_DAL(mskh);
        }

        public void Update_BLL()
        {
            ql_dal.Update_DAL();
        }
        public IList Search_BLL(string text)
        {
            return ql_dal.Search_DAL(text);
        }
        public void Sort_BLL(DataGridView dt,string text)
        {
            ql_dal.Sort_DAL(dt,text);
        }
        public delegate bool Compare(object o1, object o2);
        public object[] Sort(object[] o, Compare comp)
        {
            for (int i = 0; i < o.Length; i++)
            {
                for (int j = 0; j < o.Length; j++)
                {
                    if (comp(o[i],o[j]))
                    {
                        object tam;
                        tam = o[i];
                        o[i] = o[j];
                        o[j] = tam;
                    }
                }
            }
            return o;
        }
        public KhachHang getKH(string mskh)
        {
            return ql_dal.getKH(mskh);
        }
    }
}
