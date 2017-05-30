using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class TabelaCartas : Form
    {
        private Model1Container container;
        private Card cartaSelecionada;
        private List<Card> cartas;

        public TabelaCartas()
        {
            InitializeComponent();

            cartas = new List<Card>();

            container = new Model1Container();

            refreshListaCards();
        }

        //Mostra a vista e recebe os dados do form cartas.
        private void buttonAdicionarCarta_Click(object sender, EventArgs e)
        {
            FormCartas form = new FormCartas();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarCarta(form.NovaCarta);
            }
        }
        //Guarda a nova carta na base de dados.
        private void AdicionarCarta(Card carta)
        {
            container.CardSet.Add(carta);
            container.SaveChanges();
            refreshListaCards();
        }

        //Atualiza a lista de cartas.
        private void refreshListaCards()
        {
            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.CardSet.ToArray());
        }

        //Remove a carta selecionada.
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            container.CardSet.Remove(cartaSelecionada);

            container.SaveChanges();

            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(container.CardSet.ToArray());
        }

        private void listBoxCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartaSelecionada = (Card)listBoxCartas.SelectedItem;
        }

        //Edita a carta selecionada.
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            cartaSelecionada = (Card)listBoxCartas.SelectedItem;

            if (cartaSelecionada != null)
            {
                //remover
                cartaSelecionada = (Card)listBoxCartas.SelectedItem;

                container.CardSet.Remove(cartaSelecionada);

                container.SaveChanges();

                
                listBoxCartas.Items.AddRange(container.CardSet.ToArray());

                //insere
                 FormCartas form = new FormCartas();
                 DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarCarta(form.NovaCarta);
                }
             
            }
              
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoMsgBox = "Operação cancelada.";
            string tituloMsgBox = "Cancelado";

            if (openFileDialogCartas.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(openFileDialogCartas.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        cartas = (List<Card>)formatter.Deserialize(stream);

                        textoMsgBox = String.Format("Dados das cartas carregados. {0} cartas lidas.");
                        tituloMsgBox = "Dados Lidos";
                       

                        refreshListaCards();
                    }
                    catch (InvalidCastException ex)
                    {
                        textoMsgBox = "Não foi possível converter os dados guadados no ficheiro. O ficheiro não contém uma versão correta das classes." + ex.Message;
                        tituloMsgBox = "Erro de Leitura";
                    }
                }
            }

            MessageBox.Show(textoMsgBox, tituloMsgBox, MessageBoxButtons.OK);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoMsgBox = "Operação cancelada.";
            string tituloMsgBox = "Cancelado";

            if (saveFileDialogCartas.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(saveFileDialogCartas.FileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    try
                    {
                        formatter.Serialize(stream, cartas);
                        stream.Flush();                        

                        textoMsgBox = "Dados guardados com sucesso!";
                        tituloMsgBox = "Dados Guardados";
                    }
                    catch (Exception ex)
                    {
                        textoMsgBox = "Não foi possível guardar os dados no ficheiro indicado. " + ex.Message;
                        tituloMsgBox = "Erro de Escrita";
                    }
                }
            }

            MessageBox.Show(textoMsgBox, tituloMsgBox, MessageBoxButtons.OK);
        }
    }
}
