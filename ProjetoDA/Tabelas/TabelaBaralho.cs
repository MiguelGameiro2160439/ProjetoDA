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

        //Cria um novo baralho.
        private void buttonInserirBaralho_Click(object sender, EventArgs e)
        {
            NovoBaralho = new Deck();

            NovoBaralho.Name = textBoxNome.Text.Trim();

            container.DeckSet.Add(NovoBaralho);
            container.SaveChanges();
            refreshListaBaralho();
        }

        //Atualiza a lista de baralhos.
        private void refreshListaBaralho()
        {
            listBoxBaralho.Items.Clear();
            listBoxBaralho.Items.AddRange(container.DeckSet.ToArray());
        }

        //Remove o baralhos selecionado.
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

        //Edição de baralho.
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

        public List<Deck> ListaBaralho()
        {
            return container.DeckSet.ToList();
        }

        //Mostra vista para adicionar cartas ao baralho.
        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            FormAddCartas newForm = new FormAddCartas();
            newForm.ShowDialog();
        }
    }
}
