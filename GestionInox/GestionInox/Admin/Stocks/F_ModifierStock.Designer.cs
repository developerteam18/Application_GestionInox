namespace GestionInox.Admin.Stocks
{
    partial class F_ModifierStock
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
            this.annuler = new System.Windows.Forms.Button();
            this.valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.nouveau_quantite = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.type_achat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nom:";
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(443, 149);
            this.annuler.Margin = new System.Windows.Forms.Padding(10);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(101, 48);
            this.annuler.TabIndex = 45;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.White;
            this.valider.Location = new System.Drawing.Point(297, 149);
            this.valider.Margin = new System.Windows.Forms.Padding(10);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(101, 48);
            this.valider.TabIndex = 44;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Quantité:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Prix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Type d\'achat:";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(107, 47);
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Size = new System.Drawing.Size(121, 20);
            this.nom.TabIndex = 46;
            // 
            // nouveau_quantite
            // 
            this.nouveau_quantite.Location = new System.Drawing.Point(107, 85);
            this.nouveau_quantite.Name = "nouveau_quantite";
            this.nouveau_quantite.Size = new System.Drawing.Size(121, 20);
            this.nouveau_quantite.TabIndex = 47;
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(405, 47);
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Size = new System.Drawing.Size(121, 20);
            this.prix.TabIndex = 48;
            this.prix.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // type_achat
            // 
            this.type_achat.Location = new System.Drawing.Point(405, 85);
            this.type_achat.Name = "type_achat";
            this.type_achat.ReadOnly = true;
            this.type_achat.Size = new System.Drawing.Size(121, 20);
            this.type_achat.TabIndex = 49;
            // 
            // F_ModifierStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 214);
            this.Controls.Add(this.type_achat);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.nouveau_quantite);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "F_ModifierStock";
            this.Text = "F_ModifierStock";
            this.Load += new System.EventHandler(this.F_ModifierStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox nouveau_quantite;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox type_achat;
    }
}