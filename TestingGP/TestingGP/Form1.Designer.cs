namespace TestingGP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCreateGiaPha = new System.Windows.Forms.Button();
            this.btMauGiaPha = new System.Windows.Forms.Button();
            this.lbGiaPha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCreateGiaPha
            // 
            this.btCreateGiaPha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateGiaPha.BackColor = System.Drawing.Color.MistyRose;
            this.btCreateGiaPha.Font = new System.Drawing.Font("UVN Bach Tuyet", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateGiaPha.Location = new System.Drawing.Point(460, 465);
            this.btCreateGiaPha.Name = "btCreateGiaPha";
            this.btCreateGiaPha.Size = new System.Drawing.Size(155, 60);
            this.btCreateGiaPha.TabIndex = 0;
            this.btCreateGiaPha.Text = "Tạo cây gia phả";
            this.btCreateGiaPha.UseVisualStyleBackColor = false;
            this.btCreateGiaPha.Click += new System.EventHandler(this.btCreateGiaPha_Click);
            // 
            // btMauGiaPha
            // 
            this.btMauGiaPha.AllowDrop = true;
            this.btMauGiaPha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btMauGiaPha.BackColor = System.Drawing.Color.MistyRose;
            this.btMauGiaPha.Font = new System.Drawing.Font("UVN Bach Tuyet", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMauGiaPha.Location = new System.Drawing.Point(649, 465);
            this.btMauGiaPha.Name = "btMauGiaPha";
            this.btMauGiaPha.Size = new System.Drawing.Size(164, 60);
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
            this.lbGiaPha.Location = new System.Drawing.Point(215, 208);
            this.lbGiaPha.Name = "lbGiaPha";
            this.lbGiaPha.Size = new System.Drawing.Size(564, 134);
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
            this.label1.Location = new System.Drawing.Point(128, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 90);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chương trình quản lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGiaPha);
            this.Controls.Add(this.btMauGiaPha);
            this.Controls.Add(this.btCreateGiaPha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreateGiaPha;
        private System.Windows.Forms.Button btMauGiaPha;
        private System.Windows.Forms.Label lbGiaPha;
        private System.Windows.Forms.Label label1;
    }
}

