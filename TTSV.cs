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
        // Chua su dung duoc delegate
        public delegate void MyDel(int id, string ms);
        public MyDel d { get; set; }

        public string MSSV { get; set; }
        public TTSV()
        {
            InitializeComponent();
            LoadLopSH();
        }
        public TTSV(string ms)
        {
            InitializeComponent();
            LoadLopSH();
            SetGUI(ms);
            txtMSSV.Enabled = false;
        }
        public void SetGUI(string ms)
        {
            if(CSDL_OOP.Instance.GetSVByMSSV(ms) != null)
            {
                // Binding
                SV s = CSDL_OOP.Instance.GetSVByMSSV(ms);
                txtMSSV.Text = s.MSSV;
                txtName.Text = s.NameSV;
                dtpNS.Value = s.NgaySinh;
                if(s.Gender == true)
                {
                    rbM.Checked = true;
                } else
                {
                    rBF.Checked = true;
                }
                cbLopSH.Text = ((CBBItem)cbLopSH.Items[s.ID_Lop - 1]).Text;
            }
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
            this.Dispose();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string MSSV = txtMSSV.Text;
            string NameSV = txtName.Text;
            bool Gender = rbM.Checked;
            DateTime BD = Convert.ToDateTime(dtpNS.Value);
            int LopSH = ((CBBItem)cbLopSH.Items[cbLopSH.SelectedIndex]).Value;
            SV s = new SV(MSSV, NameSV, Gender, BD, LopSH);
            CSDL_OOP.Instance.ExecuteDB(s);
            this.Dispose();
        }
    }
}
