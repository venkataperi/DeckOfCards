using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Game
    {
        #region Private Variables
        private Player player;
        private Deck deckOfCards;
        #endregion

        #region Constructors
        public Game(Player player)
        {
            this.player = player;
            this.deckOfCards = new Deck();
        }
        #endregion

        #region Public Methods
        public string GreetPlayer()
        {
            return "Hello " + player.GetPlayerName();
        }

        public Deck GetDeckOfcards()
        {
            return deckOfCards;
        }

        #endregion
    }
}
