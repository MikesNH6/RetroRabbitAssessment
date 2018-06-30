using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge
{
    public partial class CodingCallengeForm : Form
    {
        private List<string> list = new List<string>();

        public CodingCallengeForm()
        {
            InitializeComponent();
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            ResultsDisplayBox.Text = null;
            char[] searchLetters = SearchBox.Text.ToCharArray();
            string foundWords = "";
            MatchCount.Text = "0";
            List<string> foundList = new List<string>();

            //Way too complex there must be an easier way...
            foreach (var word in list)
            {
                char[] letters = word.ToCharArray();

                for (int i = 0; i < word.Length; i++)
                {
                    for (int a = 0; a < searchLetters.Length; a++)
                    {
                        if (letters[i] == searchLetters[a])
                        {
                            foundWords += letters[i].ToString(); //builds the word by trying to match each character in the list
                        }
                    }
                }

                //Had a bug where it wasn't returning the correct word. Now checks to see if the word exists first
                if (foundWords.Length == 5 && foundWords.Contains(word)) 
                {
                    foundList.Add(foundWords);
                    foundWords = "";
                }
                else
                {
                    foundWords = "";
                    ResultsDisplayBox.Text = "Cannot find any equivalent strings...";
                }
            }

            //Purely set this way to get the right feedback from the results box
            if (SearchBox.Text != "" && foundList.Count > 0) 
            {
                ResultsDisplayBox.Text = "";
                foreach (var item in foundList)
                {
                    ResultsDisplayBox.Text += item + "\r\n";
                }
                MatchCount.Text = foundList.Count.ToString();
            }
        }

        private void CodingCallengeForm_Load(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + Properties.Resources.StringList;
            string replacedPath = Regex.Replace(path, "Debug|Release|bin", String.Empty);
            //For some odd reason the relative path in the solution appends bin/Debug or Release depending on the solution configurations

            try
            {
                using (StreamReader st = new StreamReader(replacedPath))
                {
                    string textContents = st.ReadToEnd();
                    list = TextHelper.ConvertToList(textContents);

                    ErrorHandling(replacedPath, st);

                    DisplayText(list);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorHandling(string path, StreamReader st)
        {
            if (TextHelper.CheckRepeatingChars(list))
            {
                DialogResult dialogResult = MessageBox.Show(Properties.Resources.RepeatingCharsMessage, "Please Review", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(path);
                    Dispose();
                }
                else
                {
                    Dispose();
                }
            }

            if (list.Any(a => a.Length != 5))
            {
                DialogResult dialogResult = MessageBox.Show(Properties.Resources.LengthComplexityMessage, "Please Review", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(path);
                    Dispose();
                }
                else
                {
                    this.Dispose();
                }
            }
        }

        private void DisplayText(List<string> list)
        {
            foreach (string item in list)
            {
                TextFileDisplayBox.Text += item + "\r\n";
            }
        }
    }
}
