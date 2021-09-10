namespace WindowsFormsApplication1
{
    partial class AddNewStation
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
            this.txtlongitude = new System.Windows.Forms.TextBox();
            this.txtlatitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlongitude
            // 
            this.txtlongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlongitude.Location = new System.Drawing.Point(175, 106);
            this.txtlongitude.Margin = new System.Windows.Forms.Padding(5);
            this.txtlongitude.Name = "txtlongitude";
            this.txtlongitude.Size = new System.Drawing.Size(164, 24);
            this.txtlongitude.TabIndex = 28;
            // 
            // txtlatitude
            // 
            this.txtlatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlatitude.Location = new System.Drawing.Point(175, 67);
            this.txtlatitude.Margin = new System.Windows.Forms.Padding(5);
            this.txtlatitude.Name = "txtlatitude";
            this.txtlatitude.Size = new System.Drawing.Size(164, 24);
            this.txtlatitude.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Longitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Latitude";
            // 
            // txtsname
            // 
            this.txtsname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsname.Location = new System.Drawing.Point(175, 28);
            this.txtsname.Margin = new System.Windows.Forms.Padding(5);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(164, 24);
            this.txtsname.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Station Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(374, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlongitude);
            this.Controls.Add(this.txtlatitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddNewStation";
            this.Text = "Add New Station";
            this.Load += new System.EventHandler(this.AddNewStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlongitude;
        private System.Windows.Forms.TextBox txtlatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}