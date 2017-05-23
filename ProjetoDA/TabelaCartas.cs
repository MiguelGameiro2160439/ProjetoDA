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
    public partial class TabelaCartas : Form
    {
        private string ficheiro;
        private Model1Container container;
        private Card cartaSelecionada;

        public TabelaCartas()
        {
            InitializeComponent();

            container = new Model1Container();
            ficheiro = null;

            refreshListaCards();
        }

        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            FormCartas form = new FormCartas();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarCarta(form.NovaCarta);
            }
        }

        private void AdicionarCarta(Card carta)
        {
            container.CardSet.Add(carta);
            container.SaveChanges();
            refreshListaCards();
        }

        private void refreshListaCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.CardSet.ToArray());
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            container.CardSet.Remove(cartaSelecionada);

            container.SaveChanges();

            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.CardSet.ToArray());
        }

        private void listBoxCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartaSelecionada = (Card)listBoxCartas.SelectedItem;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            if (cartaSelecionada != null)
            {
                //remover
                cartaSelecionada = (Card)listBoxCartas.SelectedItem;

                container.CardSet.Remove(cartaSelecionada);

                container.SaveChanges();

                
                listBoxCartas.Items.AddRange(container.CardSet.ToArray());

                //insere
                 FormCartas form = new FormCartas();
                 DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarCarta(form.NovaCarta);
                }
             
            }
              
            
        }

        private void TabelaCartas_Load(object sender, EventArgs e)
        {

        }
    }
}
