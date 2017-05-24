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
    public partial class LoginArbitro : Form
    {

        Model1Container mcontainer;

        public LoginArbitro()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Verify Login
            string username = textBoxUtilizador.Text;
            string password = textBoxPassword.Text;

            if (textBoxUtilizador.Text.Length == 0 || textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Invalid Login!");
            }

            var utilizadores = from user in mcontainer.UserSet.OfType<Referee>() where user.Username == textBoxUtilizador.Text && user.Password == textBoxPassword.Text select user;

            try
            {
                Referee userSelecionado = utilizadores.First<Referee>();
                VistaArbitro newVista = new VistaArbitro();
                newVista.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Login!"); ;
            }

        }
    }
}
