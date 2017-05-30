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
    public partial class FormEquipas : Form
    {

        public Team NovaEquipa { get; private set; }

    public FormEquipas()
        {
            InitializeComponent();
        }

        //Abre um fileDialog para adquirir o URL da imagem.
        private void buttonProcAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.CheckFileExists)
            {
                textBoxAvatar.Text = openFileDialog1.FileName;
            }

            openFileDialog1 = null;
        }

        //Envia os dados para a tabela equipas para posterior save na base de dados. 
        private void buttonOK_Click(object sender, EventArgs e)
        {
            NovaEquipa = new Team();

            NovaEquipa.Name = textBoxNome.Text.Trim();
            NovaEquipa.Avatar = textBoxAvatar.Text.Trim();
            

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
