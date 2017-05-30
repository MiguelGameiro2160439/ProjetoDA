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
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        //Devolve a vista para o login do admin.
        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            LoginAdministrador newform = new LoginAdministrador();
            newform.ShowDialog();
            
        }

        //Devolve a vista para o login do arbitro.
        private void buttonArbitro_Click(object sender, EventArgs e)
        {
            LoginArbitro newform = new LoginArbitro();
            newform.ShowDialog();
        }
    }
}
