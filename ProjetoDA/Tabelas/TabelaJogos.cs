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
    public partial class TabelaJogos : Form
    {
        private Model1Container container;
        private TeamGame jogoEquipaSelecionado;
        private StandardGame jogoNomralSelecionado;

        public TabelaJogos()
        {
            InitializeComponent();

            this.container = new Model1Container();

            refreshListajogoEquipa();
            refreshListajogoNormal();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormJogos form = new FormJogos(this.container);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarJogoEquipa(form.NovoJogoEquipa);
            }
        }

        private void refreshListajogoEquipa()
        {
            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(container.GameSet.OfType<TeamGame>().ToArray());
        }

        private void refreshListajogoNormal()
        {
            listBoxJogosStandard.Items.Clear();
            listBoxJogosStandard.Items.AddRange(container.GameSet.OfType<StandardGame>().ToArray());
        }

        private void AdicionarJogoEquipa(TeamGame jogoEquipa)
        {
            container.GameSet.Add(jogoEquipa);
            container.SaveChanges();
            refreshListajogoEquipa();
        }

        private void AdicionarNormal(StandardGame jogoNormal)
        {
            container.GameSet.Add(jogoNormal);
            container.SaveChanges();
            refreshListajogoEquipa();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            jogoEquipaSelecionado = (TeamGame)listBoxJogos.SelectedItem;

            if (jogoEquipaSelecionado != null)
            {
                //remover
                jogoEquipaSelecionado = (TeamGame)listBoxJogos.SelectedItem;

                container.GameSet.Remove(jogoEquipaSelecionado);

                container.SaveChanges();


                listBoxJogos.Items.AddRange(container.GameSet.OfType<TeamGame>().ToArray());

                //insere
                FormJogos form = new FormJogos(this.container);
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarJogoEquipa(form.NovoJogoEquipa);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            jogoEquipaSelecionado = (TeamGame)listBoxJogos.SelectedItem;

            container.GameSet.Remove(jogoEquipaSelecionado);

            container.SaveChanges();

            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(container.GameSet.OfType<TeamGame>().ToArray());
        }

        private void listBoxJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            jogoEquipaSelecionado = (TeamGame)listBoxJogos.SelectedItem;
        }

        private void buttonAdicionarStandard_Click(object sender, EventArgs e)
        {
            FormJogoNormal form = new FormJogoNormal(this.container);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarNormal(form.NovoJogoNormal);
            }
        }

        private void buttonRemoverJogoNormal_Click(object sender, EventArgs e)
        {
            jogoNomralSelecionado = (StandardGame)listBoxJogosStandard.SelectedItem;

            container.GameSet.Remove(jogoNomralSelecionado);

            container.SaveChanges();

            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(container.GameSet.OfType<StandardGame>().ToArray());
        }

        private void listBoxJogosStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            jogoNomralSelecionado = (StandardGame)listBoxJogosStandard.SelectedItem;
        }

        private void buttonEditarStandard_Click(object sender, EventArgs e)
        {
            jogoNomralSelecionado = (StandardGame)listBoxJogosStandard.SelectedItem;

            if (jogoNomralSelecionado != null)
            {
                //remover
                jogoNomralSelecionado = (StandardGame)listBoxJogosStandard.SelectedItem;

                container.GameSet.Remove(jogoNomralSelecionado);

                container.SaveChanges();


                listBoxJogosStandard.Items.AddRange(container.GameSet.OfType<StandardGame>().ToArray());

                //insere
                FormJogoNormal form = new FormJogoNormal(this.container);
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarNormal(form.NovoJogoNormal);
                }
            }
        }
    }
}
