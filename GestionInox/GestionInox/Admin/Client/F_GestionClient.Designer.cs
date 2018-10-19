namespace GestionInox.Admin
{
    partial class F_GestionClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestionClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_Chercher = new System.Windows.Forms.Button();
            this.T_ChercheClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionChargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 688);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Annuler);
            this.groupBox4.Controls.Add(this.Btn_Chercher);
            this.groupBox4.Controls.Add(this.T_ChercheClient);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.GridClient);
            this.groupBox4.Location = new System.Drawing.Point(18, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(952, 473);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annuler.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Annuler.Image")));
            this.Btn_Annuler.Location = new System.Drawing.Point(883, 22);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(52, 44);
            this.Btn_Annuler.TabIndex = 12;
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_Chercher
            // 
            this.Btn_Chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Chercher.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Chercher.Image")));
            this.Btn_Chercher.Location = new System.Drawing.Point(825, 22);
            this.Btn_Chercher.Name = "Btn_Chercher";
            this.Btn_Chercher.Size = new System.Drawing.Size(52, 43);
            this.Btn_Chercher.TabIndex = 11;
            this.Btn_Chercher.UseVisualStyleBackColor = true;
            this.Btn_Chercher.Click += new System.EventHandler(this.Btn_Chercher_Click);
            // 
            // T_ChercheClient
            // 
            this.T_ChercheClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_ChercheClient.Location = new System.Drawing.Point(294, 31);
            this.T_ChercheClient.Name = "T_ChercheClient";
            this.T_ChercheClient.Size = new System.Drawing.Size(511, 26);
            this.T_ChercheClient.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tape le Nom de Client";
            // 
            // GridClient
            // 
            this.GridClient.AllowUserToAddRows = false;
            this.GridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7});
            this.GridClient.Location = new System.Drawing.Point(14, 83);
            this.GridClient.Name = "GridClient";
            this.GridClient.Size = new System.Drawing.Size(921, 372);
            this.GridClient.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num Client";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Client";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom Client";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Téléphone Client";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse Client";
            this.Column4.Name = "Column4";
            this.Column4.Width = 245;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Modifier Client";
            this.Column6.Name = "Column6";
            this.Column6.Text = "";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Supprimer Client";
            this.Column7.Name = "Column7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(374, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gestion Client";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.gestionVentesToolStripMenuItem,
            this.gestionFactureToolStripMenuItem,
            this.gestionChargesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterClientToolStripMenuItem.Image")));
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter Client";
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
            // gestionChargesToolStripMenuItem
            // 
            this.gestionChargesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionChargesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionChargesToolStripMenuItem.Image")));
            this.gestionChargesToolStripMenuItem.Name = "gestionChargesToolStripMenuItem";
            this.gestionChargesToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.gestionChargesToolStripMenuItem.Text = "Gestion Charges";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // F_GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1024, 755);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_GestionClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionChargesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox T_ChercheClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridClient;
        private System.Windows.Forms.Button Btn_Chercher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Button Btn_Annuler;
    }
}