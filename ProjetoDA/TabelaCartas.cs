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
    public partial class TabelaCartas : Form
    {
        private string ficheiro;
        private Model1Container container;

        public TabelaCartas()
        {
            InitializeComponent();
            container = new Model1Container();
            ficheiro = null;

            refreshListaCards();
        }

        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            FormCartas form = new FormCartas();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarCarta(form.NovaCarta);
            }
        }

        private void AdicionarCarta(Card carta)
        {
            container.CardSet.Add(carta);
            container.SaveChanges();
            refreshListaCards();
        }

       private void refreshListaCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.CardSet.ToArray());
        }
    }
}
