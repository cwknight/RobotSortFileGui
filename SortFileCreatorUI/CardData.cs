using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFileCreatorUI
{

    class CardData : CollectionBase
    {
        private Dictionary<int, Card> cardIDDict { get; set; }



        public void AddCard(Card inputCard)
        {
            cardIDDict.Add(inputCard.DatabaseID, inputCard);


        }

        public Card ByDatabaseID(int requestedID)
        {
            return cardIDDict[requestedID];
        }

        public CardData ByEditions(Edition[] requestedEditions)
        {
            CardData output = new CardData();

            foreach (Card c in cardIDDict.Values)
            {
                foreach (Edition e in requestedEditions)
                {
                    if (c.Edition == e)
                    {
                        output.AddCard(c);
                    }
                }
            }
            return output;
        }

        public CardData ByRarities(Rarity[] requestedRarities)
        {
            CardData output = new CardData();

            foreach (Card c in cardIDDict.Values)
            {
                foreach (Rarity r in requestedRarities)
                {
                    if (c.Rarity == r)
                    {
                        output.AddCard(c);
                    }
                }
            }
            return output;
        }

        public CardData ByPriority(bool requestedPriority)
        {
            CardData output = new CardData();
            foreach (Card c in cardIDDict.Values)
            {
                if (c.IsPriority == requestedPriority)
                {
                    output.AddCard(c);

                }
            }
            return output;
        }
    }
}
