using System;

namespace DeckOfCards
{
    class Player
    {
        #region Private Variables
        private string name;
        #endregion

        #region Constructors
        public Player(string name)
        {
            this.name = name;
        }
        #endregion

        #region Public Methods
        public string GetPlayerName()
        {
            return name;
        }
        #endregion
    }
}
