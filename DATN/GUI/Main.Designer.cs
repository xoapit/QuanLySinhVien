namespace DATN
{
    partial class Main
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
            this.comboBoxGVHD = new System.Windows.Forms.ComboBox();
            this.comboBoxTinhTrang = new System.Windows.Forms.ComboBox();
            this.comboBoxHuongNC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSinhVienTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHuongNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NamThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGVHD
            // 
            this.comboBoxGVHD.FormattingEnabled = true;
            this.comboBoxGVHD.Location = new System.Drawing.Point(403, 269);
            this.comboBoxGVHD.Name = "comboBoxGVHD";
            this.comboBoxGVHD.Size = new System.Drawing.Size(313, 21);
            this.comboBoxGVHD.TabIndex = 3;
            this.comboBoxGVHD.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxTinhTrang
            // 
            this.comboBoxTinhTrang.FormattingEnabled = true;
            this.comboBoxTinhTrang.Location = new System.Drawing.Point(403, 242);
            this.comboBoxTinhTrang.Name = "comboBoxTinhTrang";
            this.comboBoxTinhTrang.Size = new System.Drawing.Size(313, 21);
            this.comboBoxTinhTrang.TabIndex = 4;
            this.comboBoxTinhTrang.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinhTrang_SelectedIndexChanged);
            // 
            // comboBoxHuongNC
            // 
            this.comboBoxHuongNC.FormattingEnabled = true;
            this.comboBoxHuongNC.Location = new System.Drawing.Point(403, 215);
            this.comboBoxHuongNC.Name = "comboBoxHuongNC";
            this.comboBoxHuongNC.Size = new System.Drawing.Size(313, 21);
            this.comboBoxHuongNC.TabIndex = 5;
            this.comboBoxHuongNC.SelectedIndexChanged += new System.EventHandler(this.comboBoxHuongNC_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tình Trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hướng NC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "GVHD";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(103, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDoAn,
            this.TenSinhVienTH,
            this.TenHuongNC,
            this.TenGiangVien,
            this.TinhTrang,
            this.NamThucHien});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 184);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenDoAn
            // 
            this.TenDoAn.DataPropertyName = "TenDoAn";
            this.TenDoAn.HeaderText = "Tên Đề Tài";
            this.TenDoAn.Name = "TenDoAn";
            // 
            // TenSinhVienTH
            // 
            this.TenSinhVienTH.DataPropertyName = "TenSinhVienTH";
            this.TenSinhVienTH.HeaderText = "SV Thực Hiện";
            this.TenSinhVienTH.Name = "TenSinhVienTH";
            // 
            // TenHuongNC
            // 
            this.TenHuongNC.DataPropertyName = "TenHuongNC";
            this.TenHuongNC.HeaderText = "Hướng NC";
            this.TenHuongNC.Name = "TenHuongNC";
            // 
            // TenGiangVien
            // 
            this.TenGiangVien.DataPropertyName = "TenGiangVien";
            this.TenGiangVien.HeaderText = "GVHD";
            this.TenGiangVien.Name = "TenGiangVien";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NamThucHien
            // 
            this.NamThucHien.DataPropertyName = "NamThucHien";
            this.NamThucHien.HeaderText = "Năm Bảo Vệ";
            this.NamThucHien.Name = "NamThucHien";
            this.NamThucHien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(94, 269);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(175, 20);
            this.txtTimKiem.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 327);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxHuongNC);
            this.Controls.Add(this.comboBoxTinhTrang);
            this.Controls.Add(this.comboBoxGVHD);
            this.Name = "Main";
            this.Text = "Quản lý DATN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGVHD;
        private System.Windows.Forms.ComboBox comboBoxTinhTrang;
        private System.Windows.Forms.ComboBox comboBoxHuongNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSinhVienTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHuongNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiangVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamThucHien;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}

