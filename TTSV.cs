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
    public partial class TTSV : Form
    {
        public TTSV()
        {
            InitializeComponent();
            LoadLopSH();
        }
        public void LoadLopSH()
        {
            foreach (DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                cbLopSH.Items.Add(new CBBItem
                {
                    Value = Convert.ToInt32(i["ID_Lop"].ToString()),
                    Text = i["TenLop"].ToString()
                });
            }
            cbLopSH.SelectedIndex = 0;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string MSSV = txtMSSV.Text;
            string NameSV = txtName.Text;
            bool Gender = rbM.Checked;
            DateTime BD = Convert.ToDateTime(dtpNS.Value);
            int LopSH = ((CBBItem)cbLopSH.Items[cbLopSH.SelectedIndex]).Value;
            if (CSDL.Instance.Add(MSSV, NameSV, Gender, BD, LopSH))
            {
                MessageBox.Show("Thêm SV thành công");
            }
            else if (CSDL.Instance.Edit(MSSV, NameSV, Gender, BD, LopSH))
            {
                MessageBox.Show("Edit SV thành công");
            } else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
