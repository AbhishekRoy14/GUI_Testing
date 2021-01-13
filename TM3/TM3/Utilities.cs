using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM3
{
    public class Utilities
    {
       /*
       * Multi-Threading.   
       */
        static readonly object _lock = new object();
        private ArrayList Path = new ArrayList();
       
        /*
         * Recursive method that searches over directory structure
         * to find the files. 
         */
        public void SearchDirectory(string index)
        {
            try
            {
                foreach (string file in Directory.GetFiles(index))
                {
                    lock (_lock)
                    {
                        Path.Add(file);
                    }
                }

                foreach (string d in Directory.GetDirectories(index))
                {
                    SearchDirectory(d);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);
            }
        }

        /*
         * Calls searchDirectory for InvertedIndex.       
         */
        public ArrayList Search(string index)
        {
            SearchDirectory(index);
            return Path;
        }
    }
}

