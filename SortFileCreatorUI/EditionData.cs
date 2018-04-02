using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFileCreatorUI
{
    class EditionData
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
                if (edition.IsFrontier == requestedIsFrontier)
                {
                    output.Add(edition);
                }
            }
            return output;
        }
    }
}
