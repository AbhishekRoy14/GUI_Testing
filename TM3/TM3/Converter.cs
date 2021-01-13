using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM3
{
    /*
     *Obtained from Open Polytechnic
     * https://openpolytechnic.iqualify.com/course/-LEJo1Pbjf7j7LUYNhSO/#/page/p68
     * 
     * Usage: BIT694 Developing Applications Using C# Open Polytechnic Project
     * Retrieved October 05, 2018 
     * 
     */
    class Converter
    {
        private int counter; //counter to hold current fileId          
        private Hashtable paths;// =new Hashtable();
        private ArrayList ids;

        /*
         * Constructor
         */
        public Converter()
        {
            counter = 0;
            paths = new Hashtable();
            ids = new ArrayList();
        } // end of constructor


        public int GetID(String path) // return the ID for this file
        {
            return ((int)paths[path]);
        }
        public string GetPath(int id) // return the path for this id
        {
            return ((string)ids[id]);
        }
        public int AssignId(String path) // Assign id to this new file
        {
            int id = counter;
            counter++;
            paths[path] = id;
            ids.Add(path);
            return (id);
        } // end of assignId
    } // end of class
} // end of n