namespace LTWD
{
    partial class frmNV
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
            this.lbMSNV = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbLuongCb = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtLuongCb = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMSNV
            // 
            this.lbMSNV.AutoSize = true;
            this.lbMSNV.Location = new System.Drawing.Point(74, 56);
            this.lbMSNV.Name = "lbMSNV";
            this.lbMSNV.Size = new System.Drawing.Size(46, 16);
            this.lbMSNV.TabIndex = 0;
            this.lbMSNV.Text = "MSNV";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(74, 112);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(50, 16);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "TenNV";
            // 
            // lbLuongCb
            // 
            this.lbLuongCb.AutoSize = true;
            this.lbLuongCb.Location = new System.Drawing.Point(74, 172);
            this.lbLuongCb.Name = "lbLuongCb";
            this.lbLuongCb.Size = new System.Drawing.Size(98, 16);
            this.lbLuongCb.TabIndex = 2;
            this.lbLuongCb.Text = "Luong Can Ban";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(229, 49);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(229, 22);
            this.txtMSNV.TabIndex = 3;
            // 
            // txtLuongCb
            // 
            this.txtLuongCb.Location = new System.Drawing.Point(229, 172);
            this.txtLuongCb.Name = "txtLuongCb";
            this.txtLuongCb.Size = new System.Drawing.Size(229, 22);
            this.txtLuongCb.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(229, 106);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(229, 22);
            this.txtTenNV.TabIndex = 5;
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(229, 237);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 6;
            this.btnDongy.Text = "DongY";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(383, 237);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 7;
            this.btnBoqua.Text = "Bo qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtLuongCb);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lbLuongCb);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbMSNV);
            this.Name = "frmNV";
            this.Text = "frmNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMSNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbLuongCb;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtLuongCb;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnBoqua;
    }
}