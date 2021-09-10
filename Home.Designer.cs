namespace WindowsFormsApplication1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationForMetroCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargeMetrcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journeyHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.complaintoolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.tripMenuItem,
            this.hToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // complaintoolStripMenuItem
            // 
            this.complaintoolStripMenuItem.Name = "complaintoolStripMenuItem";
            this.complaintoolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.complaintoolStripMenuItem.Text = "Complaints";
            this.complaintoolStripMenuItem.Click += new System.EventHandler(this.complaintoolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem1.Text = "Search For Trains";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tripMenuItem
            // 
            this.tripMenuItem.Name = "tripMenuItem";
            this.tripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.tripMenuItem.Text = "Admin Login";
            this.tripMenuItem.Click += new System.EventHandler(this.tripMenuItem_Click);
            // 
            // hToolStripMenuItem1
            // 
            this.hToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationForMetroCardToolStripMenuItem,
            this.rechargeMetrcoToolStripMenuItem,
            this.viewBalanceToolStripMenuItem,
            this.journeyHistoryToolStripMenuItem});
            this.hToolStripMenuItem1.Name = "hToolStripMenuItem1";
            this.hToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.hToolStripMenuItem1.Text = "Metro Card";
            this.hToolStripMenuItem1.Click += new System.EventHandler(this.hToolStripMenuItem1_Click);
            // 
            // applicationForMetroCardToolStripMenuItem
            // 
            this.applicationForMetroCardToolStripMenuItem.Name = "applicationForMetroCardToolStripMenuItem";
            this.applicationForMetroCardToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.applicationForMetroCardToolStripMenuItem.Text = "Request For Card";
            this.applicationForMetroCardToolStripMenuItem.Click += new System.EventHandler(this.applicationForMetroCardToolStripMenuItem_Click);
            // 
            // rechargeMetrcoToolStripMenuItem
            // 
            this.rechargeMetrcoToolStripMenuItem.Name = "rechargeMetrcoToolStripMenuItem";
            this.rechargeMetrcoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rechargeMetrcoToolStripMenuItem.Text = "Recharge Card  ";
            this.rechargeMetrcoToolStripMenuItem.Click += new System.EventHandler(this.rechargeMetrcoToolStripMenuItem_Click);
            // 
            // viewBalanceToolStripMenuItem
            // 
            this.viewBalanceToolStripMenuItem.Name = "viewBalanceToolStripMenuItem";
            this.viewBalanceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewBalanceToolStripMenuItem.Text = "View Balance";
            this.viewBalanceToolStripMenuItem.Click += new System.EventHandler(this.viewBalanceToolStripMenuItem_Click);
            // 
            // journeyHistoryToolStripMenuItem
            // 
            this.journeyHistoryToolStripMenuItem.Name = "journeyHistoryToolStripMenuItem";
            this.journeyHistoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.journeyHistoryToolStripMenuItem.Text = "Journey History";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem2.Text = "Book Ticket";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 501);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Home";
            this.Text = "Metro Ticket Booking System";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicationForMetroCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargeMetrcoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journeyHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}