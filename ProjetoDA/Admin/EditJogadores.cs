﻿using System;
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
    public partial class EditJogadores : Form
    {

        private Model1Container mcontainer;
        private Player jogadorSelected;

        public EditJogadores()
        {
            InitializeComponent();
            mcontainer = new Model1Container();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //Cria jogador se não estiver nenhum selecionado.
            if (jogadorSelected == null)
            {
                Player newPlayer = new Player();
                newPlayer.Name = textBoxName.Text;
                newPlayer.Nickname = textBoxNick.Text;
                newPlayer.Age = int.Parse(textBoxAge.Text);
                newPlayer.Email = textBoxEmail.Text;
                newPlayer.Avatar = textBoxAvatar.Text;

                mcontainer.PlayerSet.Add(newPlayer);
                mcontainer.SaveChanges();
                atualizarLista();
                limparCampos();
            }
            //Edita jogador selecionado.
            else
            {
                jogadorSelected.Name = textBoxName.Text;
                jogadorSelected.Nickname = textBoxNick.Text;
                jogadorSelected.Email = textBoxEmail.Text;
                jogadorSelected.Avatar = textBoxAvatar.Text;
                jogadorSelected.Age = int.Parse(textBoxAge.Text);

                mcontainer.SaveChanges();
                atualizarLista();
                limparCampos();
            }
        }

        //Apaga jogador selecionado.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex >= 0)
            {
                jogadorSelected = (Player)listBoxPlayers.SelectedItem;
                mcontainer.PlayerSet.Remove(jogadorSelected);
                limparCampos();
                atualizarLista();
            }
        }

        //Preenche todos os campos com os dados do jogador selecionado, para posterior edição.
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex >= 0)
            {
                jogadorSelected = (Player)listBoxPlayers.SelectedItem;
                textBoxName.Text = jogadorSelected.Name;
                textBoxNick.Text = jogadorSelected.Nickname;
                textBoxEmail.Text = jogadorSelected.Email;
                textBoxAvatar.Text = jogadorSelected.Avatar;
                textBoxAge.Text = jogadorSelected.Age.ToString();
            }
        }

        //Abre um fileDialog para adquirir o URL da imagem.
        private void buttonProcurarAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.CheckFileExists)
            {
                textBoxAvatar.Text = openFileDialog1.FileName;
            }

            openFileDialog1 = null;
        }

        //Atualiza a listBox dos jogadores.
        private void atualizarLista()
        {
            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(mcontainer.PlayerSet.ToArray());
        }

        //Limpa campos.
        private void limparCampos()
        {
            jogadorSelected = null;
            textBoxName.Text = "";
            textBoxNick.Text = "";
            textBoxEmail.Text = "";
            textBoxAvatar.Text = "";
            textBoxAge.Text = "";
        }
    }
}
