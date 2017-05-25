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
    public partial class EditAdmin : Form
    {

        Model1Container mcontainer;

        public EditAdmin()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Administrator newAdmin = new Administrator();
            newAdmin.Username = textBoxUsername.Text;
            newAdmin.Password = textBoxPassword.Text;
            newAdmin.Email = textBoxEmail.Text;

            mcontainer.UserSet.Add(newAdmin);
            mcontainer.SaveChanges();
            atualizarLista();
        }

        private void atualizarLista()
        {
            listBoxAdmins.Items.Clear();
            //listBoxAdmins.Items.AddRange(mcontainer.UserSet.ToArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
