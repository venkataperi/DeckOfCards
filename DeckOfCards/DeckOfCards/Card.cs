using System;
using DeckOfCards.Enums;
namespace DeckOfCards
{
    class Card
    {
        #region Private Variables
        private Suits suit;
        private CardValues cardValue;
        #endregion

        #region Constructors
        public Card(int suit, int cardValue)
        {
            this.suit = (Suits)suit;
            this.cardValue = (CardValues)cardValue;
        }
        #endregion

        #region Public Methods
        public Suits GetSuit()
        {
            return suit;
        }

        public CardValues GetCardValue()
        {
            return cardValue;
        }
        public
        override string ToString()
        {
            return GetSuit() + " " + GetCardValue();
        }

        #endregion
    }
}
