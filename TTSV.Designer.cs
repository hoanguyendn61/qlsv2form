
namespace WF_QLSV2FORM
{
    partial class TTSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTTSV = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLopSH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTTSV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(96, 31);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(141, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 22);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // grpTTSV
            // 
            this.grpTTSV.Controls.Add(this.btnCancel);
            this.grpTTSV.Controls.Add(this.btnOK);
            this.grpTTSV.Controls.Add(this.groupBox2);
            this.grpTTSV.Controls.Add(this.dtpNS);
            this.grpTTSV.Controls.Add(this.label3);
            this.grpTTSV.Controls.Add(this.cbLopSH);
            this.grpTTSV.Controls.Add(this.label1);
            this.grpTTSV.Controls.Add(this.txtName);
            this.grpTTSV.Controls.Add(this.txtMSSV);
            this.grpTTSV.Controls.Add(this.label2);
            this.grpTTSV.Location = new System.Drawing.Point(12, 12);
            this.grpTTSV.Name = "grpTTSV";
            this.grpTTSV.Size = new System.Drawing.Size(526, 229);
            this.grpTTSV.TabIndex = 4;
            this.grpTTSV.TabStop = false;
            this.grpTTSV.Text = "Thông tin SV";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 46);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(151, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 46);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBF);
            this.groupBox2.Controls.Add(this.rbM);
            this.groupBox2.Location = new System.Drawing.Point(284, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 77);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rBF
            // 
            this.rBF.AutoSize = true;
            this.rBF.Location = new System.Drawing.Point(125, 33);
            this.rBF.Name = "rBF";
            this.rBF.Size = new System.Drawing.Size(75, 21);
            this.rBF.TabIndex = 1;
            this.rBF.TabStop = true;
            this.rBF.Text = "Female";
            this.rBF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(31, 33);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(59, 21);
            this.rbM.TabIndex = 0;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // dtpNS
            // 
            this.dtpNS.Location = new System.Drawing.Point(284, 31);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(219, 22);
            this.dtpNS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp SH";
            // 
            // cbLopSH
            // 
            this.cbLopSH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopSH.FormattingEnabled = true;
            this.cbLopSH.Location = new System.Drawing.Point(96, 112);
            this.cbLopSH.Name = "cbLopSH";
            this.cbLopSH.Size = new System.Drawing.Size(141, 24);
            this.cbLopSH.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nguyễn Huy Hòa | 102190014 | 19NH13";
            // 
            // TTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 263);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpTTSV);
            this.Name = "TTSV";
            this.Text = "TTSV";
            this.grpTTSV.ResumeLayout(false);
            this.grpTTSV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTTSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMSSV;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RadioButton rBF;
        public System.Windows.Forms.RadioButton rbM;
        public System.Windows.Forms.DateTimePicker dtpNS;
        public System.Windows.Forms.ComboBox cbLopSH;
    }
}