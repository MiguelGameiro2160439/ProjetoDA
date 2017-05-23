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
    public partial class TabelaBaralho : Form
    {
        private Model1Container container;
        public Deck NovoBaralho { get; private set; }
        public TabelaBaralho()
        {
            InitializeComponent();

            container = new Model1Container();

            refreshListaBaralho();
        }

        private void buttonInserirBaralho_Click(object sender, EventArgs e)
        {
            NovoBaralho = new Deck();

            NovoBaralho.Name = textBoxNome.Text.Trim();

            container.DeckSet.Add(NovoBaralho);
            container.SaveChanges();
            refreshListaBaralho();
        }

        private void refreshListaBaralho()
        {
            listBoxBaralho.Items.Clear();
            listBoxBaralho.Items.AddRange(container.DeckSet.ToArray());
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Deck BaralhoSelecionado = (Deck)listBoxBaralho.SelectedItem;

            container.DeckSet.Remove(BaralhoSelecionado);

            container.SaveChanges();

            listBoxBaralho.Items.Clear();
            listBoxBaralho.Items.AddRange(container.DeckSet.ToArray());
        }

        private void listBoxBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deck BaralhoSelecionado = (Deck)listBoxBaralho.SelectedItem;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Deck BaralhoSelecionado = (Deck)listBoxBaralho.SelectedItem;

            if (BaralhoSelecionado != null)
            {
                //remover
                BaralhoSelecionado = (Deck)listBoxBaralho.SelectedItem;

                container.DeckSet.Remove(BaralhoSelecionado);

                container.SaveChanges();


                listBoxBaralho.Items.AddRange(container.DeckSet.ToArray());

                //insere
                FormCartas form = new FormCartas();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    NovoBaralho = new Deck();

                    NovoBaralho.Name = textBoxNome.Text.Trim();

                    container.DeckSet.Add(NovoBaralho);
                    refreshListaBaralho();
                }

            }
        }
    }
}
