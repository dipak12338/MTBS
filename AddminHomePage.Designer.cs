namespace WindowsFormsApplication1
{
    partial class AdminHomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fairDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStationToolStripMenuItem,
            this.addTrainToolStripMenuItem,
            this.addTripToolStripMenuItem,
            this.fairDetailsToolStripMenuItem,
            this.complaintsToolStripMenuItem,
            this.metroCardToolStripMenuItem,
            this.addAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(98, 323);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addStationToolStripMenuItem
            // 
            this.addStationToolStripMenuItem.Name = "addStationToolStripMenuItem";
            this.addStationToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.addStationToolStripMenuItem.Text = "Add Station";
            this.addStationToolStripMenuItem.Click += new System.EventHandler(this.addStationToolStripMenuItem_Click);
            // 
            // addTrainToolStripMenuItem
            // 
            this.addTrainToolStripMenuItem.Name = "addTrainToolStripMenuItem";
            this.addTrainToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.addTrainToolStripMenuItem.Text = "Add Train";
            this.addTrainToolStripMenuItem.Click += new System.EventHandler(this.addTrainToolStripMenuItem_Click);
            // 
            // addTripToolStripMenuItem
            // 
            this.addTripToolStripMenuItem.Name = "addTripToolStripMenuItem";
            this.addTripToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.addTripToolStripMenuItem.Text = "Add Trip";
            this.addTripToolStripMenuItem.Click += new System.EventHandler(this.addTripToolStripMenuItem_Click);
            // 
            // fairDetailsToolStripMenuItem
            // 
            this.fairDetailsToolStripMenuItem.Name = "fairDetailsToolStripMenuItem";
            this.fairDetailsToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.fairDetailsToolStripMenuItem.Text = "Fair Details";
            this.fairDetailsToolStripMenuItem.Click += new System.EventHandler(this.fairDetailsToolStripMenuItem_Click);
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridToolStripMenuItem});
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.complaintsToolStripMenuItem.Text = "Complaints";
            this.complaintsToolStripMenuItem.Click += new System.EventHandler(this.complaintsToolStripMenuItem_Click);
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // metroCardToolStripMenuItem
            // 
            this.metroCardToolStripMenuItem.Name = "metroCardToolStripMenuItem";
            this.metroCardToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.metroCardToolStripMenuItem.Text = "Metro Card";
            this.metroCardToolStripMenuItem.Click += new System.EventHandler(this.metroCardToolStripMenuItem_Click);
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(394, 323);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHomePage";
            this.Text = "Admin Home Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fairDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metroCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStationToolStripMenuItem;
    }
}