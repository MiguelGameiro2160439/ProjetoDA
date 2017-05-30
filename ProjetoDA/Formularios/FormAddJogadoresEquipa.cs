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
    public partial class FormAddJogadoresEquipa : Form
    {
        private Model1Container container;
        private Player jogadorSelecionado;
        private Team equipaSelecionada;

        public FormAddJogadoresEquipa()
        {
            InitializeComponent();
            container = new Model1Container();
            refreshList();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (listBoxEquipas.SelectedIndex >= 0)
            {
                if (listBoxJogadores.SelectedIndex >= 0)
                {
                    equipaSelecionada = (Team)listBoxEquipas.SelectedItem;
                    jogadorSelecionado = (Player)listBoxJogadores.SelectedItem;

                    if (listBoxJogadoresEquipas.Items.Count < 2)
                    {

                        equipaSelecionada.Players.Add(jogadorSelecionado);
                        container.SaveChanges();

                        listBoxJogadoresEquipas.Items.Clear();
                        listBoxJogadoresEquipas.Items.AddRange(equipaSelecionada.Players.ToArray());
                    }
                    else
                    {
                        MessageBox.Show("Não pode adicionar mais de 2 jogadores a uma equipa");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione uma Jogador");
                }
            }
            else
            {
                MessageBox.Show("Seleccione uma Equipa");
            }
        }

        private void refreshList()
        {
            listBoxJogadores.Items.Clear();
            listBoxEquipas.Items.Clear();
            listBoxJogadoresEquipas.Items.Clear();
            listBoxJogadores.Items.AddRange(container.PlayerSet.ToArray());
            listBoxEquipas.Items.AddRange(container.TeamSet.ToArray());
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxEquipas.SelectedIndex >= 0)
            {
                if (listBoxJogadoresEquipas.SelectedIndex >= 0)
                {
                    equipaSelecionada = (Team)listBoxEquipas.SelectedItem;
                    jogadorSelecionado = (Player)listBoxJogadoresEquipas.SelectedItem;

                    equipaSelecionada.Players.Remove(jogadorSelecionado);
                    container.SaveChanges();

                    listBoxJogadoresEquipas.Items.Clear();
                    listBoxJogadoresEquipas.Items.AddRange(equipaSelecionada.Players.ToArray());
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            equipaSelecionada = (Team)listBoxEquipas.SelectedItem;
            listBoxJogadoresEquipas.Items.Clear();
            listBoxJogadoresEquipas.Items.AddRange(equipaSelecionada.Players.ToArray());
        }
    }
}
