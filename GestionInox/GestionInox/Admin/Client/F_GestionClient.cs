using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInox.Admin
{
    public partial class F_GestionClient : Form
    {
        public F_GestionClient()
        {
            InitializeComponent();
            RemplireGridClient();
        }


        public void RemplireGridClient()
        {
            GridClient.Rows.Clear();


            using (Prestige_InoxEntities ContextInox = new Prestige_InoxEntities())
            {
                var AllClient = (from c in ContextInox.TableClients select c).ToList(); 

                for (int i = 0; i < AllClient.ToList().Count(); i++)
                    {

                        GridClient.Rows.Add(AllClient.ToList()[i].idC,
                                            AllClient.ToList()[i].Nom,
                                            AllClient.ToList()[i].Prénom,
                                            AllClient.ToList()[i].Tel,
                                            AllClient.ToList()[i].Adresse
                                            );
                    }


                }

            



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Chercher_Click(object sender, EventArgs e)
        {
            GridClient.Rows.Clear();

            string NomClient = T_ChercheClient.Text;

            using (Prestige_InoxEntities ContextInox = new Prestige_InoxEntities())
            {
                var ClientDemende = from B in ContextInox.TableClients
                                    .Where(B => B.Nom == NomClient)
                                    select B;

                if (ClientDemende.Count() == 0)
                {
                    MessageBox.Show("Aucun Clien Trouver , Merci de Vérifie le Nom de Client ");
                }
                else
                {
                    for (int i = 0; i < ClientDemende.ToList().Count(); i++)
                    {

                        GridClient.Rows.Add(ClientDemende.ToList()[i].idC,
                                            ClientDemende.ToList()[i].Nom,
                                            ClientDemende.ToList()[i].Prénom,
                                            ClientDemende.ToList()[i].Tel,
                                            ClientDemende.ToList()[i].Adresse
                                            );
                    }


                }

            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            GridClient.Rows.Clear();
            T_ChercheClient.Text = "";
        }
    }
}
