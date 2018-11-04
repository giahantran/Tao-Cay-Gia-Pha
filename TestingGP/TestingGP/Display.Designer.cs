namespace TestingGP
{
    partial class Display
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvGiaPha = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combTheHe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combMaTV = new System.Windows.Forms.ComboBox();
            this.checkBGioiTinh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNgaySinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combNamMat = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaPha)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(722, 24);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(390, 608);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(82, 34);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvGiaPha
            // 
            this.dgvGiaPha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaPha.Location = new System.Drawing.Point(503, 53);
            this.dgvGiaPha.Name = "dgvGiaPha";
            this.dgvGiaPha.RowTemplate.Height = 24;
            this.dgvGiaPha.Size = new System.Drawing.Size(673, 579);
            this.dgvGiaPha.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên";
            // 
            // txtbHoTen
            // 
            this.txtbHoTen.Location = new System.Drawing.Point(82, 105);
            this.txtbHoTen.Name = "txtbHoTen";
            this.txtbHoTen.Size = new System.Drawing.Size(190, 22);
            this.txtbHoTen.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thế hệ";
            // 
            // combTheHe
            // 
            this.combTheHe.FormattingEnabled = true;
            this.combTheHe.Location = new System.Drawing.Point(211, 63);
            this.combTheHe.Name = "combTheHe";
            this.combTheHe.Size = new System.Drawing.Size(61, 24);
            this.combTheHe.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã TV";
            // 
            // combMaTV
            // 
            this.combMaTV.FormattingEnabled = true;
            this.combMaTV.Location = new System.Drawing.Point(82, 63);
            this.combMaTV.Name = "combMaTV";
            this.combMaTV.Size = new System.Drawing.Size(64, 24);
            this.combMaTV.TabIndex = 11;
            // 
            // checkBGioiTinh
            // 
            this.checkBGioiTinh.AutoSize = true;
            this.checkBGioiTinh.Location = new System.Drawing.Point(288, 106);
            this.checkBGioiTinh.Name = "checkBGioiTinh";
            this.checkBGioiTinh.Size = new System.Drawing.Size(59, 21);
            this.checkBGioiTinh.TabIndex = 12;
            this.checkBGioiTinh.Text = "Nam";
            this.checkBGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh";
            // 
            // txtbNgaySinh
            // 
            this.txtbNgaySinh.Location = new System.Drawing.Point(103, 144);
            this.txtbNgaySinh.Name = "txtbNgaySinh";
            this.txtbNgaySinh.Size = new System.Drawing.Size(108, 22);
            this.txtbNgaySinh.TabIndex = 15;
            this.txtbNgaySinh.Click += new System.EventHandler(this.txtbNgaySinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Năm mất";
            // 
            // combNamMat
            // 
            this.combNamMat.FormattingEnabled = true;
            this.combNamMat.Location = new System.Drawing.Point(382, 147);
            this.combNamMat.Name = "combNamMat";
            this.combNamMat.Size = new System.Drawing.Size(90, 24);
            this.combNamMat.TabIndex = 17;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(224, 144);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(48, 26);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(103, 165);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 653);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.combNamMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBGioiTinh);
            this.Controls.Add(this.combMaTV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combTheHe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGiaPha);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.textBox1);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaPha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvGiaPha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combTheHe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combMaTV;
        private System.Windows.Forms.CheckBox checkBGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combNamMat;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}