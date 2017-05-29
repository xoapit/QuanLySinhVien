namespace DATN.GUI
{
    partial class FormEdit
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
            this.btnCancel.Location = new System.Drawing.Point(268, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(121, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Năm bảo vệ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "GVHD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Hướng NC";
            // 
            // lbsdf
            // 
            this.lbsdf.AutoSize = true;
            this.lbsdf.Location = new System.Drawing.Point(49, 100);
            this.lbsdf.Name = "lbsdf";
            this.lbsdf.Size = new System.Drawing.Size(68, 13);
            this.lbsdf.TabIndex = 44;
            this.lbsdf.Text = "SV thực hiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ten DATN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã DATN";
            // 
            // rbDaBaoVe
            // 
            this.rbDaBaoVe.AutoSize = true;
            this.rbDaBaoVe.Location = new System.Drawing.Point(149, 187);
            this.rbDaBaoVe.Name = "rbDaBaoVe";
            this.rbDaBaoVe.Size = new System.Drawing.Size(75, 17);
            this.rbDaBaoVe.TabIndex = 41;
            this.rbDaBaoVe.TabStop = true;
            this.rbDaBaoVe.Text = "Đã bảo vệ";
            this.rbDaBaoVe.UseVisualStyleBackColor = true;
            // 
            // rbChuaBaoVe
            // 
            this.rbChuaBaoVe.AutoSize = true;
            this.rbChuaBaoVe.Location = new System.Drawing.Point(307, 187);
            this.rbChuaBaoVe.Name = "rbChuaBaoVe";
            this.rbChuaBaoVe.Size = new System.Drawing.Size(86, 17);
            this.rbChuaBaoVe.TabIndex = 40;
            this.rbChuaBaoVe.TabStop = true;
            this.rbChuaBaoVe.Text = "Chưa bảo vệ";
            this.rbChuaBaoVe.UseVisualStyleBackColor = true;
            // 
            // comboBoxHuongNC
            // 
            this.comboBoxHuongNC.FormattingEnabled = true;
            this.comboBoxHuongNC.Location = new System.Drawing.Point(149, 119);
            this.comboBoxHuongNC.Name = "comboBoxHuongNC";
            this.comboBoxHuongNC.Size = new System.Drawing.Size(313, 21);
            this.comboBoxHuongNC.TabIndex = 39;
            // 
            // comboBoxNamBaoVe
            // 
            this.comboBoxNamBaoVe.FormattingEnabled = true;
            this.comboBoxNamBaoVe.Location = new System.Drawing.Point(149, 210);
            this.comboBoxNamBaoVe.Name = "comboBoxNamBaoVe";
            this.comboBoxNamBaoVe.Size = new System.Drawing.Size(313, 21);
            this.comboBoxNamBaoVe.TabIndex = 38;
            // 
            // comboBoxGVHD
            // 
            this.comboBoxGVHD.FormattingEnabled = true;
            this.comboBoxGVHD.Location = new System.Drawing.Point(149, 152);
            this.comboBoxGVHD.Name = "comboBoxGVHD";
            this.comboBoxGVHD.Size = new System.Drawing.Size(313, 21);
            this.comboBoxGVHD.TabIndex = 37;
            // 
            // txtTenSVTH
            // 
            this.txtTenSVTH.Location = new System.Drawing.Point(149, 93);
            this.txtTenSVTH.Name = "txtTenSVTH";
            this.txtTenSVTH.Size = new System.Drawing.Size(313, 20);
            this.txtTenSVTH.TabIndex = 36;
            // 
            // txtTenDATN
            // 
            this.txtTenDATN.Location = new System.Drawing.Point(149, 67);
            this.txtTenDATN.Name = "txtTenDATN";
            this.txtTenDATN.Size = new System.Drawing.Size(313, 20);
            this.txtTenDATN.TabIndex = 35;
            // 
            // txtMaDATN
            // 
            this.txtMaDATN.Location = new System.Drawing.Point(149, 38);
            this.txtMaDATN.Name = "txtMaDATN";
            this.txtMaDATN.Size = new System.Drawing.Size(313, 20);
            this.txtMaDATN.TabIndex = 34;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 329);
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
            this.Name = "FormEdit";
            this.Text = "FormEdit";
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