using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class EditArbitro : Form
    {

        private Model1Container mcontainer;
        private Referee arbitroSelected;

        public EditArbitro()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
            atualizarLista();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            if (arbitroSelected == null)
            {
                //Cria arbitro se não estiver nenhum selecionado.
                Referee newArbitro = new Referee();
                newArbitro.Name = textBoxName.Text;
                newArbitro.Username = textBoxUsername.Text;
                newArbitro.Password = textBoxPassword.Text;
                newArbitro.Avatar = textBoxAvatar.Text;

                mcontainer.UserSet.Add(newArbitro);
                mcontainer.SaveChanges();
                atualizarLista();
                limparCampos();
            }
            else
            {
                //Edita arbitro selecionado.
                arbitroSelected.Name = textBoxName.Text;
                arbitroSelected.Username = textBoxUsername.Text;
                arbitroSelected.Password = textBoxPassword.Text;
                arbitroSelected.Avatar = textBoxAvatar.Text;

                mcontainer.SaveChanges();
                atualizarLista();
                limparCampos();
            }
            
        }

        private void atualizarLista()
        { 
            //Atualiza a listBox dos arbitros.
            listBoxArbitros.Items.Clear();
            listBoxArbitros.Items.AddRange(mcontainer.UserSet.OfType<Referee>().ToArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxArbitros.SelectedIndex >= 0)
            {
                //Apaga arbitro selecionado.
                arbitroSelected = (Referee)listBoxArbitros.SelectedItem;
                mcontainer.UserSet.Remove(arbitroSelected);
                limparCampos();
                atualizarLista();
            }
        }

        private void limparCampos()
        {
            //Limpa campos.
            arbitroSelected = null;
            textBoxName.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxAvatar.Text = "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxArbitros.SelectedIndex >= 0)
            {
                //Preenche todos os campos com os dados do arbitro selecionado, para posterior edição.
                arbitroSelected = (Referee)listBoxArbitros.SelectedItem;
                textBoxName.Text = arbitroSelected.Name;
                textBoxUsername.Text = arbitroSelected.Username;
                textBoxPassword.Text = arbitroSelected.Password;
                textBoxAvatar.Text = arbitroSelected.Avatar;
            }
        }

        private void buttonProcuraAvatar_Click(object sender, EventArgs e)
        {
            //Abre um fileDialog para adquirir o URL da imagem.
            openFileDialog1.ShowDialog();

            if (openFileDialog1.CheckFileExists)
            {
                textBoxAvatar.Text = openFileDialog1.FileName;
            }

            openFileDialog1 = null;
        }
    }
}
