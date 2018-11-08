namespace TestingGP
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btCreateGiaPha = new System.Windows.Forms.Button();
            this.btMauGiaPha = new System.Windows.Forms.Button();
            this.lbGiaPha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTapTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCreateGiaPha
            // 
            this.btCreateGiaPha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateGiaPha.BackColor = System.Drawing.Color.DarkCyan;
            this.btCreateGiaPha.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateGiaPha.ForeColor = System.Drawing.SystemColors.Window;
            this.btCreateGiaPha.Location = new System.Drawing.Point(457, 496);
            this.btCreateGiaPha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCreateGiaPha.Name = "btCreateGiaPha";
            this.btCreateGiaPha.Size = new System.Drawing.Size(174, 71);
            this.btCreateGiaPha.TabIndex = 0;
            this.btCreateGiaPha.Text = "Tạo cây gia phả";
            this.btCreateGiaPha.UseVisualStyleBackColor = false;
            this.btCreateGiaPha.Click += new System.EventHandler(this.btCreateGiaPha_Click);
            // 
            // btMauGiaPha
            // 
            this.btMauGiaPha.AllowDrop = true;
            this.btMauGiaPha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btMauGiaPha.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMauGiaPha.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMauGiaPha.ForeColor = System.Drawing.SystemColors.Window;
            this.btMauGiaPha.Location = new System.Drawing.Point(669, 496);
            this.btMauGiaPha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMauGiaPha.Name = "btMauGiaPha";
            this.btMauGiaPha.Size = new System.Drawing.Size(184, 71);
            this.btMauGiaPha.TabIndex = 1;
            this.btMauGiaPha.Text = "Mẫu cây gia phả";
            this.btMauGiaPha.UseVisualStyleBackColor = false;
            this.btMauGiaPha.Click += new System.EventHandler(this.btMauGiaPha_Click);
            // 
            // lbGiaPha
            // 
            this.lbGiaPha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGiaPha.BackColor = System.Drawing.Color.Transparent;
            this.lbGiaPha.Font = new System.Drawing.Font("UVN Cat Bien", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaPha.Location = new System.Drawing.Point(293, 211);
            this.lbGiaPha.Name = "lbGiaPha";
            this.lbGiaPha.Size = new System.Drawing.Size(573, 159);
            this.lbGiaPha.TabIndex = 2;
            this.lbGiaPha.Text = "Cây Gia phả";
            this.lbGiaPha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("UVN Bach Tuyet", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 107);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chương trình quản lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-25, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(457, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(475, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTapTin,
            this.mnuDanhMuc,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTapTin
            // 
            this.mnuTapTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuTapTin.Name = "mnuTapTin";
            this.mnuTapTin.Size = new System.Drawing.Size(78, 26);
            this.mnuTapTin.Text = "Tập tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(131, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(100, 26);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(178, 26);
            this.mnuHuongDan.Text = "Hướng dẫn ";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(91, 26);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 628);
            this.Controls.Add(this.btCreateGiaPha);
            this.Controls.Add(this.btMauGiaPha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGiaPha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = "Chương trình quản lí cây gia phả";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreateGiaPha;
        private System.Windows.Forms.Button btMauGiaPha;
        private System.Windows.Forms.Label lbGiaPha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTapTin;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
    }
}

