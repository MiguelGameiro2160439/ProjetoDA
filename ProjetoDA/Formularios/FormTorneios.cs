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
        public TeamTournament NovoTorneioEquipa { get; private set; }

        public FormTorneios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoTorneioEquipa = new TeamTournament();

            NovoTorneioEquipa.Name = textBoxNome.Text.Trim();
            NovoTorneioEquipa.Date = dateTimePickerData.Value;
            NovoTorneioEquipa.Description = textBoxDescricao.Text.Trim();
          

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
