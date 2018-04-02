using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortFileCreatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Edition
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsFrontier { get; set; }
    }

    public class EditionData
    {
        private Dictionary<string, Edition> editionsCodeDict = new Dictionary<string, Edition>();
        private Dictionary<string, Edition> editionsNameDict = new Dictionary<string, Edition>();

        public void AddEdition(Edition inEdition)
        {
            editionsCodeDict.Add(inEdition.Code, inEdition);
            editionsNameDict.Add(inEdition.Name, inEdition);
        }
        public Edition ByCode(string requestedCode)
        {

            return editionsCodeDict[requestedCode];
        }

        public Edition ByName(string requestedName)
        {

            return editionsNameDict[requestedName];
        }

        public List<Edition> ByIsFrontier(bool requestedIsFrontier)
        {
            List<Edition> output = new List<Edition>();
            foreach (Edition edition in editionsNameDict.Values)
            {
                if(edition.IsFrontier == requestedIsFrontier)
                {
                    output.Add(edition);
                }
            }
            return output;
        }
    }

    public enum Rarity { L, C, U, R, M, P, S}
  
    public class Card
    {
        public int DatabaseID { get; set; }
        public string Title { get; set; }
        public Edition Edition { get; set; }
        public int CollectorNumber { get; set; }
        public Rarity Rarity { get; set; }
        public bool IsPriority { get; set; }

    }

    public class CardData
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
            
            foreach(Card c in cardIDDict.Values)
            {
                foreach(Edition e in requestedEditions)
                {
                    if(c.Edition == e)
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

            foreach(Card c in cardIDDict.Values)
            {
                foreach (Rarity r in requestedRarities)
                {
                    if(c.Rarity == r)
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
            foreach(Card c in cardIDDict.Values)
            {
                if(c.IsPriority == requestedPriority)
                {
                    output.AddCard(c);

                }
            }
            return output;
        }
    }
}
