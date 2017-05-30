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

        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            LoginAdministrador newform = new LoginAdministrador();
            newform.ShowDialog();
            
        }

        private void buttonArbitro_Click(object sender, EventArgs e)
        {
            LoginArbitro newform = new LoginArbitro();
            newform.ShowDialog();
        }
    }
}
