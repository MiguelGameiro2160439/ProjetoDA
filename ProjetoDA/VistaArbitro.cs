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
        private Referee ArbitroSelected;
        private Game GameSelected;

        public VistaArbitro()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
            atualizarLista();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxJogos.SelectedIndex >= 0)
            {
                GameSelected = (Game)listBoxJogos.SelectedItem;
                numericUpDownNum.Value = GameSelected.Number;
                dateTimePickerData.Value = GameSelected.Date;
                textBoxDescricao.Text = GameSelected.Description;
                comboBoxBaralho1.SelectedItem = GameSelected.DeckOne;
                comboBoxBaralho2.SelectedItem = GameSelected.DeckTwo;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GameSelected.Number = (int)numericUpDownNum.Value;
            GameSelected.Date = (DateTime)dateTimePickerData.Value;
            GameSelected.Description = textBoxDescricao.Text;
            GameSelected.DeckOne = (Deck)comboBoxBaralho1.SelectedItem;
            GameSelected.DeckTwo = (Deck)comboBoxBaralho2.SelectedItem;

            mcontainer.SaveChanges();
        }

        private void atualizarLista()
        {
            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(mcontainer.GameSet.ToArray());
        }

        private void limparCampos()
        {
            GameSelected = null;
            textBoxDescricao.Text = "";
            numericUpDownNum.Value = 0;
            comboBoxBaralho1.SelectedItem = null;
            comboBoxBaralho2.SelectedItem = null;
        }
    }
}
