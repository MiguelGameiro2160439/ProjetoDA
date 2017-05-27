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
    public partial class TabelaTorneios : Form
    {
        private Model1Container container;
        private TeamTournament torneioEquipaSelecionado;
        private StandardTournament torneioNormalSelecionado;

        public TabelaTorneios()
        {
            InitializeComponent();

            container = new Model1Container();

            refreshListaTorneioEquipa();
            refreshListaTorneioNormal();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormTorneios form = new FormTorneios();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarTorneioEquipa(form.NovoTorneioEquipa);
            }
        }

        private void AdicionarTorneioEquipa(TeamTournament torneioEquipa)
        {
            container.TournamentSet.Add(torneioEquipa);
            container.SaveChanges();
            refreshListaTorneioEquipa();
        }

        private void AdicionarTorneioNormal(StandardTournament torneioNormal)
        {
            container.TournamentSet.Add(torneioNormal);
            container.SaveChanges();
            refreshListaTorneioNormal();
        }

        private void refreshListaTorneioEquipa()
        {
            listBoxTorneios.Items.Clear();
            listBoxTorneios.Items.AddRange(container.TournamentSet.OfType<TeamTournament>().ToArray());
        }

        private void refreshListaTorneioNormal()
        {
            listBoxTorneioNormal.Items.Clear();
            listBoxTorneioNormal.Items.AddRange(container.TournamentSet.OfType<StandardTournament>().ToArray());
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            torneioEquipaSelecionado = (TeamTournament)listBoxTorneios.SelectedItem;

            if (torneioEquipaSelecionado != null)
            {
                //remover
                torneioEquipaSelecionado = (TeamTournament)listBoxTorneios.SelectedItem;

                container.TournamentSet.Remove(torneioEquipaSelecionado);

                container.SaveChanges();


                listBoxTorneios.Items.AddRange(container.TournamentSet.OfType<TeamTournament>().ToArray());

                //insere
                FormTorneios form = new FormTorneios();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarTorneioEquipa(form.NovoTorneioEquipa);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            torneioEquipaSelecionado = (TeamTournament)listBoxTorneios.SelectedItem;

            container.TournamentSet.Remove(torneioEquipaSelecionado);

            container.SaveChanges();

            listBoxTorneios.Items.Clear();
            listBoxTorneios.Items.AddRange(container.TournamentSet.OfType<TeamTournament>().ToArray());
        }

        private void listBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            torneioEquipaSelecionado = (TeamTournament)listBoxTorneios.SelectedItem;
        }

        private void buttonAdicionarNormal_Click(object sender, EventArgs e)
        {
            FormTorneioNormal form = new FormTorneioNormal();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarTorneioNormal(form.NovoTorneioNormal);
            }
        }

        private void buttonEditarNormal_Click(object sender, EventArgs e)
        {
            torneioNormalSelecionado = (StandardTournament)listBoxTorneioNormal.SelectedItem;

            if (torneioNormalSelecionado != null)
            {
                //remover
                torneioNormalSelecionado = (StandardTournament)listBoxTorneioNormal.SelectedItem;

                container.TournamentSet.Remove(torneioNormalSelecionado);

                container.SaveChanges();

                listBoxTorneioNormal.Items.Clear();
                listBoxTorneioNormal.Items.AddRange(container.TournamentSet.OfType<StandardTournament>().ToArray());

                //insere
                FormTorneioNormal form = new FormTorneioNormal();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                   AdicionarTorneioNormal(form.NovoTorneioNormal);
                }
            }
        }

        private void buttonRemoverNormal_Click(object sender, EventArgs e)
        {
            {
                torneioNormalSelecionado = (StandardTournament)listBoxTorneioNormal.SelectedItem;

                container.TournamentSet.Remove(torneioNormalSelecionado);

                container.SaveChanges();

                listBoxTorneioNormal.Items.Clear();
                listBoxTorneioNormal.Items.AddRange(container.TournamentSet.OfType<StandardTournament>().ToArray());
            }
        }

        private void listBoxTorneioNormal_SelectedIndexChanged(object sender, EventArgs e)
        {
            torneioNormalSelecionado = (StandardTournament)listBoxTorneioNormal.SelectedItem;
        }
    }
}
