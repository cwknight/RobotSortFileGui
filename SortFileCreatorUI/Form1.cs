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
        private Dictionary<string, Edition> editionsCodeDictionary = new Dictionary<string, Edition>();
        private Dictionary<string, Edition> editionsNameDictionary = new Dictionary<string, Edition>();

        public void AddEdition(Edition inEdition)
        {
            editionsCodeDictionary.Add(inEdition.Code, inEdition);
            editionsNameDictionary.Add(inEdition.Name, inEdition);
        }
        public Edition ByCode(string requestedCode)
        {

            return editionsCodeDictionary[requestedCode];
        }

        public Edition ByName(string requestedName)
        {

            return editionsNameDictionary[requestedName];
        }

        public List<Edition> ByIsFrontier(bool requestedIsFrontier)
        {
            List<Edition> output = new List<Edition>();
            foreach (Edition edition in editionsNameDictionary.Values)
            {
                if(edition.IsFrontier = requestedIsFrontier)
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
}
