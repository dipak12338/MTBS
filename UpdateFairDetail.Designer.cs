namespace WindowsFormsApplication1
{
    partial class UpdateFairDetail
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
            this.txtmc = new System.Windows.Forms.TextBox();
            this.txtcpa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmc
            // 
            this.txtmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmc.Location = new System.Drawing.Point(164, 106);
            this.txtmc.Margin = new System.Windows.Forms.Padding(5);
            this.txtmc.Name = "txtmc";
            this.txtmc.Size = new System.Drawing.Size(164, 22);
            this.txtmc.TabIndex = 34;
            // 
            // txtcpa
            // 
            this.txtcpa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcpa.Location = new System.Drawing.Point(164, 70);
            this.txtcpa.Margin = new System.Windows.Forms.Padding(5);
            this.txtcpa.Name = "txtcpa";
            this.txtcpa.Size = new System.Drawing.Size(164, 22);
            this.txtcpa.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Minimum Charge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Charge/Unit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtfu
            // 
            this.txtfu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfu.Location = new System.Drawing.Point(164, 34);
            this.txtfu.Margin = new System.Windows.Forms.Padding(5);
            this.txtfu.Name = "txtfu";
            this.txtfu.Size = new System.Drawing.Size(164, 22);
            this.txtfu.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fair unit";
            // 
            // txtmu
            // 
            this.txtmu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmu.Location = new System.Drawing.Point(164, 142);
            this.txtmu.Margin = new System.Windows.Forms.Padding(5);
            this.txtmu.Name = "txtmu";
            this.txtmu.Size = new System.Drawing.Size(164, 22);
            this.txtmu.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Minimum unit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateFairDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(401, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmc);
            this.Controls.Add(this.txtcpa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateFairDetail";
            this.Text = "Update Fair Detail";
            this.Load += new System.EventHandler(this.UpdateFairDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmc;
        private System.Windows.Forms.TextBox txtcpa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}