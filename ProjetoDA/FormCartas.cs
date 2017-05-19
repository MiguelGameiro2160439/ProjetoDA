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
    public partial class FormCartas : Form
    {

        public Card NovaCarta { get; private set; }


        public FormCartas()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NovaCarta = new Card();

            NovaCarta.Name = textBoxNome.Text;
            NovaCarta.Faction = comboBoxFacao.SelectedItem.ToString();
            NovaCarta.Type = comboBoxTipo.SelectedItem.ToString();
            NovaCarta.Cost = textBoxCusto.Text;
            NovaCarta.Loyalty = (int)numericUpDownLealdade.Value;
            NovaCarta.RuleText = textBoxRegras.Text;
            NovaCarta.Attack = (int)numericUpDownAtaque.Value;
            NovaCarta.Defense = (int)numericUpDownDefesa.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
