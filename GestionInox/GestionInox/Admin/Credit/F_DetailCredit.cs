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

namespace GestionInox.Admin.Credit
{
    public partial class F_DetailCredit : Form
    {
        public int NumDetailClient = 0;
        public F_DetailCredit()
        {
            InitializeComponent();

            T_NumClient.Text = F_GestionClients.NumClientUpdate.ToString();
            NumDetailClient = int.Parse(F_GestionClients.NumClientUpdate.ToString());

            GetDetatilClient();

        }

        public void GetDetatilClient()
        {
            using (Prestige_InoxEntities MyContext = new Prestige_InoxEntities())
            {

                var ClientUpd = (from P in MyContext.TableClients
                                 where P.idC == NumDetailClient
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
            Admin.Client.F_GestionClients F = new Client.F_GestionClients();
            F.Show();
            Hide();
        }
    }
}
