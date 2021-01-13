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

    public partial class Form1 : Form
    {
        private string[] searchTerms;
        private string folder;
        Utilities utilities = new Utilities();
        private Boolean rebuild;
        private InvertedIndex token;

        public Form1()
        {
            InitializeComponent();
            token = new InvertedIndex();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
                select_folder.Clear();
                select_folder.Text = folder;
                token.ResetInvertedIndex();                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rebuild)
            {
                MessageBox.Show("Refreshing Inverted Index. Please come back later");
            }
            else
            {
                if (select_folder.Text == "")
                {
                    MessageBox.Show("Please select a file and try again");
                }
               
                listBox1.Items.Clear();

                if (SearchTerms.Text != "" && select_folder.Text != "")
                {
                   
                    searchTerms = SearchTerms.Text.Split(',', ' ');
                    for (int i = 0; i < searchTerms.Length; i++)
                    {
                        searchTerms[i] = searchTerms[i].ToLower();
                        Search.IndexedFileMatchTerm(searchTerms);
                    }

                    if (InvertedIndex.invertedIndex.Count == 0)
                    
                    {
                        token.BuildInvertedIndex(folder);
                        MessageBox.Show("Building the inverted index is in progress. Please come back later. ");
                    }
                    else
                    {
                        //
                    }

                    OutPut();            

                }
            }
        }

        private void OutPut()
        {
            Dictionary<string, int> result = token.ToListbox();
            if (result.Count == 0)
            {

                listBox1.Items.Clear();
                listBox1.Items.Add("No result found");
                textBox6.Clear();
            }

            foreach (string s in result.Keys)
            {
                listBox1.Items.Add(s);
                textBox6.Text = listBox1.Items.Count.ToString();
            }

            ICollection key = InvertedIndex.invertedIndex.Keys;



        }

        private void refresh_invertedIndex_Click(object sender, EventArgs e)
        {
            rebuild = true;
            if (folder == null)
            {
                MessageBox.Show("Please select a folder and try again.");
            }
            else
            {
                Thread T1 = new Thread(new ThreadStart(() =>
                {
                    token.ResetInvertedIndex();
                    token.BuildInvertedIndex(folder);
                    rebuild = false;
                }
                 ));
                T1.Start();
            }
        }

        private void display_statistics_Click(object sender, EventArgs e)
        {
            TotalTerm();
            AverageTerm();
            TotalFiles();

        }

        private void TotalTerm()
        {
            int counter = 0;
            for (int i = 1; i < InvertedIndex.invertedIndex.Count; i++)
            {
                counter++;
            }

            textBox1.Text = Convert.ToString(counter);
        }

        private void AverageTerm()
        {

            string letter = InvertedIndex.invertedIndex.Count.ToString();
            double letterCount = Convert.ToDouble(letter);
            double wordCount = Convert.ToDouble(textBox1.Text);
            double average = 0;
            average = letterCount / wordCount;
            //double tf = average;
            //tf = Math.Round(tf, 3);
            textBox3.Text = Convert.ToString(average);


        }


        private void TotalFiles()
        {
            int fileCount = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories).Length;
            textBox2.Text = Convert.ToString(fileCount);
        }

       
    }
}
