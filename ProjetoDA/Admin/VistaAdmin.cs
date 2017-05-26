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

        Model1Container mcontainer;

        public VistaAdmin()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
            refreshList();
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
            TabelaJogos newEdit = new TabelaJogos();
            newEdit.ShowDialog();
        }

        private void inserirEditarRemoverEquipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaEquipas newEdit = new TabelaEquipas();
            newEdit.ShowDialog();
        }

        private void inserirEditarRemoverCartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaCartas newEdit = new TabelaCartas();
            newEdit.ShowDialog();
        }

        private void inserirEditarRemoverBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaBaralho newEdit = new TabelaBaralho();
            newEdit.ShowDialog();
        }

        private void refreshList()
        {
            listBoxArbitros.Items.Clear();
            listBoxJogos.Items.Clear();
            listBoxTorneios.Items.Clear();
            listBoxArbitros.Items.Add(mcontainer.UserSet.OfType<Referee>().ToArray());
            listBoxJogos.Items.Add(mcontainer.GameSet.ToArray());
            listBoxTorneios.Items.Add(mcontainer.TournamentSet.ToArray());
        }
    }
}
