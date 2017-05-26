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
    public partial class FormJogoNormal : Form
    {
        Model1Container container;
        public StandardGame NovoJogoNormal { get; private set; }

        public FormJogoNormal(Model1Container container)
        {
            InitializeComponent();
            this.container = container;

            if (container != null)
            {
                comboBoxBaralho1.Items.AddRange(container.DeckSet.ToArray());
                comboBoxBaralho2.Items.AddRange(container.DeckSet.ToArray());

            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Deck baralho1 = null;
            Deck baralho2 = null;


            if (comboBoxBaralho1.SelectedIndex > -1)
            {
                baralho1 = (Deck)comboBoxBaralho1.SelectedItem;
            }

            if (comboBoxBaralho2.SelectedIndex > -1)
            {
                baralho2 = (Deck)comboBoxBaralho2.SelectedItem;
            }

            NovoJogoNormal = new StandardGame();

            NovoJogoNormal.Number = (int)numericUpDownNum.Value;
            NovoJogoNormal.Date = dateTimePickerData.Value;
            NovoJogoNormal.Description = textBoxDescricao.Text.Trim();
            NovoJogoNormal.DeckOne = baralho1;
            NovoJogoNormal.DeckTwo = baralho2;


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
