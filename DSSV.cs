using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QLSV2FORM
{
    public partial class DSSV : Form
    {
        
        public DSSV()
        {
            InitializeComponent();
            SetCBBShow();
        }
        public void Show(int ID_Lop, string Name)
        {
            dtgvDSSV.DataSource = CSDL_OOP.Instance.GetListSV(ID_Lop, Name);
        }
        public void SetCBBShow()
        {
            cbLopSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach (LSH i in CSDL_OOP.Instance.GetAllLSH())
            {
                cbLopSH.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                });
            }
            cbLopSH.SelectedIndex = 0;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Show(((CBBItem)cbLopSH.SelectedItem).Value, txtSearch.Text);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TTSV fTT = new TTSV(null);
            fTT.d = new TTSV.MyDel(this.Show);
            fTT.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dtgvDSSV.SelectedRows;
            if(data.Count == 1)
            {
                string MSSV = data[0].Cells["MSSV"].Value.ToString();
                TTSV fTT = new TTSV(MSSV);
                fTT.d = new TTSV.MyDel(this.Show);
                fTT.ShowDialog();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dtgvDSSV.SelectedRows;
            if (data.Count == 1)
            {
                string MSSV = data[0].Cells["MSSV"].Value.ToString();
                SV s = CSDL_OOP.Instance.GetSVByMSSV(MSSV);
                CSDL_OOP.Instance.DeleteSV(s);
            }
            Show(0, txtSearch.Text);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Show(((CBBItem)cbLopSH.SelectedItem).Value, txtSearch.Text);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int ID_Lop = ((CBBItem)cbLopSH.Items[cbLopSH.SelectedIndex]).Value;
            switch (cbSort.Text)
            {
                case "Tên, A->Z":
                    dtgvDSSV.DataSource = CSDL_OOP.Instance.Sort(ID_Lop, txtSearch.Text, SV.Compare_NameAZ);
                    break;
                case "Tên, Z->A":
                    dtgvDSSV.DataSource = CSDL_OOP.Instance.Sort(ID_Lop, txtSearch.Text, SV.Compare_NameZA);
                    break;
                case "MSSV, Thấp -> Cao":
                    dtgvDSSV.DataSource = CSDL_OOP.Instance.Sort(ID_Lop, txtSearch.Text, SV.Compare_MSSVAscending);
                    break;
                case "MSSV, Cao -> Thấp":
                    dtgvDSSV.DataSource = CSDL_OOP.Instance.Sort(ID_Lop, txtSearch.Text, SV.Compare_MSSVDescending);
                    break;
                default:
                    break;
            }
        }
    }
}
