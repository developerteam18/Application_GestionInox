using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInox.Admin.Facture
{
    public partial class F_ImprimeFacture : Form
    {
        public F_ImprimeFacture()
        {
            InitializeComponent();
        }

        private void F_ImprimeFacture_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Client.F_GestionClients F = new Client.F_GestionClients();
            F.Show();
            Hide();
        }
    }
}
