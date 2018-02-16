using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartGame
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game()
        {
        }

        public Game(string name1, string name2)
        {
            _player1 = new Player();
            _player2 = new Player();
            _player1.Name = name1;
            _player2.Name = name2;

            _random = new Random();
        }

        public string PlayDarts()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                playTurn(_player1);
                playTurn(_player2);
            }
            return DisplayResults();
        }

        private string DisplayResults()
        {
            string result = String.Format("{0}: {1}<br />{2}: {3}", _player1.Name, _player1.Score, _player2.Name, _player2.Score) + "<br /> Winner: ";
            string winner = "";
            if (_player1.Score > _player2.Score)
            {
                winner = _player1.Name;
            } else if (_player2.Score > _player1.Score)
            {
                winner = _player2.Name;
            }
            return result += winner;
        }

        private void playTurn(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.DartScore(player, dart);
            }
        }
    }
}