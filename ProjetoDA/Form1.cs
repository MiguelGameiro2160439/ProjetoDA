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

            

            Player newPlayer = new Player();
            newPlayer.Name = "Alexandre";
            newPlayer.Email = "alexandrep97@hotmail.com";
            newPlayer.Nickname = "Alexp23";
            newPlayer.Age = 19;
            newPlayer.Avatar = "jafuoaef";

            Team newTeam = new Team();
            newTeam.Name = "Benfica";
            newTeam.Avatar = "hshshsbwkaj";

            Deck newDeck = new Deck();
            newDeck.Name = "Ofenciva";

            Tournament newTournament = new Tournament();
            newTournament.Name = "Colombus";
            newTournament.Date = new DateTime(2017, 05, 16);
            newTournament.Description = "Torneio mundial";
            
            User newUser = new User();
            newUser.Username = "Alexp23";
            newUser.Password = "12345";

            Referee newReferee = new Referee();
            newReferee.Name = "Alex";
            newReferee.Avatar = "ahjdya";
            newReferee.Password = "12345";
            newReferee.Username = "Alexp23";

            Administrator newAdmin = new Administrator();
            newAdmin.Username = "Pedro";
            newAdmin.Password = "12345";
            newAdmin.Email = "asdfghjk";



            /*Game newGame = new Game();
            newGame.RefereeId = 
            newGame.DeckOneId = newDeck.Id;
            newGame.DeckTwoId = newDeck.Id;
            newGame.Description = "Final";
            newGame.Date = new DateTime(2017, 05, 16);
            newGame.Number = 1;

            mcontainer.GameSet.Add(newGame);*/
            mcontainer.UserSet.Add(newAdmin);
            mcontainer.UserSet.Add(newReferee);
            mcontainer.UserSet.Add(newUser);
            mcontainer.TournamentSet.Add(newTournament);
            mcontainer.DeckSet.Add(newDeck);
            mcontainer.TeamSet.Add(newTeam);
            mcontainer.CardSet.Add(newCard);
            mcontainer.PlayerSet.Add(newPlayer);
            mcontainer.SaveChanges();
        }

    }
}
