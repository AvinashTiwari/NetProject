namespace CarRentalDotnet
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manageVechicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVechicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVechicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVechicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRendtalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Window";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVechicleListingToolStripMenuItem,
            this.manageRentalRecordToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1318, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // manageVechicleListingToolStripMenuItem
            // 
            this.manageVechicleListingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVechicleToolStripMenuItem,
            this.removeVechicleToolStripMenuItem,
            this.editVechicleToolStripMenuItem,
            this.viewListingToolStripMenuItem});
            this.manageVechicleListingToolStripMenuItem.Name = "manageVechicleListingToolStripMenuItem";
            this.manageVechicleListingToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.manageVechicleListingToolStripMenuItem.Text = "Manage Vechicle Listing";
            // 
            // addVechicleToolStripMenuItem
            // 
            this.addVechicleToolStripMenuItem.Name = "addVechicleToolStripMenuItem";
            this.addVechicleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addVechicleToolStripMenuItem.Text = "Add vechicle";
            // 
            // removeVechicleToolStripMenuItem
            // 
            this.removeVechicleToolStripMenuItem.Name = "removeVechicleToolStripMenuItem";
            this.removeVechicleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeVechicleToolStripMenuItem.Text = "Remove Vechicle";
            // 
            // editVechicleToolStripMenuItem
            // 
            this.editVechicleToolStripMenuItem.Name = "editVechicleToolStripMenuItem";
            this.editVechicleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editVechicleToolStripMenuItem.Text = "Edit Vechicle";
            // 
            // viewListingToolStripMenuItem
            // 
            this.viewListingToolStripMenuItem.Name = "viewListingToolStripMenuItem";
            this.viewListingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewListingToolStripMenuItem.Text = "View Listing";
            // 
            // manageRentalRecordToolStripMenuItem
            // 
            this.manageRentalRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRendtalRecordToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem});
            this.manageRentalRecordToolStripMenuItem.Name = "manageRentalRecordToolStripMenuItem";
            this.manageRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.manageRentalRecordToolStripMenuItem.Text = "Manage rental record";
            // 
            // addRendtalRecordToolStripMenuItem
            // 
            this.addRendtalRecordToolStripMenuItem.Name = "addRendtalRecordToolStripMenuItem";
            this.addRendtalRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.addRendtalRecordToolStripMenuItem.Text = "Add Rendtal Record";
            this.addRendtalRecordToolStripMenuItem.Click += new System.EventHandler(this.addRendtalRecordToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.editRentalRecordToolStripMenuItem.Text = "Edit rental record";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageVechicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVechicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVechicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVechicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRendtalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
    }
}