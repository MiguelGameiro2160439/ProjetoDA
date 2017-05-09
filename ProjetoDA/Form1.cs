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
    public partial class Form1 : Form
    {
        Model1Container mcontainer;
        public Form1()
        {
            InitializeComponent();


            mcontainer = new Model1Container();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card newCard = new Card();
            newCard.Name = "Elf";
            newCard.Faction = "Gaian Love for Life";
            newCard.Type = "Creature";
            newCard.Cost = "Dez";
            newCard.Loyalty = 20;
            newCard.RuleText = "dxbsjkhakjsehgdkjhfgjkfsgkjghsfg";
            newCard.Attack = 30;
            newCard.Defense = 20;
        
            mcontainer.CardSet.Add(newCard);
            mcontainer.SaveChanges();

        }
    }
}