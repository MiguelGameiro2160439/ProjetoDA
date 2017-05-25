using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class VistaAdmin : Form
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void inserirEditarRemoverUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUtilizadores newEdit = new EditUtilizadores();
            newEdit.ShowDialog();
        }

        private void inserirEditarRemoverJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditJogadores newEdit = new EditJogadores();
            newEdit.ShowDialog();
        }

        private void inserirEditarRemoverJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
