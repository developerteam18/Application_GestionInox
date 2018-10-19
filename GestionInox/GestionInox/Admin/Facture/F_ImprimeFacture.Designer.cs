namespace GestionInox.Admin.Facture
{
    partial class F_ImprimeFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ImprimeFacture));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.gestionClientToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.gestionVentesToolStripMenuItem,
            this.gestionFactureToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // gestionClientToolStripMenuItem
            // 
            this.gestionClientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionClientToolStripMenuItem.Image")));
            this.gestionClientToolStripMenuItem.Name = "gestionClientToolStripMenuItem";
            this.gestionClientToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.gestionClientToolStripMenuItem.Text = "Gestion Client";
            this.gestionClientToolStripMenuItem.Click += new System.EventHandler(this.gestionClientToolStripMenuItem_Click);
            // 
            // gestionStockToolStripMenuItem
            // 
            this.gestionStockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionStockToolStripMenuItem.Image")));
            this.gestionStockToolStripMenuItem.Name = "gestionStockToolStripMenuItem";
            this.gestionStockToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.gestionStockToolStripMenuItem.Text = "Gestion Stock";
            // 
            // gestionVentesToolStripMenuItem
            // 
            this.gestionVentesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionVentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionVentesToolStripMenuItem.Image")));
            this.gestionVentesToolStripMenuItem.Name = "gestionVentesToolStripMenuItem";
            this.gestionVentesToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.gestionVentesToolStripMenuItem.Text = "Gestion Ventes";
            // 
            // gestionFactureToolStripMenuItem
            // 
            this.gestionFactureToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionFactureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionFactureToolStripMenuItem.Image")));
            this.gestionFactureToolStripMenuItem.Name = "gestionFactureToolStripMenuItem";
            this.gestionFactureToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.gestionFactureToolStripMenuItem.Text = "Gestion Facture";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(117, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(693, 577);
            this.reportViewer1.TabIndex = 7;
            // 
            // F_ImprimeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(911, 642);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ImprimeFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ImprimeFacture";
            this.Load += new System.EventHandler(this.F_ImprimeFacture_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}