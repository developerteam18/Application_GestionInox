using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInox.Admin.Stocks
{
    public partial class F_ModifierStock : Form
    {
        public F_ModifierStock()
        {
            InitializeComponent();
        }
        public string NomProd ="";

        public void getDataStock()
        {
            Prestige_InoxEntities P = new Prestige_InoxEntities();
            var StockModifiée = (from a in P.Stocks
                                 where a.Produit.Nom == NomProd
                                 select a).First();

            if(StockModifiée != null)
            {
                nom.Text =StockModifiée.Produit.Nom.ToString();
                prix.Text = StockModifiée.PrixU.ToString();
                nouveau_quantite.Text = StockModifiée.Qte.ToString();
                type_achat.Text = StockModifiée.TypeA.ToString();

            }
            else
            {
                MessageBox.Show("Merci de choisir un élément");
            }
        }

        private void F_ModifierStock_Load(object sender, EventArgs e)
        {
            nom.Text = F_GestionStock.NomProduit.ToString();
            NomProd = F_GestionStock.NomProduit.ToString();

            getDataStock();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            int Rep = -1;

            Prestige_InoxEntities P = new Prestige_InoxEntities();
            try
            {

                var st = (from n in P.Stocks
                                 where n.Produit.Nom == NomProd
                                 select n).First();

                if (st != null)
                {
                 st.Qte = int.Parse(nouveau_quantite.Text);
                    Rep = P.SaveChanges();
                }


                if (Rep > 0)
                {
                    MessageBox.Show("La modification a été bien effectuée");
                }
                else
                {
                    MessageBox.Show("Merci de réessayer ! ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void annuler_Click(object sender, EventArgs e)
        {
            F_GestionStock GS = new F_GestionStock();
            this.Close();
            GS.Show();
            
        }
    }
    }

