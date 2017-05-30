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
    public partial class FormAddJogadores : Form
    {
        private Model1Container container;
        private StandardTournament torneioNormalSelecionado;
        private Player jogadorSelecionado;

        public FormAddJogadores()
        {
            InitializeComponent();
            container = new Model1Container();
            refreshList();
        }

        //Atualiza as listBoxs.
        private void refreshList()
        {
            listBoxJogadores.Items.Clear();
            listBoxTorneio.Items.Clear();
            listBoxJogadoresTorneio.Items.Clear();
            listBoxJogadores.Items.AddRange(container.PlayerSet.ToArray());
            listBoxTorneio.Items.AddRange(container.TournamentSet.ToArray());
        }

        //Erro ao desenvolver o diagrama, em vez de Tounaments deveria ser Players.
        //Adiciona os jogadores ao torneio.
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (listBoxTorneio.SelectedIndex >= 0)
            {
                if (listBoxJogadores.SelectedIndex >= 0)
                {
                    torneioNormalSelecionado = (StandardTournament)listBoxTorneio.SelectedItem;
                    jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

                    torneioNormalSelecionado.Tournaments.Add(jogadorSelecionado);
                    container.SaveChanges();

                    listBoxJogadoresTorneio.Items.Clear();
                    listBoxJogadoresTorneio.Items.AddRange(torneioNormalSelecionado.Tournaments.ToArray());
                }
                else
                {
                    MessageBox.Show("Seleccione um jogador");
                }
            }
            else
            {
                MessageBox.Show("Seleccione um torneio");
            }
        }

        //Erro ao desenvolver o diagrama, em vez de Tounaments deveria ser Players.
        //Atualiza a lista de jogadores do torneio selecionado.
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            torneioNormalSelecionado = (StandardTournament)listBoxTorneio.SelectedItem;
            listBoxJogadoresTorneio.Items.Clear();
            listBoxJogadoresTorneio.Items.AddRange(torneioNormalSelecionado.Tournaments.ToArray());
        }

        //Erro ao desenvolver o diagrama, em vez de Tounaments deveria ser Players.
        //Remover o jogador selecionado do torneio.
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTorneio.SelectedIndex >= 0)
            {
                if (listBoxJogadoresTorneio.SelectedIndex >= 0)
                {
                    jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;
                    torneioNormalSelecionado = (StandardTournament)listBoxJogadoresTorneio.SelectedItem;

                    torneioNormalSelecionado.Tournaments.Remove(jogadorSelecionado);
                    container.SaveChanges();

                    listBoxJogadoresTorneio.Items.Clear();
                    listBoxJogadoresTorneio.Items.AddRange(torneioNormalSelecionado.Tournaments.ToArray());
                }
            }
        }
    }
}
