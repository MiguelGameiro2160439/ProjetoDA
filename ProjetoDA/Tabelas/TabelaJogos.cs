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

        public TabelaJogos(Model1Container container)
        {
            InitializeComponent();

            container = new Model1Container();
            ficheiro = null;

            refreshListaJogos();
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

        private void refreshListaJogos()
        {
            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(container.GameSet.ToArray());
        }

        private void AdicionarJogo(Game jogo)
        {
            container.GameSet.Add(jogo);
            container.SaveChanges(); 
            refreshListaJogos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
