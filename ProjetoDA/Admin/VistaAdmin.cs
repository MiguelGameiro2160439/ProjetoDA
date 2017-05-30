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

        //Mostra o form de edição dos utilizadores.
        private void inserirEditarRemoverUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUtilizadores newEdit = new EditUtilizadores();
            newEdit.ShowDialog();
        }

        //Mostra o form de edição dos jogadores.
        private void inserirEditarRemoverJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditJogadores newEdit = new EditJogadores();
            newEdit.ShowDialog();
        }

        //Mostra o form de edição das equipas.
        private void inserirEditarRemoverEquipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaEquipas newEdit = new TabelaEquipas();
            newEdit.ShowDialog();
        }

        //Mostra o form de edição das cartas.
        private void inserirEditarRemoverCartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaCartas newEdit = new TabelaCartas();
            newEdit.ShowDialog();
        }

        //Mostra o form de edição dos baralhos.
        private void inserirEditarRemoverBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaBaralho newEdit = new TabelaBaralho();
            newEdit.ShowDialog();
        }

        //Atualiza as listBoxs.
        private void refreshList()
        {
            listBoxArbitros.Items.Clear();
            listBoxJogos.Items.Clear();
            listBoxTorneios.Items.Clear();
            listBoxArbitros.Items.AddRange(mcontainer.UserSet.OfType<Referee>().ToArray());
            listBoxJogos.Items.AddRange(mcontainer.GameSet.ToArray());
            listBoxTorneios.Items.AddRange(mcontainer.TournamentSet.ToArray());
        }

        //Mostra o form de edição dos jogos.
        private void inserirEditarRemoverJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaJogos newEdit = new TabelaJogos();
            newEdit.ShowDialog();
        }

        //Mostra o form de edição dos torneios.
        private void inserirEditarRemoverTorneiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaTorneios newEdit = new TabelaTorneios();
            newEdit.ShowDialog();
        }
    }
}
