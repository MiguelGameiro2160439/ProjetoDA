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
        private string ficheiro;
        private Model1Container container;
        private Tournament torneioSelecionado;

        public TabelaTorneios()
        {
            InitializeComponent();

            container = new Model1Container();
            ficheiro = null;

            refreshListaCards();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormTorneios form = new FormTorneios();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarCarta(form.NovoTorneio);
            }
        }

        private void AdicionarCarta(Tournament torneio)
        {
            container.TournamentSet.Add(torneio);
            container.SaveChanges();
            refreshListaCards();
        }

        private void refreshListaCards()
        {
            listBoxTorneios.Items.Clear();
            listBoxTorneios.Items.AddRange(container.TournamentSet.ToArray());
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            torneioSelecionado = (Tournament)listBoxTorneios.SelectedItem;

            if (torneioSelecionado != null)
            {
                //remover
                torneioSelecionado = (Tournament)listBoxTorneios.SelectedItem;

                container.TournamentSet.Remove(torneioSelecionado);

                container.SaveChanges();


                listBoxTorneios.Items.AddRange(container.TournamentSet.ToArray());

                //insere
                FormCartas form = new FormCartas();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarCarta(form.NovoTorneio);
                }
            }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            torneioSelecionado = (Tournament)listBoxTorneios.SelectedItem;

            container.TournamentSet.Remove(torneioSelecionado);

            container.SaveChanges();

            listBoxTorneios.Items.Clear();
            listBoxTorneios.Items.AddRange(container.CardSet.ToArray());
        }

        private void listBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            torneioSelecionado = (Tournament)listBoxTorneios.SelectedItem;
        }
    }
}
