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
    public partial class FormJogos : Form
    {
        public Game NovoJogo { get; private set; }
        public FormJogos(TabelaBaralho baralhos)
        {
            InitializeComponent();

            if (baralhos != null)
            {
                comboBoxBaralho1.Items.AddRange(baralhos.ListaBaralho().ToArray());
                comboBoxBaralho2.Items.AddRange(baralhos.ListaBaralho().ToArray());
                
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

            NovoJogo = new Game();

            NovoJogo.Number = (int)numericUpDownNum.Value;
            NovoJogo.Date = dateTimePickerData.Value;
            NovoJogo.Description = textBoxDescricao.Text.Trim();
            NovoJogo.DeckOne = baralho1;
            NovoJogo.DeckTwo = baralho2;

           
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
