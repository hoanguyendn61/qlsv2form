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
        public void SetCBBShow()
        {
            cbLopSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach(DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                cbLopSH.Items.Add(new CBBItem
                {
                    Value = Convert.ToInt32(i["ID_Lop"].ToString()),
                    Text = i["TenLop"].ToString()
                });
            }
            cbLopSH.SelectedIndex = 0;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int ID_Lop = ((CBBItem)cbLopSH.Items[cbLopSH.SelectedIndex]).Value;
            dtgvDSSV.DataSource = CSDL.Instance.GetSVByIDLop(ID_Lop);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TTSV fTT = new TTSV();
            fTT.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            TTSV fTT = new TTSV();
            DataGridViewSelectedRowCollection data = dtgvDSSV.SelectedRows;
            if(data.Count == 1)
            {
                fTT.Show();
                string MSSV = data[0].Cells["MSSV"].Value.ToString();
                DataRow row = CSDL.Instance.GetSVByMSSV(MSSV);
                fTT.txtMSSV.Text = row["MSSV"].ToString();
                fTT.txtName.Text = row["NameSV"].ToString();
                fTT.dtpNS.Value = Convert.ToDateTime(row["NgaySinh"].ToString());
                if (Convert.ToBoolean(row["Gender"].ToString()))
                {
                    fTT.rbM.Checked = true;
                }
                else
                {
                    fTT.rBF.Checked = true;
                }
                int idLop = Convert.ToInt32(row["ID_Lop"]);
                fTT.cbLopSH.Text = ((CBBItem)fTT.cbLopSH.Items[idLop-1]).Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dtgvDSSV.SelectedRows;
            List<string> MSSV_del = new List<string>();
            foreach (DataGridViewRow i in data)
            {
                MSSV_del.Add(i.Cells["MSSV"].Value.ToString());
            }
            if (CSDL.Instance.Del(MSSV_del))
            {
                cbLopSH.SelectedIndex = 0;
                int Lop = ((CBBItem)cbLopSH.Items[0]).Value;
                dtgvDSSV.DataSource = CSDL.Instance.GetSVByIDLop(Lop);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (int.TryParse(searchValue, out _))
            {
                // Tìm bằng MSSV
                dtgvDSSV.DataSource = CSDL.Instance.GetDTSVByMSSV(Convert.ToInt32(searchValue));
            } else
            {
                // Tìm bằng tên (ghi đầy đủ họ, tên và viết hoa chữ cái đầu)
                dtgvDSSV.DataSource = CSDL.Instance.GetDTSVByNameSV(searchValue);
            }
            txtSearch.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (cbSort.Text)
            {
                case "Tên, A->Z":
                    dtgvDSSV.Sort(dtgvDSSV.Columns["NameSV"], ListSortDirection.Ascending);
                    break;
                case "Tên, Z->A":
                    dtgvDSSV.Sort(dtgvDSSV.Columns["NameSV"], ListSortDirection.Descending);
                    break;
                case "MSSV, Thấp -> Cao":
                    dtgvDSSV.Sort(dtgvDSSV.Columns["MSSV"], ListSortDirection.Ascending);
                    break;
                case "MSSV, Cao -> Thấp":
                    dtgvDSSV.Sort(dtgvDSSV.Columns["MSSV"], ListSortDirection.Descending);
                    break;
                default:
                    break;
            }
        }
    }
}
