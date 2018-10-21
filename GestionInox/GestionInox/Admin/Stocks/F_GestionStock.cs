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
    public partial class F_GestionStock : Form
    {
        Prestige_InoxEntities p;

        //Remplissage Cobobox
        public void RemplirCombo()
        {
            p = new Prestige_InoxEntities();

            nom.DataSource = p.Produits.Select(s => new { Id_Produit = s.idP,Nom_Poduit = s.Nom }).ToList();
            nom.DisplayMember = "Nom_Poduit";
            nom.ValueMember = "Id_Produit";

        }
        //Remplissage Datagrid
        public void RemplirGridView()
        {
            dataGridView1.Rows.Clear();

            p = new Prestige_InoxEntities();
            //    dataGridView1.DataSource = p.Stocks.Select(a => new {a.Nom,a.Qte, a.PrixU, a.TypeA }).ToList();
            var the_stock = p.Stocks.ToList();
            for (int i = 0; i < the_stock.ToList().Count; i++)
            {
                nom.DataSource = p.Produits.Select(s => new { Id_Produit = s.idP, Nom_Poduit = s.Nom }).ToList();
                // var n = the_stock.ToList()[i].Nom;


               
                dataGridView1.Rows.Add(the_stock.ToList()[i].Produit.Nom,
                                        the_stock.ToList()[i].Qte,
                                        the_stock.ToList()[i].PrixU,
                                        the_stock.ToList()[i].TypeA);
            }
        }


        private void F_GestionStock_Load(object sender, EventArgs e)
        {
            //Remplissage Cobobox
            RemplirCombo();
            //Remplissage Datagrid
            RemplirGridView();
        }

        public F_GestionStock()
        {
            InitializeComponent();

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            qte.Text = "";
            prix.Text = "";
            combotype.SelectedIndex = 0;
            nom.SelectedIndex = 0;
        }

        private void valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (nom.Text!= "" && qte.Text!= "" && prix.Text!="" && combotype.Text!="")
                {
                    var s = new Stock();

                    var name = nom.SelectedValue.ToString();
                    int quantite = int.Parse(qte.Text);
                    float Prix = float.Parse(prix.Text);
                    var type_achat = combotype.SelectedItem.ToString();
                    s.Nom = int.Parse(name);
                    s.Qte = quantite;
                    s.PrixU = Prix;
                    s.TypeA = type_achat;

                    p.Stocks.Add(s);
                     p.SaveChanges();
                    MessageBox.Show("Produit Bien Ajouter");

                    //Remplissage Datagrid
                    RemplirGridView();
                }
                else
                {
                    MessageBox.Show("Merci de remplir tout les champs !");
                }
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produit, Merci de réessayer !");
            }
           
        }

        public static string NomProduit = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                NomProduit = row.Cells[0].Value.ToString();
                if (e.ColumnIndex == 4)
                {       
                    F_ModifierStock ms = new F_ModifierStock();
                    ms.Show();
                    Hide();
                }
                else
                    {
                        if (e.ColumnIndex == 5)
                        {
                            Prestige_InoxEntities p = new Prestige_InoxEntities();
                            Stock stocks = (from A in p.Stocks where A.Produit.Nom == NomProduit select A).First();
                            p.Stocks.Remove(stocks);
                            p.SaveChanges();
                            MessageBox.Show("Le produit a été supprimé ");
                        RemplirGridView();
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Chercher_Click(object sender, EventArgs e)
        {
            int n = nom.SelectedIndex+1;
            Prestige_InoxEntities p = new Prestige_InoxEntities();
            //Vider GridView
            dataGridView1.Rows.Clear();

            var InfosStock = (from S in p.Stocks where S.Nom == n select S).ToList();
            if(InfosStock.Count == 0)
            {
                MessageBox.Show("Aucun Produit trouvée, Merci de réessayer !");
            }
            else
            {
                for (int i = 0; i < InfosStock.ToList().Count; i++)
                {
                    dataGridView1.Rows.Add(InfosStock[i].Produit.Nom,
                                           InfosStock[i].Qte,
                                           InfosStock[i].PrixU,
                                           InfosStock[i].TypeA);

                }
            }

        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            RemplirGridView();
        }
    }
}
