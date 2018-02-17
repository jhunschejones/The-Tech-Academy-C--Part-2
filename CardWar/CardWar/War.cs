using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardWar
{
    public class War
    {
        private List<Card> _winnings;
        private string warInfo = "";

        public War()
        {
            _winnings = new List<Card>();
        }


        private Card moveCards(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _winnings.Add(card);
            return card;
        }

        private void compareCards(Player player1, Player player2, Card card1, Card card2)
        {
            displayWarCards(card1, card2);

            if (card1.CardValue() == card2.CardValue())
                war(player1, player2);
            else if (card1.CardValue() > card2.CardValue())
                awardWinner(player1);
            else
                awardWinner(player2);
        }

        private void awardWinner(Player player)
        {
            if (_winnings.Count == 0) return;
            displayWinningsCards();
            player.Cards.AddRange(_winnings);
            _winnings.Clear();

            warInfo += "<br /><strong>" + player.Name + " wins!</strong><br />";
        }

        public string PreformWar(Player player1, Player player2)
        {
            Card player1Card = moveCards(player1);
            Card player2Card = moveCards(player2);

            compareCards (player1, player2, player1Card, player2Card);
            return warInfo;
        }

        private void war(Player player1, Player player2)
        {
            warInfo += "<br />**************WAR***************<br />";
            moveCards(player1);
            moveCards(player1);
            Card warCard1 = moveCards(player1);

            moveCards(player2);
            moveCards(player2);
            Card warCard2 = moveCards(player2);

            compareCards(player1, player2, warCard1, warCard2);
        }

        private void displayWarCards(Card card1, Card card2)
        {
            warInfo += "<br />War Cards: " + card1.Kind + " of " + card1.Suit + " vs. " +
                card2.Kind + " of " + card2.Suit;
        }

        private void displayWinningsCards()
        {
            warInfo += "<br />Winnings: ";
            foreach (var card in _winnings)
            {
                warInfo += "<br />&nbsp;&nbsp;&nbsp;&nbsp;" + card.Kind + " of " + card.Suit;
            }
        }
    }
}