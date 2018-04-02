using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFileCreatorUI
{

    public enum Rarity { L, C, U, R, M, P, S }
    class Card
    {
        public int DatabaseID { get; set; }
        public string Title { get; set; }
        public Edition Edition { get; set; }
        public int CollectorNumber { get; set; }
        public Rarity Rarity { get; set; }
        public bool IsPriority { get; set; }
    }
}
