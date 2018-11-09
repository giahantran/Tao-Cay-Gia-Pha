namespace TestingGP
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuocgiapha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaymat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVoChong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TheHe,
            this.Thuocgiapha,
            this.Hovaten,
            this.Gioitinh,
            this.Ngaysinh,
            this.Ngaymat,
            this.Noisinh,
            this.Nghenghiep,
            this.HotenCha,
            this.HotenMe,
            this.TenVoChong,
            this.HotenCon,
            this.Ghichu});
            this.dataGridView1.Location = new System.Drawing.Point(-19, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập thế hệ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(110, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // TheHe
            // 
            this.TheHe.DataPropertyName = "Thế Hệ";
            this.TheHe.HeaderText = "Thế Hệ";
            this.TheHe.Name = "TheHe";
            this.TheHe.Width = 68;
            // 
            // Thuocgiapha
            // 
            this.Thuocgiapha.DataPropertyName = "Thuộc Gia Phả";
            this.Thuocgiapha.HeaderText = "Thuộc Gia Phả";
            this.Thuocgiapha.Name = "Thuocgiapha";
            this.Thuocgiapha.Width = 78;
            // 
            // Hovaten
            // 
            this.Hovaten.DataPropertyName = "Họ và tên";
            this.Hovaten.HeaderText = "Họ và tên";
            this.Hovaten.Name = "Hovaten";
            this.Hovaten.Width = 73;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Giới tính";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 67;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngày sinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Width = 73;
            // 
            // Ngaymat
            // 
            this.Ngaymat.DataPropertyName = "Ngày mất";
            this.Ngaymat.HeaderText = "Ngày mất";
            this.Ngaymat.Name = "Ngaymat";
            this.Ngaymat.Width = 71;
            // 
            // Noisinh
            // 
            this.Noisinh.DataPropertyName = "Nơi sinh";
            this.Noisinh.HeaderText = "Nơi sinh";
            this.Noisinh.Name = "Noisinh";
            this.Noisinh.Width = 65;
            // 
            // Nghenghiep
            // 
            this.Nghenghiep.DataPropertyName = "Nghề nghiệp";
            this.Nghenghiep.HeaderText = "Nghề nghiệp";
            this.Nghenghiep.Name = "Nghenghiep";
            this.Nghenghiep.Width = 86;
            // 
            // HotenCha
            // 
            this.HotenCha.DataPropertyName = "Họ tên Cha";
            this.HotenCha.HeaderText = "Họ tên Cha";
            this.HotenCha.Name = "HotenCha";
            this.HotenCha.Width = 79;
            // 
            // HotenMe
            // 
            this.HotenMe.DataPropertyName = "Họ tên Mẹ";
            this.HotenMe.HeaderText = "Họ tên Mẹ";
            this.HotenMe.Name = "HotenMe";
            this.HotenMe.Width = 76;
            // 
            // TenVoChong
            // 
            this.TenVoChong.DataPropertyName = "Tên Vợ (Chồng)";
            this.TenVoChong.HeaderText = "Tên Vợ (Chồng)";
            this.TenVoChong.Name = "TenVoChong";
            this.TenVoChong.Width = 98;
            // 
            // HotenCon
            // 
            this.HotenCon.DataPropertyName = "Họ tên Con";
            this.HotenCon.HeaderText = "Họ tên Con";
            this.HotenCon.Name = "HotenCon";
            this.HotenCon.Width = 79;
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghi chú";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.Width = 64;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuocgiapha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaymat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotenCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotenMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVoChong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotenCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}