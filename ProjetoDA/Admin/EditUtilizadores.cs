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
    public partial class EditUtilizadores : Form
    {
        public EditUtilizadores()
        {
            InitializeComponent();
        }

        //Mostra vista admin.
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            EditAdmin newEdit = new EditAdmin();
            newEdit.ShowDialog();
        }

        //Mostra vista arbitro.
        private void buttonArbitro_Click(object sender, EventArgs e)
        {
            EditArbitro newEdit = new EditArbitro();
            newEdit.ShowDialog();
        }
    }
}
