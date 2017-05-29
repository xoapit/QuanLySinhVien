namespace DATN
{
    partial class FormAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbsdf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDaBaoVe = new System.Windows.Forms.RadioButton();
            this.rbChuaBaoVe = new System.Windows.Forms.RadioButton();
            this.comboBoxHuongNC = new System.Windows.Forms.ComboBox();
            this.comboBoxNamBaoVe = new System.Windows.Forms.ComboBox();
            this.comboBoxGVHD = new System.Windows.Forms.ComboBox();
            this.txtTenSVTH = new System.Windows.Forms.TextBox();
            this.txtTenDATN = new System.Windows.Forms.TextBox();
            this.txtMaDATN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Năm bảo vệ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tình trạng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "GVHD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hướng NC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbsdf
            // 
            this.lbsdf.AutoSize = true;
            this.lbsdf.Location = new System.Drawing.Point(48, 108);
            this.lbsdf.Name = "lbsdf";
            this.lbsdf.Size = new System.Drawing.Size(68, 13);
            this.lbsdf.TabIndex = 27;
            this.lbsdf.Text = "SV thực hiện";
            this.lbsdf.Click += new System.EventHandler(this.lbsdf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ten DATN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã DATN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbDaBaoVe
            // 
            this.rbDaBaoVe.AutoSize = true;
            this.rbDaBaoVe.Checked = true;
            this.rbDaBaoVe.Location = new System.Drawing.Point(148, 195);
            this.rbDaBaoVe.Name = "rbDaBaoVe";
            this.rbDaBaoVe.Size = new System.Drawing.Size(75, 17);
            this.rbDaBaoVe.TabIndex = 24;
            this.rbDaBaoVe.TabStop = true;
            this.rbDaBaoVe.Text = "Đã bảo vệ";
            this.rbDaBaoVe.UseVisualStyleBackColor = true;
            this.rbDaBaoVe.CheckedChanged += new System.EventHandler(this.rbDaBaoVe_CheckedChanged);
            // 
            // rbChuaBaoVe
            // 
            this.rbChuaBaoVe.AutoSize = true;
            this.rbChuaBaoVe.Location = new System.Drawing.Point(306, 195);
            this.rbChuaBaoVe.Name = "rbChuaBaoVe";
            this.rbChuaBaoVe.Size = new System.Drawing.Size(86, 17);
            this.rbChuaBaoVe.TabIndex = 23;
            this.rbChuaBaoVe.TabStop = true;
            this.rbChuaBaoVe.Text = "Chưa bảo vệ";
            this.rbChuaBaoVe.UseVisualStyleBackColor = true;
            this.rbChuaBaoVe.CheckedChanged += new System.EventHandler(this.rbChuaBaoVe_CheckedChanged);
            // 
            // comboBoxHuongNC
            // 
            this.comboBoxHuongNC.FormattingEnabled = true;
            this.comboBoxHuongNC.Location = new System.Drawing.Point(148, 127);
            this.comboBoxHuongNC.Name = "comboBoxHuongNC";
            this.comboBoxHuongNC.Size = new System.Drawing.Size(313, 21);
            this.comboBoxHuongNC.TabIndex = 22;
            this.comboBoxHuongNC.SelectedIndexChanged += new System.EventHandler(this.comboBoxHuongNC_SelectedIndexChanged);
            // 
            // comboBoxNamBaoVe
            // 
            this.comboBoxNamBaoVe.FormattingEnabled = true;
            this.comboBoxNamBaoVe.Location = new System.Drawing.Point(148, 218);
            this.comboBoxNamBaoVe.Name = "comboBoxNamBaoVe";
            this.comboBoxNamBaoVe.Size = new System.Drawing.Size(313, 21);
            this.comboBoxNamBaoVe.TabIndex = 21;
            this.comboBoxNamBaoVe.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamBaoVe_SelectedIndexChanged);
            // 
            // comboBoxGVHD
            // 
            this.comboBoxGVHD.FormattingEnabled = true;
            this.comboBoxGVHD.Location = new System.Drawing.Point(148, 160);
            this.comboBoxGVHD.Name = "comboBoxGVHD";
            this.comboBoxGVHD.Size = new System.Drawing.Size(313, 21);
            this.comboBoxGVHD.TabIndex = 20;
            this.comboBoxGVHD.SelectedIndexChanged += new System.EventHandler(this.comboBoxGVHD_SelectedIndexChanged);
            // 
            // txtTenSVTH
            // 
            this.txtTenSVTH.Location = new System.Drawing.Point(148, 101);
            this.txtTenSVTH.Name = "txtTenSVTH";
            this.txtTenSVTH.Size = new System.Drawing.Size(313, 20);
            this.txtTenSVTH.TabIndex = 19;
            this.txtTenSVTH.TextChanged += new System.EventHandler(this.txtTenSVTH_TextChanged);
            // 
            // txtTenDATN
            // 
            this.txtTenDATN.Location = new System.Drawing.Point(148, 75);
            this.txtTenDATN.Name = "txtTenDATN";
            this.txtTenDATN.Size = new System.Drawing.Size(313, 20);
            this.txtTenDATN.TabIndex = 18;
            this.txtTenDATN.TextChanged += new System.EventHandler(this.txtTenDATN_TextChanged);
            // 
            // txtMaDATN
            // 
            this.txtMaDATN.Location = new System.Drawing.Point(148, 46);
            this.txtMaDATN.Name = "txtMaDATN";
            this.txtMaDATN.Size = new System.Drawing.Size(313, 20);
            this.txtMaDATN.TabIndex = 17;
            this.txtMaDATN.TextChanged += new System.EventHandler(this.txtMaDATN_TextChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 332);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbsdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDaBaoVe);
            this.Controls.Add(this.rbChuaBaoVe);
            this.Controls.Add(this.comboBoxHuongNC);
            this.Controls.Add(this.comboBoxNamBaoVe);
            this.Controls.Add(this.comboBoxGVHD);
            this.Controls.Add(this.txtTenSVTH);
            this.Controls.Add(this.txtTenDATN);
            this.Controls.Add(this.txtMaDATN);
            this.Name = "FormAdd";
            this.Text = "Form Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbsdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDaBaoVe;
        private System.Windows.Forms.RadioButton rbChuaBaoVe;
        private System.Windows.Forms.ComboBox comboBoxHuongNC;
        private System.Windows.Forms.ComboBox comboBoxNamBaoVe;
        private System.Windows.Forms.ComboBox comboBoxGVHD;
        private System.Windows.Forms.TextBox txtTenSVTH;
        private System.Windows.Forms.TextBox txtTenDATN;
        private System.Windows.Forms.TextBox txtMaDATN;
    }
}