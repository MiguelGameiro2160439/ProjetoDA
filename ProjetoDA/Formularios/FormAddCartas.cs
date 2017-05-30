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
    public partial class FormAddCartas : Form
    {

        private Model1Container mcontainer;
        private Deck selectedDeck;
        private Card selectedCard;

        public FormAddCartas()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
            refreshList();
        }

        //Adiciona carta selecionada ao baralho selecionado.
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (listBoxBaralho.SelectedIndex >= 0)
            {
                if (listBoxCartas.SelectedIndex >= 0)
                {
                    selectedDeck = (Deck)listBoxBaralho.SelectedItem;
                    selectedCard = (Card)listBoxCartas.SelectedItem;

                    selectedDeck.Cards.Add(selectedCard);
                    mcontainer.SaveChanges();

                    listBoxCartasBaralho.Items.Clear();
                    listBoxCartasBaralho.Items.AddRange(selectedDeck.Cards.ToArray());
                }
                else
                {
                    MessageBox.Show("Seleccione uma carta");
                }
            }
            else
            {
                MessageBox.Show("Seleccione um baralho");
            }
        }

        //Atualiza as listBoxs.
        private void refreshList()
        {
            listBoxCartas.Items.Clear();
            listBoxBaralho.Items.Clear();
            listBoxCartasBaralho.Items.Clear();
            listBoxCartas.Items.AddRange(mcontainer.CardSet.ToArray());
            listBoxBaralho.Items.AddRange(mcontainer.DeckSet.ToArray());
        }

        //Remove as cartas selecionadas que estavam inseridas no respetivo baralho.
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxBaralho.SelectedIndex >= 0) 
            {
                if (listBoxCartasBaralho.SelectedIndex >= 0)
                {
                    selectedDeck = (Deck)listBoxBaralho.SelectedItem;
                    selectedCard = (Card)listBoxCartasBaralho.SelectedItem;

                    selectedDeck.Cards.Remove(selectedCard);
                    mcontainer.SaveChanges();

                    listBoxCartasBaralho.Items.Clear();
                    listBoxCartasBaralho.Items.AddRange(selectedDeck.Cards.ToArray());
                }
            }
        }

        //Atualiza a listBox que apresenta as cartas contidas no baralho.
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectedDeck = (Deck)listBoxBaralho.SelectedItem;
            listBoxCartasBaralho.Items.Clear();
            listBoxCartasBaralho.Items.AddRange(selectedDeck.Cards.ToArray());
        }
    }
}
