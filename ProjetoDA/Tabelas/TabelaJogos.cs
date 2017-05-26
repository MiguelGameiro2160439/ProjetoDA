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

        public TabelaJogos()
        {
            InitializeComponent();

            this.container = new Model1Container();


            refreshListajogoEquipa();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormJogos form = new FormJogos(this.container);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarJogo(form.NovoJogo);
            }
        }

        private void refreshListajogoEquipa()
        {
            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(container.GameSet.ToArray());
        }

        private void AdicionarJogo(TeamGame jogoEquipa)
        {
            container.GameSet.Add(jogoEquipa);
            container.SaveChanges();
            refreshListajogoEquipa();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
