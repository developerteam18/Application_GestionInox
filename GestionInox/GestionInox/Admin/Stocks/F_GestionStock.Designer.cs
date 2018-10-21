namespace GestionInox.Admin.Stocks
{
    partial class F_GestionStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestionStock));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.TextBox();
            this.qte = new System.Windows.Forms.TextBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.ComboBox();
            this.annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Chercher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnActualiser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_achat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_achat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modification = new System.Windows.Forms.DataGridViewButtonColumn();
            this.suppression = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Type d\'achat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prix:";
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(398, 24);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(121, 20);
            this.prix.TabIndex = 32;
            // 
            // qte
            // 
            this.qte.Location = new System.Drawing.Point(102, 62);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(121, 20);
            this.qte.TabIndex = 31;
            // 
            // combotype
            // 
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Bon",
            "Facture"});
            this.combotype.Location = new System.Drawing.Point(398, 62);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(121, 21);
            this.combotype.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantité:";
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.White;
            this.valider.Location = new System.Drawing.Point(179, 96);
            this.valider.Margin = new System.Windows.Forms.Padding(10);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(101, 48);
            this.valider.TabIndex = 34;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // nom
            // 
            this.nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nom.FormattingEnabled = true;
            this.nom.Location = new System.Drawing.Point(102, 24);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(121, 21);
            this.nom.TabIndex = 36;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(359, 96);
            this.annuler.Margin = new System.Windows.Forms.Padding(10);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(101, 48);
            this.annuler.TabIndex = 35;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom:";
            // 
            // Btn_Chercher
            // 
            this.Btn_Chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Chercher.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Chercher.Image")));
            this.Btn_Chercher.Location = new System.Drawing.Point(576, 10);
            this.Btn_Chercher.Name = "Btn_Chercher";
            this.Btn_Chercher.Size = new System.Drawing.Size(52, 43);
            this.Btn_Chercher.TabIndex = 37;
            this.Btn_Chercher.UseVisualStyleBackColor = true;
            this.Btn_Chercher.Click += new System.EventHandler(this.Btn_Chercher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnActualiser);
            this.groupBox1.Controls.Add(this.Btn_Chercher);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.annuler);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.valider);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combotype);
            this.groupBox1.Controls.Add(this.qte);
            this.groupBox1.Controls.Add(this.prix);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 150);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualiser.Image")));
            this.BtnActualiser.Location = new System.Drawing.Point(576, 65);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(52, 44);
            this.BtnActualiser.TabIndex = 38;
            this.BtnActualiser.UseVisualStyleBackColor = true;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantité,
            this.prix_achat,
            this.type_achat,
            this.modification,
            this.suppression});
            this.dataGridView1.Location = new System.Drawing.Point(48, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantité
            // 
            this.quantité.HeaderText = "Quantité";
            this.quantité.Name = "quantité";
            this.quantité.ReadOnly = true;
            // 
            // prix_achat
            // 
            this.prix_achat.HeaderText = "Prix Achat";
            this.prix_achat.Name = "prix_achat";
            this.prix_achat.ReadOnly = true;
            // 
            // type_achat
            // 
            this.type_achat.HeaderText = "Type Achat";
            this.type_achat.Name = "type_achat";
            this.type_achat.ReadOnly = true;
            // 
            // modification
            // 
            this.modification.HeaderText = "Modification";
            this.modification.Name = "modification";
            this.modification.ReadOnly = true;
            this.modification.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modification.Text = "Modifier";
            this.modification.UseColumnTextForButtonValue = true;
            // 
            // suppression
            // 
            this.suppression.HeaderText = "Suppression";
            this.suppression.Name = "suppression";
            this.suppression.ReadOnly = true;
            this.suppression.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.suppression.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.suppression.Text = "Supprimer";
            this.suppression.UseColumnTextForButtonValue = true;
            // 
            // F_GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_GestionStock";
            this.Text = "F_GestionStock";
            this.Load += new System.EventHandler(this.F_GestionStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.ComboBox nom;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Chercher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnActualiser;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_achat;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_achat;
        private System.Windows.Forms.DataGridViewButtonColumn modification;
        private System.Windows.Forms.DataGridViewButtonColumn suppression;
    }
}