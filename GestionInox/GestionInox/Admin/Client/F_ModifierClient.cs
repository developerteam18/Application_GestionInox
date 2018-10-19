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
    public partial class F_ModifierClient : Form
    {
        public int NumClientUpd = 0;
       
        public F_ModifierClient()
        {
            InitializeComponent();
           
            T_UpdateNumClient.Text = F_GestionClients.NumClientUpdate.ToString();
            NumClientUpd = int.Parse(F_GestionClients.NumClientUpdate.ToString());

            GetDataClient();


        }

        public void GetDataClient()
        {
            using (Prestige_InoxEntities MyContext = new Prestige_InoxEntities())
            {

                var ClientUpd = (from P in MyContext.TableClients
                                 where P.idC == NumClientUpd
                                 select P).First();

                if (ClientUpd != null)
                {
                    T_UpdateNomClient.Text = ClientUpd.Nom;
                    T_UpdatePrenomClient.Text = ClientUpd.Prénom;
                    T_UpdateTeleClient.Text = ClientUpd.Tel;
                    T_UpdateAdressClient.Text = ClientUpd.Adresse;
                }
                else
                {
                    MessageBox.Show("Objet Null !");
                }

            }

            
        }

        private void Btn_ValidationUpdateClient_Click(object sender, EventArgs e)
        {
            int Rep = -1;

            using (Prestige_InoxEntities MyContext = new Prestige_InoxEntities())
            {

                var ClientUpd = (from P in MyContext.TableClients
                                 where P.idC == NumClientUpd
                                 select P).First();

                if (ClientUpd != null)
                {
                    ClientUpd.Nom = T_UpdateNomClient.Text;
                    ClientUpd.Prénom = T_UpdatePrenomClient.Text;
                    ClientUpd.Tel = T_UpdateTeleClient.Text;
                    ClientUpd.Adresse = T_UpdateAdressClient.Text;

                    Rep = MyContext.SaveChanges();
                }


                if (Rep > 0)
                {
                    MessageBox.Show("Client a Bien Modifier");
                }
                else
                {
                    MessageBox.Show("Client de Modification !! ");
                }


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
