using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInox
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Client.F_GestionClients F = new Admin.Client.F_GestionClients();
            F.Show();
            Hide();
        }

        private void gestionStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Stocks.F_GestionStock GS = new Admin.Stocks.F_GestionStock();
            GS.Show();
            Hide();
        }
    }
}
