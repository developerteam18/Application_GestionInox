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
    public partial class F_GestionClients : Form
    {
        public F_GestionClients()
        {
            InitializeComponent();
            RemplireGridTest();
            Rd_Name.Checked = true;
            T_ChercherTele.Enabled = false;
        }


        public static  int NumClientUpdate = 0;

        public void RemplireGridTest()
        {

            using (Prestige_InoxEntities ContextInox = new Prestige_InoxEntities())
            {
                var AllClient = (from c in ContextInox.TableClients select c).ToList();

                for (int i = 0; i < AllClient.ToList().Count(); i++)
                {

                    GridTest.Rows.Add(AllClient.ToList()[i].idC,
                                        AllClient.ToList()[i].Nom,
                                        AllClient.ToList()[i].Prénom,
                                        AllClient.ToList()[i].Tel,
                                        AllClient.ToList()[i].Adresse
                                        );
                }


            }
        }

        private void Btn_Chercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rd_Name.Checked)
                {
                    GridTest.Rows.Clear();

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

                                GridTest.Rows.Add(ClientDemende.ToList()[i].idC,
                                                    ClientDemende.ToList()[i].Nom,
                                                    ClientDemende.ToList()[i].Prénom,
                                                    ClientDemende.ToList()[i].Tel,
                                                    ClientDemende.ToList()[i].Adresse
                                                    );
                            }


                        }

                    }
                }
                else
                {
                    MessageBox.Show("En Coure de devlopement !");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            GridTest.Rows.Clear();
            T_ChercheClient.Text = "";
        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Client.F_AjouterClient F = new F_AjouterClient();
            F.Show();
            Hide();
        }

        private void GridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // !! CellClick
        private void GridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //DataGridViewRow MyRow = GridClient1.Rows[index];
            //MessageBox.Show(MyRow.Cells[0].Value.ToString());
        }

        private void GridTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            int index = e.RowIndex;

            if (e.ColumnIndex == 6)
            {
                DataGridViewRow MyRow = GridTest.Rows[index];
                NumClientUpdate = int.Parse(MyRow.Cells[0].Value.ToString());

                Credit.F_DetailCredit F = new Credit.F_DetailCredit();
                F.Show();

                Hide();
            }

            else
            {
                if (e.ColumnIndex == 7)
                {
                    DataGridViewRow MyRow = GridTest.Rows[index];
                    NumClientUpdate = int.Parse(MyRow.Cells[0].Value.ToString());

                    Facture.DetailFacture.F_DetailFacture F = new Facture.DetailFacture.F_DetailFacture();
                    F.Show();

                    Hide();
                }

                else
                {
                    if (e.ColumnIndex == 8)
                    {
                        DataGridViewRow MyRow = GridTest.Rows[index];
                        NumClientUpdate = int.Parse(MyRow.Cells[0].Value.ToString());

                        F_ModifierClient F = new F_ModifierClient();
                        F.Show();

                        Hide();
                    }
                }

            }
            }
            catch
            {

            }
            
        }

        private void Rd_Tele_CheckedChanged(object sender, EventArgs e)
        {
            T_ChercheClient.Text = "";
            T_ChercheClient.Enabled = false;
            T_ChercherTele.Enabled = true;
        }

        private void Rd_Name_CheckedChanged(object sender, EventArgs e)
        {
            T_ChercherTele.Text = "";
            T_ChercheClient.Enabled = true;
            T_ChercherTele.Enabled = false;
        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            RemplireGridTest();
            Rd_Name.Checked = true;
            T_ChercherTele.Enabled = false;
        }
    }
}
