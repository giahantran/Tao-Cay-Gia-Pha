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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Thehe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuocgiapha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nammat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vochong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thehe,
            this.ID,
            this.Thuocgiapha,
            this.Hoten,
            this.Gioitinh,
            this.Namsinh,
            this.Nammat,
            this.Noisinh,
            this.Nghenghiep,
            this.Cha,
            this.Me,
            this.Vochong,
            this.Con});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // Thehe
            // 
            this.Thehe.DataPropertyName = "Thế hệ";
            this.Thehe.HeaderText = "Thế hệ";
            this.Thehe.Name = "Thehe";
            this.Thehe.Width = 66;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Thuocgiapha
            // 
            this.Thuocgiapha.DataPropertyName = "Thuộc Gia Phả";
            this.Thuocgiapha.HeaderText = "Thuộc gia phả";
            this.Thuocgiapha.Name = "Thuocgiapha";
            this.Thuocgiapha.Width = 101;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Họ Tên";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 64;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Giới tính";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 72;
            // 
            // Namsinh
            // 
            this.Namsinh.DataPropertyName = "Năm sinh";
            this.Namsinh.HeaderText = "Năm sinh";
            this.Namsinh.Name = "Namsinh";
            this.Namsinh.Width = 76;
            // 
            // Nammat
            // 
            this.Nammat.DataPropertyName = "Năm mất";
            this.Nammat.HeaderText = "Năm mất";
            this.Nammat.Name = "Nammat";
            this.Nammat.Width = 74;
            // 
            // Noisinh
            // 
            this.Noisinh.DataPropertyName = "Nơi sinh";
            this.Noisinh.HeaderText = "Nơi sinh";
            this.Noisinh.Name = "Noisinh";
            this.Noisinh.Width = 70;
            // 
            // Nghenghiep
            // 
            this.Nghenghiep.DataPropertyName = "Nghề nghiệp";
            this.Nghenghiep.HeaderText = "Nghề nghiệp";
            this.Nghenghiep.Name = "Nghenghiep";
            this.Nghenghiep.Width = 93;
            // 
            // Cha
            // 
            this.Cha.DataPropertyName = "Cha";
            this.Cha.HeaderText = "Cha";
            this.Cha.Name = "Cha";
            this.Cha.Width = 51;
            // 
            // Me
            // 
            this.Me.DataPropertyName = "Mẹ";
            this.Me.HeaderText = "Mẹ";
            this.Me.Name = "Me";
            this.Me.Width = 47;
            // 
            // Vochong
            // 
            this.Vochong.DataPropertyName = "Vợ(Chồng)";
            this.Vochong.HeaderText = "Vợ(Chồng)";
            this.Vochong.Name = "Vochong";
            this.Vochong.Width = 82;
            // 
            // Con
            // 
            this.Con.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Con.DataPropertyName = "Con";
            this.Con.HeaderText = "Con";
            this.Con.Name = "Con";
            this.Con.Width = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            this.button1.Location = new System.Drawing.Point(249, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 476);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Thehe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuocgiapha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nammat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Me;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vochong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}