namespace WindowsFormsApplication1
{
    partial class BookTicket
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
            this.Find = new System.Windows.Forms.Button();
            this.cmbdes = new System.Windows.Forms.ComboBox();
            this.cmbsrc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcharges = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtadults = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchilds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(125, 112);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(90, 35);
            this.Find.TabIndex = 9;
            this.Find.Text = "Charges";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // cmbdes
            // 
            this.cmbdes.FormattingEnabled = true;
            this.cmbdes.Items.AddRange(new object[] {
            "Amarawati",
            "Gondia",
            "Nagpur",
            "Chandrapur",
            "Pune",
            "Bhandara",
            "Tiroda",
            "Tumsar",
            "Mumbai"});
            this.cmbdes.Location = new System.Drawing.Point(125, 44);
            this.cmbdes.Name = "cmbdes";
            this.cmbdes.Size = new System.Drawing.Size(163, 24);
            this.cmbdes.TabIndex = 8;
            // 
            // cmbsrc
            // 
            this.cmbsrc.FormattingEnabled = true;
            this.cmbsrc.Items.AddRange(new object[] {
            "Amarawati",
            "Gondia",
            "Nagpur",
            "Chandrapur",
            "Pune",
            "Bhandara",
            "Tiroda",
            "Tumsar",
            "Mumbai"});
            this.cmbsrc.Location = new System.Drawing.Point(125, 14);
            this.cmbsrc.Name = "cmbsrc";
            this.cmbsrc.Size = new System.Drawing.Size(163, 24);
            this.cmbsrc.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Charges";
            // 
            // txtcharges
            // 
            this.txtcharges.Location = new System.Drawing.Point(125, 74);
            this.txtcharges.Name = "txtcharges";
            this.txtcharges.ReadOnly = true;
            this.txtcharges.Size = new System.Drawing.Size(163, 22);
            this.txtcharges.TabIndex = 11;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(410, 304);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 6;
            this.lineShape1.X2 = 355;
            this.lineShape1.Y1 = 155;
            this.lineShape1.Y2 = 155;
            // 
            // txtadults
            // 
            this.txtadults.Location = new System.Drawing.Point(155, 175);
            this.txtadults.Name = "txtadults";
            this.txtadults.Size = new System.Drawing.Size(52, 22);
            this.txtadults.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Adults";
            // 
            // txtchilds
            // 
            this.txtchilds.Location = new System.Drawing.Point(155, 215);
            this.txtchilds.Name = "txtchilds";
            this.txtchilds.Size = new System.Drawing.Size(52, 22);
            this.txtchilds.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of childs";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(155, 251);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(52, 22);
            this.txttotal.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Charges";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(266, 181);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(90, 27);
            this.BtnConfirm.TabIndex = 19;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTicket
            // 
            this.BtnTicket.Location = new System.Drawing.Point(244, 235);
            this.BtnTicket.Name = "BtnTicket";
            this.BtnTicket.Size = new System.Drawing.Size(134, 27);
            this.BtnTicket.TabIndex = 20;
            this.BtnTicket.Text = "Confirm Ticket";
            this.BtnTicket.UseVisualStyleBackColor = true;
            this.BtnTicket.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 304);
            this.Controls.Add(this.BtnTicket);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtchilds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtadults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcharges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.cmbdes);
            this.Controls.Add(this.cmbsrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookTicket";
            this.Text = "Book Ticket";
            this.Load += new System.EventHandler(this.BookTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.ComboBox cmbdes;
        private System.Windows.Forms.ComboBox cmbsrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcharges;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtadults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchilds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnTicket;
    }
}