using GestionInox.Admin.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInox.Admin.Facture.DetailFacture
{
    public partial class F_DetailFacture : Form
    {
        public int NumClientUpd = 0;
        public F_DetailFacture()
        {
            InitializeComponent();
            T_NumClient.Text = F_GestionClients.NumClientUpdate.ToString();
            NumClientUpd = int.Parse(F_GestionClients.NumClientUpdate.ToString());

            GetDetatilClientFacture();
        }


        public void GetDetatilClientFacture()
        {
            using (Prestige_InoxEntities MyContext = new Prestige_InoxEntities())
            {

                var ClientUpd = (from P in MyContext.TableClients
                                 where P.idC == NumClientUpd
                                 select P).First();

                if (ClientUpd != null)
                {
                    T_NameClient.Text = ClientUpd.Nom;
                    T_PrenomClient.Text = ClientUpd.Prénom;
                    T_NumteleClient.Text = ClientUpd.Tel;
                    T_AdresseClient.Text = ClientUpd.Adresse;
                }
                else
                {
                    MessageBox.Show("Objet Null !");
                }

            }

        }

        private void tousLesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestionClients F = new F_GestionClients();
            F.Show();
            Hide();
        }
    }
}
