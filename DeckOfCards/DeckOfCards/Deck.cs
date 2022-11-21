using System;

namespace DeckOfCards
{
    class Deck
    {
        #region Private Constants
        private const int noOfCards = 52;
        #endregion

        #region Private Variables
        private Card[] cards;
        private int currentCardIndex;
        private readonly Random _randomNoGen;
        #endregion

        #region Constructors
        public Deck()
        {
            cards = new Card[noOfCards];
            _randomNoGen = new Random();
            SetupGame();
        }
        #endregion

        #region Public Methods
        public string dealOneCard() // Returns the card on the top of the deck
        {
            if (currentCardIndex >= 52)
                return "No cards left";
            return cards[currentCardIndex++].ToString();
        }

        public void ShuffleCards() //Shuffle the deck of cards
        {

            //int noOfSuffles = /*_randomNoGen.Next(noOfCards,noOfCards);*/
            for (int i = currentCardIndex; i < noOfCards; i++)
            {
                int ind1 = _randomNoGen.Next(currentCardIndex, noOfCards); //Genearte first random index
                int ind2 = _randomNoGen.Next(currentCardIndex, noOfCards); //Genearte second random index

                //Swapping of cards
                Card tempCard = cards[ind1];
                cards[ind1] = cards[ind2];
                cards[ind2] = tempCard;
            }
            //resetcurrentCardIndexex(); //Reset currentcard to 0
        }


        public void RestartTheGame() //Restart the game
        {
            SetupGame();
        }
        public int NoOfCardsLeft() //Returns no of cards left in the deck
        {
            return noOfCards - currentCardIndex;
        }
        #endregion

        #region PrivateMethods
        private void SetupGame()
        {
            int index = 0;
            ResetcurrentCardIndexex();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    cards[index++] = new Card(i, j);
                }
            }
            ShuffleCards(); //Shuffle the cards
        }
        private void ResetcurrentCardIndexex() //Reset currentcard to 0
        {
            currentCardIndex = 0;
            return;
        }
        #endregion

    }
}
