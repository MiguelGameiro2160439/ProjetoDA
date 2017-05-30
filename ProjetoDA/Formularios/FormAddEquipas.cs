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
    public partial class FormAddEquipas : Form
    {
        private Model1Container container;
        private TeamTournament torneioEquipasSelecionado;
        private Team equipaSelecionada;

        public FormAddEquipas()
        {
            InitializeComponent();
            container = new Model1Container();
            refreshList();
        }

        //Atualiza as listBoxs.
        private void refreshList()
        {
            listBoxEquipas.Items.Clear();
            listBoxTorneio.Items.Clear();
            listBoxEquipasTorneio.Items.Clear();
            listBoxEquipas.Items.AddRange(container.PlayerSet.ToArray());
            listBoxTorneio.Items.AddRange(container.TournamentSet.ToArray());
        }

        //Adiciona as equipas ao torneio.
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (listBoxTorneio.SelectedIndex >= 0)
            {
                if (listBoxEquipas.SelectedIndex >= 0)
                {
                    torneioEquipasSelecionado = (TeamTournament)listBoxTorneio.SelectedItem;
                    equipaSelecionada = (Team)listBoxEquipas.SelectedItem;

                    torneioEquipasSelecionado.Teams.Add(equipaSelecionada);
                    container.SaveChanges();

                    listBoxEquipasTorneio.Items.Clear();
                    listBoxEquipasTorneio.Items.AddRange(torneioEquipasSelecionado.Teams.ToArray());
                }
                else
                {
                    MessageBox.Show("Seleccione uma equipa");
                }
            }
            else
            {
                MessageBox.Show("Seleccione um torneio");
            }
        }

        //Remove as equipas selecionadas que estavam inseridas no respetivo torneio.
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTorneio.SelectedIndex >= 0)
            {
                if (listBoxEquipasTorneio.SelectedIndex >= 0)
                {
                    equipaSelecionada = (Team)listBoxEquipas.SelectedItem;
                    torneioEquipasSelecionado = (TeamTournament)listBoxEquipasTorneio.SelectedItem;

                    torneioEquipasSelecionado.Teams.Remove(equipaSelecionada);
                    container.SaveChanges();

                    listBoxEquipasTorneio.Items.Clear();
                    listBoxEquipasTorneio.Items.AddRange(torneioEquipasSelecionado.Teams.ToArray());
                }
            }
        }

        //Atualiza a lista de jogadores do torneio selecionado.
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            torneioEquipasSelecionado = (TeamTournament)listBoxTorneio.SelectedItem;
            listBoxEquipasTorneio.Items.Clear();
            listBoxEquipasTorneio.Items.AddRange(torneioEquipasSelecionado.Teams.ToArray());
        }
    }
}
