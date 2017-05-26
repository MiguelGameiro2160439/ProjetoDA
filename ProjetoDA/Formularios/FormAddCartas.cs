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

        private void refreshList()
        {
            listBoxCartas.Items.Clear();
            listBoxBaralho.Items.Clear();
            listBoxCartasBaralho.Items.Clear();
            listBoxCartas.Items.AddRange(mcontainer.CardSet.ToArray());
            listBoxBaralho.Items.AddRange(mcontainer.DeckSet.ToArray());
        }

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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            listBoxCartasBaralho.Items.Clear();
            listBoxCartasBaralho.Items.AddRange(selectedDeck.Cards.ToArray());
        }
    }
}
