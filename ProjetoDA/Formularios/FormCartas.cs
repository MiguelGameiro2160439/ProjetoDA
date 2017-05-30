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

        //Envia os dados para a tabela cartas para posterior save na base de dados. 
        private void buttonOK_Click(object sender, EventArgs e)
        {
            NovaCarta = new Card();

            try
            {
                NovaCarta.Name = textBoxNome.Text.Trim();
                NovaCarta.Faction = comboBoxFacao.SelectedItem.ToString();
                NovaCarta.Type = comboBoxTipo.SelectedItem.ToString();
                NovaCarta.Cost = textBoxCusto.Text.Trim();
                NovaCarta.Loyalty = (int)numericUpDownLealdade.Value;
                NovaCarta.RuleText = textBoxRegras.Text.Trim();
                NovaCarta.Attack = (int)numericUpDownAtaque.Value;
                NovaCarta.Defense = (int)numericUpDownDefesa.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Todos os campos com * são obrigatórios");
            }

           
        }
    }
}
