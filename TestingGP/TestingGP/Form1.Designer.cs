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
            this.btCreateGiaPha = new System.Windows.Forms.Button();
            this.btMauGiaPha = new System.Windows.Forms.Button();
            this.lbGiaPha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCreateGiaPha
            // 
            this.btCreateGiaPha.Location = new System.Drawing.Point(118, 219);
            this.btCreateGiaPha.Name = "btCreateGiaPha";
            this.btCreateGiaPha.Size = new System.Drawing.Size(128, 43);
            this.btCreateGiaPha.TabIndex = 0;
            this.btCreateGiaPha.Text = "Tạo cây gia phả";
            this.btCreateGiaPha.UseVisualStyleBackColor = true;
            this.btCreateGiaPha.Click += new System.EventHandler(this.btCreateGiaPha_Click);
            // 
            // btMauGiaPha
            // 
            this.btMauGiaPha.Location = new System.Drawing.Point(282, 219);
            this.btMauGiaPha.Name = "btMauGiaPha";
            this.btMauGiaPha.Size = new System.Drawing.Size(144, 43);
            this.btMauGiaPha.TabIndex = 1;
            this.btMauGiaPha.Text = "Mẫu cây gia phả";
            this.btMauGiaPha.UseVisualStyleBackColor = true;
            this.btMauGiaPha.Click += new System.EventHandler(this.btMauGiaPha_Click);
            // 
            // lbGiaPha
            // 
            this.lbGiaPha.Font = new System.Drawing.Font("Victorian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaPha.Location = new System.Drawing.Point(141, 82);
            this.lbGiaPha.Name = "lbGiaPha";
            this.lbGiaPha.Size = new System.Drawing.Size(262, 134);
            this.lbGiaPha.TabIndex = 2;
            this.lbGiaPha.Text = "Gia Phả";
            this.lbGiaPha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 365);
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
    }
}

