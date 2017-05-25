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
        private Administrator adminSelected;

        public EditAdmin()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            if (adminSelected == null)
            {
                Administrator newAdmin = new Administrator();
                newAdmin.Username = textBoxUsername.Text;
                newAdmin.Password = textBoxPassword.Text;
                newAdmin.Email = textBoxEmail.Text;

                mcontainer.UserSet.Add(newAdmin);
                mcontainer.SaveChanges();
                atualizarLista();
                limparCampos();
            }
            else
            {
                adminSelected.Username = textBoxUsername.Text;
                adminSelected.Password = textBoxPassword.Text;
                adminSelected.Email = textBoxEmail.Text;

                mcontainer.UserSet.Add(adminSelected);
                mcontainer.SaveChanges();
                atualizarLista();
                limparCampos();
            }
        }

        private void atualizarLista()
        {
            listBoxAdmins.Items.Clear();
            listBoxAdmins.Items.AddRange(mcontainer.UserSet.ToArray());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAdmins.SelectedIndex >= 0)
            {
                adminSelected = (Administrator)listBoxAdmins.SelectedItem;
                mcontainer.UserSet.Remove(adminSelected);
                limparCampos();
                atualizarLista();
            }
        }

        private void limparCampos()
        {
            adminSelected = null;
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxAdmins.SelectedIndex >= 0)
            {
                adminSelected = (Administrator)listBoxAdmins.SelectedItem;
                textBoxEmail.Text = adminSelected.Email;
                textBoxUsername.Text = adminSelected.Username;
                textBoxPassword.Text = adminSelected.Password;
            }
        }
    }
}
