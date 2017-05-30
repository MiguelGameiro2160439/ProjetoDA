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
    public partial class TabelaEquipas : Form
    {
        private Model1Container container;
        private Team equipaSelecionada;

        public TabelaEquipas()
        {
            InitializeComponent();

            container = new Model1Container();

            refreshListaEquipas();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormEquipas form = new FormEquipas();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarCarta(form.NovaEquipa);
            }
        }

        private void AdicionarCarta(Team team)
        {
            container.TeamSet.Add(team);
            container.SaveChanges();
            refreshListaEquipas();
        }

        private void refreshListaEquipas()
        {
            listBoxEquipas.Items.Clear();
            listBoxEquipas.Items.AddRange(container.TeamSet.ToArray());
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            equipaSelecionada = (Team)listBoxEquipas.SelectedItem;

            if (equipaSelecionada != null)
            {
                //remover
                equipaSelecionada = (Team)listBoxEquipas.SelectedItem;

                container.TeamSet.Remove(equipaSelecionada);

                container.SaveChanges();

                listBoxEquipas.Items.Clear();
                listBoxEquipas.Items.AddRange(container.TeamSet.ToArray());

                //insere
                FormEquipas form = new FormEquipas();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarCarta(form.NovaEquipa);
                }

            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            equipaSelecionada = (Team)listBoxEquipas.SelectedItem;

            container.TeamSet.Remove(equipaSelecionada);

            container.SaveChanges();

            listBoxEquipas.Items.Clear();
            listBoxEquipas.Items.AddRange(container.TeamSet.ToArray());
        }

        private void listBoxEquipas_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipaSelecionada = (Team)listBoxEquipas.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddJogadoresEquipa newForm = new FormAddJogadoresEquipa();
            newForm.ShowDialog();
        }
    }
}
