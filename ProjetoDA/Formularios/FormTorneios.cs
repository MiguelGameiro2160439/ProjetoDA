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
    public partial class FormTorneios : Form
    {
        public Tournament NovoTorneio { get; private set; }

        public FormTorneios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoTorneio = new Tournament();

            NovoTorneio.Name = textBoxNome.Text.Trim();
            NovoTorneio.Date = dateTimePickerData.Value;
            NovoTorneio.Description = textBoxDescricao.Text.Trim();
          

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
