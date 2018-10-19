namespace TestingGP
{
    partial class Create
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
            this.combMenu = new System.Windows.Forms.ComboBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // combMenu
            // 
            this.combMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMenu.FormattingEnabled = true;
            this.combMenu.Location = new System.Drawing.Point(79, 12);
            this.combMenu.Name = "combMenu";
            this.combMenu.Size = new System.Drawing.Size(240, 24);
            this.combMenu.TabIndex = 0;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Location = new System.Drawing.Point(30, 15);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(43, 17);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.drawingPanel);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Location = new System.Drawing.Point(33, 46);
            this.panel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1191, 547);
            this.panel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset Tree";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.drawingPanel.Location = new System.Drawing.Point(6, 4);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(824, 540);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(843, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1239, 606);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.combMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create";
            this.Text = "Create";
            this.Click += new System.EventHandler(this.combMenu_Click);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combMenu;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel drawingPanel;
    }
}