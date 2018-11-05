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
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
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
            this.checkBThuocGP = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBQueQuan = new System.Windows.Forms.TextBox();
            this.txtBNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtBHotenCha = new System.Windows.Forms.TextBox();
            this.txtBHoTenMe = new System.Windows.Forms.TextBox();
            this.txtBHoTenCon = new System.Windows.Forms.TextBox();
            this.txtBGhiChu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBHoTenVC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaPha)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(722, 24);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 27);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(378, 598);
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
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(243, 598);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(82, 34);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(129, 598);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(82, 34);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
            this.txtbHoTen.Location = new System.Drawing.Point(103, 105);
            this.txtbHoTen.Name = "txtbHoTen";
            this.txtbHoTen.Size = new System.Drawing.Size(190, 22);
            this.txtbHoTen.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thế hệ";
            // 
            // combTheHe
            // 
            this.combTheHe.FormattingEnabled = true;
            this.combTheHe.Location = new System.Drawing.Point(232, 62);
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
            this.combMaTV.Location = new System.Drawing.Point(103, 62);
            this.combMaTV.Name = "combMaTV";
            this.combMaTV.Size = new System.Drawing.Size(64, 24);
            this.combMaTV.TabIndex = 11;
            // 
            // checkBGioiTinh
            // 
            this.checkBGioiTinh.AutoSize = true;
            this.checkBGioiTinh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBGioiTinh.Location = new System.Drawing.Point(401, 107);
            this.checkBGioiTinh.Name = "checkBGioiTinh";
            this.checkBGioiTinh.Size = new System.Drawing.Size(59, 21);
            this.checkBGioiTinh.TabIndex = 12;
            this.checkBGioiTinh.Text = "Nam";
            this.checkBGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh";
            // 
            // txtbNgaySinh
            // 
            this.txtbNgaySinh.Location = new System.Drawing.Point(103, 150);
            this.txtbNgaySinh.Name = "txtbNgaySinh";
            this.txtbNgaySinh.Size = new System.Drawing.Size(108, 22);
            this.txtbNgaySinh.TabIndex = 15;
            this.txtbNgaySinh.Click += new System.EventHandler(this.txtbNgaySinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Năm mất";
            // 
            // combNamMat
            // 
            this.combNamMat.FormattingEnabled = true;
            this.combNamMat.Location = new System.Drawing.Point(370, 150);
            this.combNamMat.Name = "combNamMat";
            this.combNamMat.Size = new System.Drawing.Size(90, 24);
            this.combNamMat.TabIndex = 17;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(232, 148);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(48, 26);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(472, 63);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // checkBThuocGP
            // 
            this.checkBThuocGP.AutoSize = true;
            this.checkBThuocGP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBThuocGP.Location = new System.Drawing.Point(328, 65);
            this.checkBThuocGP.Name = "checkBThuocGP";
            this.checkBThuocGP.Size = new System.Drawing.Size(132, 21);
            this.checkBThuocGP.TabIndex = 20;
            this.checkBThuocGP.Text = "Thuộc Gia phả?";
            this.checkBThuocGP.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quê quán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nghề nghiệp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên Vợ/Chồng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Họ tên Mẹ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Họ tên Cha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Họ tên Con";
            // 
            // txtBQueQuan
            // 
            this.txtBQueQuan.Location = new System.Drawing.Point(129, 194);
            this.txtBQueQuan.Name = "txtBQueQuan";
            this.txtBQueQuan.Size = new System.Drawing.Size(331, 22);
            this.txtBQueQuan.TabIndex = 27;
            // 
            // txtBNgheNghiep
            // 
            this.txtBNgheNghiep.Location = new System.Drawing.Point(129, 236);
            this.txtBNgheNghiep.Name = "txtBNgheNghiep";
            this.txtBNgheNghiep.Size = new System.Drawing.Size(331, 22);
            this.txtBNgheNghiep.TabIndex = 28;
            // 
            // txtBHotenCha
            // 
            this.txtBHotenCha.Location = new System.Drawing.Point(129, 283);
            this.txtBHotenCha.Name = "txtBHotenCha";
            this.txtBHotenCha.Size = new System.Drawing.Size(331, 22);
            this.txtBHotenCha.TabIndex = 29;
            // 
            // txtBHoTenMe
            // 
            this.txtBHoTenMe.Location = new System.Drawing.Point(129, 329);
            this.txtBHoTenMe.Name = "txtBHoTenMe";
            this.txtBHoTenMe.Size = new System.Drawing.Size(331, 22);
            this.txtBHoTenMe.TabIndex = 30;
            // 
            // txtBHoTenCon
            // 
            this.txtBHoTenCon.Location = new System.Drawing.Point(29, 450);
            this.txtBHoTenCon.Multiline = true;
            this.txtBHoTenCon.Name = "txtBHoTenCon";
            this.txtBHoTenCon.Size = new System.Drawing.Size(182, 139);
            this.txtBHoTenCon.TabIndex = 31;
            // 
            // txtBGhiChu
            // 
            this.txtBGhiChu.Location = new System.Drawing.Point(243, 450);
            this.txtBGhiChu.Multiline = true;
            this.txtBGhiChu.Name = "txtBGhiChu";
            this.txtBGhiChu.Size = new System.Drawing.Size(217, 139);
            this.txtBGhiChu.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ghi chú";
            // 
            // txtBHoTenVC
            // 
            this.txtBHoTenVC.Location = new System.Drawing.Point(129, 376);
            this.txtBHoTenVC.Name = "txtBHoTenVC";
            this.txtBHoTenVC.Size = new System.Drawing.Size(331, 22);
            this.txtBHoTenVC.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Windsor", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(75, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(313, 47);
            this.label13.TabIndex = 35;
            this.label13.Text = "Thông tin chi tiết  ";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 653);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBHoTenVC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBGhiChu);
            this.Controls.Add(this.txtBHoTenCon);
            this.Controls.Add(this.txtBHoTenMe);
            this.Controls.Add(this.txtBHotenCha);
            this.Controls.Add(this.txtBNgheNghiep);
            this.Controls.Add(this.txtBQueQuan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBThuocGP);
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
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
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
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
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
        private System.Windows.Forms.CheckBox checkBThuocGP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBQueQuan;
        private System.Windows.Forms.TextBox txtBNgheNghiep;
        private System.Windows.Forms.TextBox txtBHotenCha;
        private System.Windows.Forms.TextBox txtBHoTenMe;
        private System.Windows.Forms.TextBox txtBHoTenCon;
        private System.Windows.Forms.TextBox txtBGhiChu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBHoTenVC;
        private System.Windows.Forms.Label label13;
    }
}