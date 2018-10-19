using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInox.Admin.Client
{
    public partial class F_AjouterClient : Form
    {
        public F_AjouterClient()
        {
            InitializeComponent();
            T_AddNumClient.Text = GetNumClient().ToString();
          
       }

        public int GetNumClient()
        {
            using (Prestige_InoxEntities MyContext = new Prestige_InoxEntities())
            {
                return MyContext.TableClients.Count() +1;
            }
        }

        public void Vider()
        {
            T_AddNomClient.Text = "";
            T_AddPrenomClient.Text = "";
            T_AddTeleClient.Text = "";
            T_AddAdressClient.Text = "";
        }

        //Btn Annuler
        private void button5_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void Btn_Confirmer_Click(object sender, EventArgs e)
        {

            try
            {
                string NomClient = T_AddNomClient.Text;
                string PrenomClient = T_AddPrenomClient.Text;
                string NumTeleClient = T_AddTeleClient.Text;
                string AdresseClient = T_AddAdressClient.Text;

                if ((T_AddNomClient.Text == "") || (T_AddPrenomClient.Text == "") || (T_AddNumClient.Text == "") || (T_AddAdressClient.Text == ""))
                {
                    MessageBox.Show("Vous Avez Oublier de Remplire Un Champs !");
                }
                else
                {
                    using (Prestige_InoxEntities MyContext = new Prestige_InoxEntities())
                    {
                        var NewClient = new TableClient
                        {
                            Nom         = NomClient.ToUpper(),
                            Prénom      = PrenomClient.ToUpper(),
                            Tel         = NumTeleClient,
                            Adresse     = AdresseClient
                        };

                        MyContext.TableClients.Add(NewClient);

                        int Rep = MyContext.SaveChanges();
                        if (Rep>0)
                        {
                            MessageBox.Show("Client a Bien Ajouter");
                            T_AddNumClient.Text = GetNumClient().ToString();
                            Vider();
                            
                        }
                        else
                        {
                            MessageBox.Show("Erreur d'ajoute !! ");
                        }    

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestionClients F = new F_GestionClients();
            F.Show();
            Hide();
        }
    }
}
