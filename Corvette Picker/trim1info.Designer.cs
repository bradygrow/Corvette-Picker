namespace Corvette_Picker
{
    partial class Trim1InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trim1InfoForm));
            this.lbltrim1 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbltrim1infotrim1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltrim1
            // 
            this.lbltrim1.AutoSize = true;
            this.lbltrim1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbltrim1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrim1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltrim1.Location = new System.Drawing.Point(14, 82);
            this.lbltrim1.Name = "lbltrim1";
            this.lbltrim1.Size = new System.Drawing.Size(300, 592);
            this.lbltrim1.TabIndex = 0;
            this.lbltrim1.Text = resources.GetString("lbltrim1.Text");
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.SystemColors.Menu;
            this.lbltitle.Font = new System.Drawing.Font("TechnicLite", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitle.Location = new System.Drawing.Point(0, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(323, 26);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "2020 Corvette Customizer";
            // 
            // lbltrim1infotrim1
            // 
            this.lbltrim1infotrim1.AutoSize = true;
            this.lbltrim1infotrim1.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrim1infotrim1.Location = new System.Drawing.Point(51, 51);
            this.lbltrim1infotrim1.Name = "lbltrim1infotrim1";
            this.lbltrim1infotrim1.Size = new System.Drawing.Size(215, 18);
            this.lbltrim1infotrim1.TabIndex = 3;
            this.lbltrim1infotrim1.Text = "1LT Trim Line includes:";
            // 
            // Trim1InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 683);
            this.Controls.Add(this.lbltrim1infotrim1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lbltrim1);
            this.Location = new System.Drawing.Point(1350, 150);
            this.Name = "Trim1InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbltrim1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbltrim1infotrim1;
    }
}