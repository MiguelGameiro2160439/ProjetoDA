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
    public partial class VistaArbitro : Form
    {
        private Model1Container mcontainer;
        private Game gameSelected;
        private Referee userSelecionado;

        public VistaArbitro(Referee user)
        {
            InitializeComponent();
            mcontainer = new Model1Container();
            userSelecionado = user;
            atualizarLista();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            gameSelected.Number = (int)numericUpDownNum.Value;
            gameSelected.Date = (DateTime)dateTimePickerData.Value;
            gameSelected.Description = textBoxDescricao.Text;
            gameSelected.DeckOne = (Deck)comboBoxBaralho1.SelectedItem;
            gameSelected.DeckTwo = (Deck)comboBoxBaralho2.SelectedItem;

            mcontainer.SaveChanges();
            atualizarLista();
            limparCampos();
        }

        private void atualizarLista()
        {
            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(userSelecionado.Games.ToArray());
        }

        private void limparCampos()
        {
            gameSelected = null;
            textBoxDescricao.Text = "";
            numericUpDownNum.Value = 0;
            comboBoxBaralho1.SelectedItem = null;
            comboBoxBaralho2.SelectedItem = null;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxJogos.SelectedIndex >= 0)
            {
                gameSelected = (Game)listBoxJogos.SelectedItem;
                numericUpDownNum.Value = gameSelected.Number;
                dateTimePickerData.Value = gameSelected.Date;
                textBoxDescricao.Text = gameSelected.Description;
                comboBoxBaralho1.SelectedItem = gameSelected.DeckOne;
                comboBoxBaralho2.SelectedItem = gameSelected.DeckTwo;
            }
        }

       
    }
}
