using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardWar
{
    public class Game
    {
        private Player _player1;
        private Player _player2;


        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };     
        }

        public string Play()
        {
            Deck deck = new Deck();
            string winner = "<h3>Dealing cards... </h3>";
            winner += deck.Deal(_player1, _player2);
            winner += "<h3>Begin battle!</h3>";
            int round = 0;

            while (_player1.Cards.Count() > 0 && _player2.Cards.Count() > 0)
            {
                War war = new War();
                winner += war.PreformWar(_player1, _player2);

                round += 1;
                if (round > 20)
                    break;
            }

            winner += determineWinner();
            return winner;
        }
       
        private string determineWinner()
        {
            string winner = "";
            if (_player1.Cards.Count() > _player2.Cards.Count())
                winner = "<br /><span style ='color:red;'>Player 1 Wins!</span>";
            else
                winner = "<br /><span style ='color:blue;'>Player 2 Wins!</span>";

            winner += "<br /><span style ='color:red;'>Player 1: " + _player1.Cards.Count() + " cards</span> <br /> <span style ='color:blue;'>Player 2: " + _player2.Cards.Count() + " cards</span>";
            return winner;
        }  
    }
}