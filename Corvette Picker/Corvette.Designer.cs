namespace Corvette_Picker
{
    partial class Corvette
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
            this.pbcar = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.gbtopupdown = new System.Windows.Forms.GroupBox();
            this.rbdownclosed = new System.Windows.Forms.RadioButton();
            this.rbtopopen = new System.Windows.Forms.RadioButton();
            this.gbcolor = new System.Windows.Forms.GroupBox();
            this.lblredprice = new System.Windows.Forms.Label();
            this.rbred = new System.Windows.Forms.RadioButton();
            this.rbwhite = new System.Windows.Forms.RadioButton();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lbltrim = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltrimprice = new System.Windows.Forms.Label();
            this.rbtrim2 = new System.Windows.Forms.RadioButton();
            this.rbtrim1 = new System.Windows.Forms.RadioButton();
            this.lblAO = new System.Windows.Forms.Label();
            this.gbothers = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbfloormats = new System.Windows.Forms.CheckBox();
            this.lbllogo = new System.Windows.Forms.Label();
            this.cblogo = new System.Windows.Forms.CheckBox();
            this.lblspoiler = new System.Windows.Forms.Label();
            this.cbspoiler = new System.Windows.Forms.CheckBox();
            this.lblFLS = new System.Windows.Forms.Label();
            this.cbFLS = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lbltopprice = new System.Windows.Forms.Label();
            this.lblcopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbcar)).BeginInit();
            this.gbtopupdown.SuspendLayout();
            this.gbcolor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbothers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbcar
            // 
            this.pbcar.Location = new System.Drawing.Point(395, 9);
            this.pbcar.Name = "pbcar";
            this.pbcar.Size = new System.Drawing.Size(800, 410);
            this.pbcar.TabIndex = 0;
            this.pbcar.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.SystemColors.Menu;
            this.lbltitle.Font = new System.Drawing.Font("TechnicLite", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitle.Location = new System.Drawing.Point(3, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(386, 31);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "2020 Corvette Customizer";
            // 
            // gbtopupdown
            // 
            this.gbtopupdown.Controls.Add(this.rbdownclosed);
            this.gbtopupdown.Controls.Add(this.rbtopopen);
            this.gbtopupdown.Location = new System.Drawing.Point(420, 488);
            this.gbtopupdown.Name = "gbtopupdown";
            this.gbtopupdown.Size = new System.Drawing.Size(103, 73);
            this.gbtopupdown.TabIndex = 2;
            this.gbtopupdown.TabStop = false;
            // 
            // rbdownclosed
            // 
            this.rbdownclosed.AutoSize = true;
            this.rbdownclosed.Location = new System.Drawing.Point(16, 42);
            this.rbdownclosed.Name = "rbdownclosed";
            this.rbdownclosed.Size = new System.Drawing.Size(75, 17);
            this.rbdownclosed.TabIndex = 1;
            this.rbdownclosed.TabStop = true;
            this.rbdownclosed.Text = "Top Down";
            this.rbdownclosed.UseVisualStyleBackColor = true;
            this.rbdownclosed.CheckedChanged += new System.EventHandler(this.rbdown_CheckedChanged);
            // 
            // rbtopopen
            // 
            this.rbtopopen.AutoSize = true;
            this.rbtopopen.Location = new System.Drawing.Point(16, 19);
            this.rbtopopen.Name = "rbtopopen";
            this.rbtopopen.Size = new System.Drawing.Size(61, 17);
            this.rbtopopen.TabIndex = 0;
            this.rbtopopen.TabStop = true;
            this.rbtopopen.Text = "Top Up";
            this.rbtopopen.UseVisualStyleBackColor = true;
            this.rbtopopen.CheckedChanged += new System.EventHandler(this.rbtop_CheckedChanged);
            // 
            // gbcolor
            // 
            this.gbcolor.Controls.Add(this.lblredprice);
            this.gbcolor.Controls.Add(this.rbred);
            this.gbcolor.Controls.Add(this.rbwhite);
            this.gbcolor.Location = new System.Drawing.Point(69, 146);
            this.gbcolor.Name = "gbcolor";
            this.gbcolor.Size = new System.Drawing.Size(236, 63);
            this.gbcolor.TabIndex = 3;
            this.gbcolor.TabStop = false;
            // 
            // lblredprice
            // 
            this.lblredprice.AutoSize = true;
            this.lblredprice.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblredprice.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblredprice.ForeColor = System.Drawing.Color.IndianRed;
            this.lblredprice.Location = new System.Drawing.Point(156, 39);
            this.lblredprice.Name = "lblredprice";
            this.lblredprice.Size = new System.Drawing.Size(46, 14);
            this.lblredprice.TabIndex = 2;
            this.lblredprice.Text = "+$995";
            this.lblredprice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbred
            // 
            this.rbred.AutoSize = true;
            this.rbred.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.rbred.Location = new System.Drawing.Point(116, 19);
            this.rbred.Name = "rbred";
            this.rbred.Size = new System.Drawing.Size(117, 19);
            this.rbred.TabIndex = 1;
            this.rbred.TabStop = true;
            this.rbred.Text = "Long Beach Red";
            this.rbred.UseVisualStyleBackColor = true;
            this.rbred.CheckedChanged += new System.EventHandler(this.rbred_CheckedChanged);
            // 
            // rbwhite
            // 
            this.rbwhite.AutoSize = true;
            this.rbwhite.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbwhite.Location = new System.Drawing.Point(16, 19);
            this.rbwhite.Name = "rbwhite";
            this.rbwhite.Size = new System.Drawing.Size(93, 19);
            this.rbwhite.TabIndex = 0;
            this.rbwhite.TabStop = true;
            this.rbwhite.Text = "Arctic White";
            this.rbwhite.UseVisualStyleBackColor = true;
            this.rbwhite.CheckedChanged += new System.EventHandler(this.rbwhite_CheckedChanged);
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolor.Location = new System.Drawing.Point(81, 121);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(197, 22);
            this.lblcolor.TabIndex = 4;
            this.lblcolor.Text = "Choose Your Color";
            // 
            // lbltrim
            // 
            this.lbltrim.AutoSize = true;
            this.lbltrim.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbltrim.Location = new System.Drawing.Point(88, 221);
            this.lbltrim.Name = "lbltrim";
            this.lbltrim.Size = new System.Drawing.Size(186, 22);
            this.lbltrim.TabIndex = 5;
            this.lbltrim.Text = "Choose Your Trim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltrimprice);
            this.groupBox1.Controls.Add(this.rbtrim2);
            this.groupBox1.Controls.Add(this.rbtrim1);
            this.groupBox1.Location = new System.Drawing.Point(69, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbltrimprice
            // 
            this.lbltrimprice.AutoSize = true;
            this.lbltrimprice.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbltrimprice.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrimprice.ForeColor = System.Drawing.Color.IndianRed;
            this.lbltrimprice.Location = new System.Drawing.Point(144, 42);
            this.lbltrimprice.Name = "lbltrimprice";
            this.lbltrimprice.Size = new System.Drawing.Size(58, 14);
            this.lbltrimprice.TabIndex = 9;
            this.lbltrimprice.Text = "+$6,800";
            this.lbltrimprice.Click += new System.EventHandler(this.lbltrimprice_Click);
            // 
            // rbtrim2
            // 
            this.rbtrim2.AutoSize = true;
            this.rbtrim2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.rbtrim2.Location = new System.Drawing.Point(116, 19);
            this.rbtrim2.Name = "rbtrim2";
            this.rbtrim2.Size = new System.Drawing.Size(75, 19);
            this.rbtrim2.TabIndex = 1;
            this.rbtrim2.TabStop = true;
            this.rbtrim2.Text = "2LT Trim";
            this.rbtrim2.UseVisualStyleBackColor = true;
            this.rbtrim2.CheckedChanged += new System.EventHandler(this.rbtrim2_CheckedChanged);
            this.rbtrim2.Click += new System.EventHandler(this.rbtrim2_Click);
            // 
            // rbtrim1
            // 
            this.rbtrim1.AutoSize = true;
            this.rbtrim1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.rbtrim1.Location = new System.Drawing.Point(16, 20);
            this.rbtrim1.Name = "rbtrim1";
            this.rbtrim1.Size = new System.Drawing.Size(75, 19);
            this.rbtrim1.TabIndex = 0;
            this.rbtrim1.TabStop = true;
            this.rbtrim1.Text = "1LT Trim";
            this.rbtrim1.UseVisualStyleBackColor = true;
            this.rbtrim1.CheckedChanged += new System.EventHandler(this.rbtrim1_CheckedChanged);
            this.rbtrim1.Click += new System.EventHandler(this.rbtrim1_Click);
            // 
            // lblAO
            // 
            this.lblAO.AutoSize = true;
            this.lblAO.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAO.Location = new System.Drawing.Point(86, 327);
            this.lblAO.Name = "lblAO";
            this.lblAO.Size = new System.Drawing.Size(208, 22);
            this.lblAO.TabIndex = 7;
            this.lblAO.Text = "Additional Options";
            // 
            // gbothers
            // 
            this.gbothers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbothers.Controls.Add(this.label2);
            this.gbothers.Controls.Add(this.cbfloormats);
            this.gbothers.Controls.Add(this.lbllogo);
            this.gbothers.Controls.Add(this.cblogo);
            this.gbothers.Controls.Add(this.lblspoiler);
            this.gbothers.Controls.Add(this.cbspoiler);
            this.gbothers.Controls.Add(this.lblFLS);
            this.gbothers.Controls.Add(this.cbFLS);
            this.gbothers.Location = new System.Drawing.Point(69, 352);
            this.gbothers.Name = "gbothers";
            this.gbothers.Size = new System.Drawing.Size(233, 260);
            this.gbothers.TabIndex = 8;
            this.gbothers.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(90, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "+$235";
            // 
            // cbfloormats
            // 
            this.cbfloormats.AutoSize = true;
            this.cbfloormats.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.cbfloormats.Location = new System.Drawing.Point(18, 210);
            this.cbfloormats.Name = "cbfloormats";
            this.cbfloormats.Size = new System.Drawing.Size(196, 19);
            this.cbfloormats.TabIndex = 10;
            this.cbfloormats.Text = "Premium Carpeted Floor Mats";
            this.cbfloormats.UseVisualStyleBackColor = true;
            this.cbfloormats.CheckedChanged += new System.EventHandler(this.cbfloormats_CheckedChanged);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbllogo.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.IndianRed;
            this.lbllogo.Location = new System.Drawing.Point(90, 170);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(46, 14);
            this.lbllogo.TabIndex = 13;
            this.lbllogo.Text = "+$345";
            // 
            // cblogo
            // 
            this.cblogo.AutoSize = true;
            this.cblogo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.cblogo.Location = new System.Drawing.Point(16, 148);
            this.cblogo.Name = "cblogo";
            this.cblogo.Size = new System.Drawing.Size(206, 19);
            this.cblogo.TabIndex = 10;
            this.cblogo.Text = "Illuminated Door plates w/ logo";
            this.cblogo.UseVisualStyleBackColor = true;
            this.cblogo.CheckedChanged += new System.EventHandler(this.cblogo_CheckedChanged);
            // 
            // lblspoiler
            // 
            this.lblspoiler.AutoSize = true;
            this.lblspoiler.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblspoiler.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspoiler.ForeColor = System.Drawing.Color.IndianRed;
            this.lblspoiler.Location = new System.Drawing.Point(78, 112);
            this.lblspoiler.Name = "lblspoiler";
            this.lblspoiler.Size = new System.Drawing.Size(58, 14);
            this.lblspoiler.TabIndex = 12;
            this.lblspoiler.Text = "+$1,150";
            // 
            // cbspoiler
            // 
            this.cbspoiler.AutoSize = true;
            this.cbspoiler.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.cbspoiler.Location = new System.Drawing.Point(16, 90);
            this.cbspoiler.Name = "cbspoiler";
            this.cbspoiler.Size = new System.Drawing.Size(158, 19);
            this.cbspoiler.TabIndex = 11;
            this.cbspoiler.Text = "High Rear Wing Spoiler";
            this.cbspoiler.UseVisualStyleBackColor = true;
            this.cbspoiler.CheckedChanged += new System.EventHandler(this.cbspoiler_CheckedChanged);
            this.cbspoiler.CheckStateChanged += new System.EventHandler(this.cbspoiler_CheckStateChanged);
            // 
            // lblFLS
            // 
            this.lblFLS.AutoSize = true;
            this.lblFLS.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblFLS.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLS.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFLS.Location = new System.Drawing.Point(78, 51);
            this.lblFLS.Name = "lblFLS";
            this.lblFLS.Size = new System.Drawing.Size(58, 14);
            this.lblFLS.TabIndex = 10;
            this.lblFLS.Text = "+$1,495";
            // 
            // cbFLS
            // 
            this.cbFLS.AutoSize = true;
            this.cbFLS.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.cbFLS.Location = new System.Drawing.Point(18, 29);
            this.cbFLS.Name = "cbFLS";
            this.cbFLS.Size = new System.Drawing.Size(195, 19);
            this.cbFLS.TabIndex = 9;
            this.cbFLS.Text = "Front Lift System, w/ Memory";
            this.cbFLS.UseVisualStyleBackColor = true;
            this.cbFLS.CheckedChanged += new System.EventHandler(this.cbFLS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Base Price:  $67,495.  Comes in Arctic White + 1LT Trim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(391, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alternate View";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.SystemColors.Menu;
            this.lblprice.Font = new System.Drawing.Font("Sitka Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblprice.Location = new System.Drawing.Point(683, 488);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(217, 92);
            this.lblprice.TabIndex = 11;
            this.lblprice.Text = "price ";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // lbltopprice
            // 
            this.lbltopprice.AutoSize = true;
            this.lbltopprice.BackColor = System.Drawing.SystemColors.Menu;
            this.lbltopprice.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopprice.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltopprice.Location = new System.Drawing.Point(681, 446);
            this.lbltopprice.Name = "lbltopprice";
            this.lbltopprice.Size = new System.Drawing.Size(285, 31);
            this.lbltopprice.TabIndex = 12;
            this.lbltopprice.Text = "Your Grand Total is:";
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(1024, 618);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(153, 14);
            this.lblcopyright.TabIndex = 13;
            this.lblcopyright.Text = "All images copyright of Chevrolet";
            // 
            // Corvette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1201, 632);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.lbltopprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbothers);
            this.Controls.Add(this.lblAO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltrim);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.gbcolor);
            this.Controls.Add(this.gbtopupdown);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pbcar);
            this.Name = "Corvette";
            this.Text = "Corvette Picker Application";
            this.Load += new System.EventHandler(this.Corvette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcar)).EndInit();
            this.gbtopupdown.ResumeLayout(false);
            this.gbtopupdown.PerformLayout();
            this.gbcolor.ResumeLayout(false);
            this.gbcolor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbothers.ResumeLayout(false);
            this.gbothers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox gbtopupdown;
        private System.Windows.Forms.RadioButton rbtopopen;
        private System.Windows.Forms.RadioButton rbdownclosed;
        private System.Windows.Forms.GroupBox gbcolor;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.RadioButton rbred;
        private System.Windows.Forms.RadioButton rbwhite;
        private System.Windows.Forms.Label lbltrim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtrim2;
        private System.Windows.Forms.RadioButton rbtrim1;
        private System.Windows.Forms.Label lblredprice;
        private System.Windows.Forms.Label lbltrimprice;
        private System.Windows.Forms.Label lblAO;
        private System.Windows.Forms.GroupBox gbothers;
        private System.Windows.Forms.CheckBox cbFLS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFLS;
        private System.Windows.Forms.Label lblspoiler;
        private System.Windows.Forms.CheckBox cbspoiler;
        private System.Windows.Forms.CheckBox cblogo;
        private System.Windows.Forms.CheckBox cbfloormats;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbltopprice;
        private System.Windows.Forms.Label lblcopyright;
        public System.Windows.Forms.PictureBox pbcar;
    }
}

