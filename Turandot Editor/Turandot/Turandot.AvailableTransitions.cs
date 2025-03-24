using System;
using System.Collections.Generic;

namespace Turandot
{
    public class AvailableTransitions
    {
        public List<string> sources = new List<string>();
        public List<TermType> types = new List<TermType>() { TermType.Any};

        bool[] availableTO;
        bool[,] available;

        public AvailableTransitions(List<string> sources, bool usesCS)
        {
            this.sources = sources;
            if (usesCS)
            {
                types.Add(TermType.CSplus);
                types.Add(TermType.CSminus);
            }

            availableTO = new bool[types.Count];
            for (int k = 0; k < types.Count; k++) availableTO[k] = true;

            available = new bool[sources.Count, types.Count];

            for (int k = 0; k < sources.Count; k++)
                for (int j = 0; j < types.Count; j++)
                    available[k, j] = true;

        }

        public bool IsTimeoutAvailable(TermType t)
        {
            return types.Contains(t) ? availableTO[(int)t] : false;
        }

        public bool IsSourceAvailable(string src, TermType t)
        {
            int isrc = sources.FindIndex(s => s == src);
            return types.Contains(t) ? available[isrc, (int)t] : false;
        }

        public void Exclude(string source)
        {
            int isrc = sources.FindIndex(s => s == source);
            for (int k = 0; k < types.Count; k++) available[isrc, k] = false;
        }

        public void Exclude(TermType type)
        {
            for (int k = 0; k < sources.Count; k++) available[k, (int)type] = false;
        }

        public void ExcludeTO()
        {
            for(int k=0; k<types.Count; k++)  availableTO[k] = false;
        }
        public void ExcludeTO(TermType type)
        {
            availableTO[(int)type] = false;
        }


    }
}