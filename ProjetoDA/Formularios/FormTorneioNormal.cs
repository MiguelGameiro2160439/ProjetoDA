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
    public partial class FormTorneioNormal : Form
    {
        public StandardTournament NovoTorneioNormal { get; private set; }

        public FormTorneioNormal()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NovoTorneioNormal = new StandardTournament();

            NovoTorneioNormal.Name = textBoxNome.Text.Trim();
            NovoTorneioNormal.Date = dateTimePickerData.Value;
            NovoTorneioNormal.Description = textBoxDescricao.Text.Trim();


            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
