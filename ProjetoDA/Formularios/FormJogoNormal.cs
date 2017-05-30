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
                comboBoxJogador1.Items.AddRange(container.PlayerSet.ToArray());
                comboBoxJogador2.Items.AddRange(container.PlayerSet.ToArray());
                comboBoxTorneio.Items.AddRange(container.TournamentSet.OfType<StandardTournament>().ToArray());
               

            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Deck baralho1 = null;
            Deck baralho2 = null;
            Player jogador1 = null;
            Player jogador2 = null;
            StandardTournament torneio = null;

            if (comboBoxBaralho1.SelectedIndex > -1)
            {
                baralho1 = (Deck)comboBoxBaralho1.SelectedItem;
            }

            if (comboBoxBaralho2.SelectedIndex > -1)
            {
                baralho2 = (Deck)comboBoxBaralho2.SelectedItem;
            }

            if (comboBoxJogador1.SelectedIndex > -1)
            {
                jogador1 = (Player)comboBoxJogador1.SelectedItem;
            }

            if (comboBoxJogador2.SelectedIndex > -1)
            {
                jogador2 = (Player)comboBoxJogador2.SelectedItem;
            }

            if (comboBoxTorneio.SelectedIndex > -1)
            {
                torneio = (StandardTournament)comboBoxTorneio.SelectedItem;
            }
            NovoJogoNormal = new StandardGame();

            try
            {
                NovoJogoNormal.Number = (int)numericUpDownNum.Value;
                NovoJogoNormal.Date = dateTimePickerData.Value;
                NovoJogoNormal.Description = textBoxDescricao.Text.Trim();
                NovoJogoNormal.DeckOne = baralho1;
                NovoJogoNormal.DeckTwo = baralho2;
                NovoJogoNormal.PlayerOne = jogador1;
                NovoJogoNormal.PlayerTwo = jogador2;
                NovoJogoNormal.Tournament = torneio;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Todos os campos com * são obrigatórios");
            }

            
        }

        private void FormJogoNormal_Load(object sender, EventArgs e)
        {

        }
    }
}
