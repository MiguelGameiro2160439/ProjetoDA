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
        private Tournament torneioSelecionado;

        public TabelaTorneios()
        {
            InitializeComponent();

            container = new Model1Container();

            refreshListaTorneio();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormTorneios form = new FormTorneios();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarTorneio(form.NovoTorneio);
            }
        }

        private void AdicionarTorneio(Tournament torneio)
        {
            container.TournamentSet.Add(torneio);
            container.SaveChanges();
            refreshListaTorneio();
        }

        private void refreshListaTorneio()
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
                FormTorneios form = new FormTorneios();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarTorneio(form.NovoTorneio);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            torneioSelecionado = (Tournament)listBoxTorneios.SelectedItem;

            container.TournamentSet.Remove(torneioSelecionado);

            container.SaveChanges();

            listBoxTorneios.Items.Clear();
            listBoxTorneios.Items.AddRange(container.TournamentSet.ToArray());
        }

        private void listBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            torneioSelecionado = (Tournament)listBoxTorneios.SelectedItem;
        }
    }
}
