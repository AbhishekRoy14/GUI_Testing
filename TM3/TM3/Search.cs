using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM3
{
    static class Search
    {
        /*
        * Multi-Threading.   
        */
        static readonly object _lock = new object();
        /*
        * internal Dictionary for invertedIndex Access.  
        */
        static internal Dictionary<int, int> filef;
       
        static public void IndexedFileMatchTerm(string[] searchTerms)
        {
            filef = new Dictionary<int, int>(); 
            Dictionary<int, int> d = new Dictionary<int, int>();
            
            var porter = new PorterStemmer();

            lock (_lock) 

                for (int i = 0; i < searchTerms.Length; i++)
                {
                    var porterTerm = porter.StemWord(searchTerms[i].ToLower());
                    foreach (string word in InvertedIndex.invertedIndex.Keys)
                    {
                        if (word == porterTerm)
                        {
                            d = new Dictionary<int, int>();
                            d = (Dictionary<int, int>)InvertedIndex.invertedIndex[word];
                            if (searchTerms[0] == searchTerms[i])
                            {
                                foreach (int key in d.Keys)
                                {
                                    int h = d[key];
                                    filef.Add(key, h);
                                }
                            }                         
                        }
                    }
                }
        }
    }
}
