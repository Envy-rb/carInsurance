namespace kursvaya.appForm
{
    partial class certificateForm
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
            this.MarkLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.DrivingExpLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.FIOLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.MarkLabel.Location = new System.Drawing.Point(119, 70);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(35, 13);
            this.MarkLabel.TabIndex = 0;
            this.MarkLabel.Text = "label1";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberLabel.Location = new System.Drawing.Point(117, 99);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(35, 13);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "label1";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.FIOLabel.Location = new System.Drawing.Point(117, 158);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(35, 13);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "label1";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgeLabel.Location = new System.Drawing.Point(119, 192);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(35, 13);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "label1";
            // 
            // DrivingExpLabel
            // 
            this.DrivingExpLabel.AutoSize = true;
            this.DrivingExpLabel.BackColor = System.Drawing.Color.Transparent;
            this.DrivingExpLabel.Location = new System.Drawing.Point(152, 221);
            this.DrivingExpLabel.Name = "DrivingExpLabel";
            this.DrivingExpLabel.Size = new System.Drawing.Size(35, 13);
            this.DrivingExpLabel.TabIndex = 2;
            this.DrivingExpLabel.Text = "label1";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPriceLabel.Location = new System.Drawing.Point(170, 276);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(35, 13);
            this.TotalPriceLabel.TabIndex = 2;
            this.TotalPriceLabel.Text = "label1";
            // 
            // FIOLabel1
            // 
            this.FIOLabel1.AutoSize = true;
            this.FIOLabel1.BackColor = System.Drawing.Color.Transparent;
            this.FIOLabel1.Location = new System.Drawing.Point(45, 444);
            this.FIOLabel1.Name = "FIOLabel1";
            this.FIOLabel1.Size = new System.Drawing.Size(35, 13);
            this.FIOLabel1.TabIndex = 2;
            this.FIOLabel1.Text = "label1";
            // 
            // certificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursvaya.Properties.Resources.certificate1;
            this.ClientSize = new System.Drawing.Size(689, 529);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.DrivingExpLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.FIOLabel1);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.MarkLabel);
            this.Name = "certificateForm";
            this.Text = "certificateForm";
            this.Load += new System.EventHandler(this.certificateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label DrivingExpLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label FIOLabel1;
    }
}