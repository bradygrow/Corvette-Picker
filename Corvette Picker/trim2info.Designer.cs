namespace Corvette_Picker
{
    partial class trim2info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trim2info));
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbltrim1infotrim1 = new System.Windows.Forms.Label();
            this.lblextratriminfo = new System.Windows.Forms.Label();
            this.lbltrim1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.SystemColors.Menu;
            this.lbltitle.Font = new System.Drawing.Font("TechnicLite", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitle.Location = new System.Drawing.Point(2, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(323, 26);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "2020 Corvette Customizer";
            // 
            // lbltrim1infotrim1
            // 
            this.lbltrim1infotrim1.AutoSize = true;
            this.lbltrim1infotrim1.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrim1infotrim1.Location = new System.Drawing.Point(52, 48);
            this.lbltrim1infotrim1.Name = "lbltrim1infotrim1";
            this.lbltrim1infotrim1.Size = new System.Drawing.Size(215, 18);
            this.lbltrim1infotrim1.TabIndex = 4;
            this.lbltrim1infotrim1.Text = "2LT Trim Line includes:";
            this.lbltrim1infotrim1.Click += new System.EventHandler(this.lbltrim1infotrim1_Click);
            // 
            // lblextratriminfo
            // 
            this.lblextratriminfo.AutoSize = true;
            this.lblextratriminfo.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblextratriminfo.Location = new System.Drawing.Point(52, 76);
            this.lblextratriminfo.Name = "lblextratriminfo";
            this.lblextratriminfo.Size = new System.Drawing.Size(233, 18);
            this.lblextratriminfo.TabIndex = 5;
            this.lblextratriminfo.Text = "Everything in 1LT Trim, +";
            // 
            // lbltrim1
            // 
            this.lbltrim1.AutoSize = true;
            this.lbltrim1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbltrim1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrim1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltrim1.Location = new System.Drawing.Point(9, 104);
            this.lbltrim1.Name = "lbltrim1";
            this.lbltrim1.Size = new System.Drawing.Size(305, 560);
            this.lbltrim1.TabIndex = 6;
            this.lbltrim1.Text = resources.GetString("lbltrim1.Text");
            // 
            // trim2info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 669);
            this.Controls.Add(this.lbltrim1);
            this.Controls.Add(this.lblextratriminfo);
            this.Controls.Add(this.lbltrim1infotrim1);
            this.Controls.Add(this.lbltitle);
            this.Location = new System.Drawing.Point(1350, 150);
            this.Name = "trim2info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbltrim1infotrim1;
        private System.Windows.Forms.Label lblextratriminfo;
        public System.Windows.Forms.Label lbltrim1;
    }
}