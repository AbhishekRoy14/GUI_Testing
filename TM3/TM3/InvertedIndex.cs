using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;


namespace TM3
{
    class InvertedIndex
    {
        static internal Hashtable invertedIndex = new Hashtable();
        static readonly object _lock = new object();
        private ArrayList filePath; 
        private Converter convert; 

        public InvertedIndex()
        {
            convert = new Converter();
            
        }

        /*
         * Resets InvertedIndex
         */
        public void ResetInvertedIndex()
        {
            invertedIndex.Clear();
        }

        /*
         * Building an InvertedIndex.
         */
        public Hashtable BuildInvertedIndex(string index)
        {
            /*
            * Constructor for Utilities.
            */
            Utilities utilities = new Utilities();
            filePath = new ArrayList();
            filePath = utilities.Search(index);

            lock (_lock)
            
            {
                foreach (string file in filePath)
                {
                    string[] words;
                    String line;
                    TextReader tr = new StreamReader(file);
                    int fileID = convert.AssignId(file);
                    while ((line = tr.ReadLine()) != null)
                    {
                        String myLine = Regex.Replace(line, @"[^\w\s]", "");
                        words = myLine.Split(' '); 
                        var Porter = new PorterStemmer();
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (words[i] != "" || words[i].Length < 10)
                            {
                                words[i] = words[i].ToLower();
                            }

                            string word = words[i];
                            var WordStem = "";
                            if (!StopWords.StopWordsList.Contains(word))
                            {
                                WordStem = Porter.StemWord(word);
                            }

                            foreach (string Sword in StopWords.StopWordsList)
                            {
                                while (invertedIndex.Contains(Sword))
                                {
                                    invertedIndex.Remove(Sword);
                                }
                            }


                            Dictionary<int, int> dictionary = new Dictionary<int, int>(); 
                            if (invertedIndex.ContainsKey(WordStem))
                            {
                                try 
                                {
                                    dictionary = (Dictionary<int, int>)invertedIndex[WordStem];
                                    if (dictionary.Keys.Contains(fileID))
                                    {
                                        int value = dictionary[fileID] + 1;
                                        dictionary[fileID] = value;
                                    }
                                    else
                                    {
                                        dictionary.Add(fileID, 1);
                                    }
                                }
                                catch (Exception error) 
                                {
                                    MessageBox.Show("" + error);
                                }
                            }
                            else
                            {
                                dictionary = new Dictionary<int, int>();
                                dictionary.Add(fileID, 1);
                                invertedIndex.Add(WordStem, dictionary);
                            }
                        }
                    }
                }
                return invertedIndex;
            }
        }
             

        public Dictionary<string, int> ToListbox()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            Dictionary<int, int> file = Search.filef;
            SortedList<string, int> paths = new SortedList<string, int>();
            foreach (int id in file.Keys)
            {
                int termCount = file[id]; 
                paths.Add(convert.GetPath(id), termCount);
            }
            result = paths.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            return result;
        }
    }
}









