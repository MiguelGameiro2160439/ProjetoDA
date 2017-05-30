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
        Model1Container container;
        public TeamGame NovoJogoEquipa { get; private set; }

        public FormJogos(Model1Container container)
        {
            InitializeComponent();
            this.container = container;

            if (container != null)
            {
                comboBoxBaralho1.Items.AddRange(container.DeckSet.ToArray());
                comboBoxBaralho2.Items.AddRange(container.DeckSet.ToArray());
                comboBoxEquipa1.Items.AddRange(container.TeamSet.ToArray());
                comboBoxEquipa2.Items.AddRange(container.TeamSet.ToArray());
                comboBoxTorneio.Items.AddRange(container.TournamentSet.OfType<TeamTournament>().ToArray());
                comboBoxArbitro.Items.AddRange(container.UserSet.OfType<Referee>().ToArray());

            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Deck baralho1 = null;
            Deck baralho2 = null;
            Team equipa1 = null;
            Team equipa2 = null;
            TeamTournament torneio = null;
            Referee arbitro = null;


            if (comboBoxBaralho1.SelectedIndex > -1)
            {
                baralho1 = (Deck)comboBoxBaralho1.SelectedItem;
            }

            if (comboBoxBaralho2.SelectedIndex > -1)
            {
                baralho2 = (Deck)comboBoxBaralho2.SelectedItem;
            }

            if (comboBoxBaralho2.SelectedIndex > -1)
            {
                equipa1 = (Team)comboBoxEquipa1.SelectedItem;
            }

            if (comboBoxBaralho2.SelectedIndex > -1)
            {
                equipa2 = (Team)comboBoxEquipa2.SelectedItem;
            }

            if (comboBoxTorneio.SelectedIndex > -1)
            {
                torneio = (TeamTournament)comboBoxTorneio.SelectedItem;
            }

            if (comboBoxArbitro.SelectedIndex > -1)
            {
                arbitro = (Referee)comboBoxArbitro.SelectedItem;
            }

            NovoJogoEquipa = new TeamGame();

            NovoJogoEquipa.Number = (int)numericUpDownNum.Value;
            NovoJogoEquipa.Date = dateTimePickerData.Value;
            NovoJogoEquipa.Description = textBoxDescricao.Text.Trim();
            NovoJogoEquipa.DeckOne = baralho1;
            NovoJogoEquipa.DeckTwo = baralho2;
            NovoJogoEquipa.TeamOne = equipa1;
            NovoJogoEquipa.TeamTwo = equipa2;
            NovoJogoEquipa.Tournament = torneio;
            NovoJogoEquipa.Referee = arbitro;


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
