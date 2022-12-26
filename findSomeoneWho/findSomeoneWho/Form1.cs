using System.Collections.Generic;
using System.Xml.Linq;

namespace findSomeoneWho
{
    public partial class Form1 : Form
    {
        // Variables to deal with our input and output of the file
        static string? path;
        static string? location;
        static string? outputFile;

        List<string> wordList = new List<string>();

        public Form1()
        {
            // test
            InitializeComponent();
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Get the input text file from user
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;

            // Reset the source textbox
            txtSource.Text = path;
            txtSource.BackColor = Color.White;

            // Read text file into our list
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                wordList.Add(line);
            }

            // Setup our output file, save into the same directory as the source
            location = Path.GetDirectoryName(path);
            outputFile = String.Format("{0}/FindSomeoneWho_output.csv", location);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int numWords;
            int numPlayers;

            bool words = int.TryParse(txtNumWords.Text, out numWords);
            bool players = int.TryParse(txtNumPlayers.Text, out numPlayers);

            lblError.Text = "";

            // Validating for numbers
            if (words == false || players == false)
            {
                if (words == false)
                {
                    txtNumWords.BackColor = Color.Red;
                    lblError.Text += "\nNumber of Words is not a Number";
                }
                if (players == false)
                {
                    txtNumPlayers.BackColor = Color.Red;
                    lblError.Text += "\nNumber of Players is not a Number";
                }
                return;
            }

            // Validating for a wordlist
            if(wordList.Count <= 0)
            {
                txtSource.BackColor = Color.Red;
                lblError.Text += "\nNo input list!";
                return;
            }


            // If we pass the checks, we do the generator thing
            listGenerator(numWords, numPlayers);

            lblError.Text = "DONE!";
        }

        private void validation_Enter(object sender, EventArgs e)
        {
            // Reset the color to white on focus
            TextBox? txtValidation = sender as TextBox;
            txtValidation.BackColor = Color.White;
            
        }

        private void listGenerator(int numWords, int numPlayers)
        {
            // Setting up our StreamWriter to ouput a file with name and location we specified
            using (StreamWriter sw = File.CreateText(outputFile))
            {
                // Give our csv a header, this makes our mailmerge work better
                string header = "";
                for(int k = 1; k <= numWords; k++)
                {
                    header += String.Format("Thing {0},", k);
                }
                sw.WriteLine(header.Remove(header.Length - 1, 1));

                
                for (int i = 0; i < numPlayers; i++)
                {
                    List<int> previous = new List<int>();
                    Random rand = new Random();

                    int element;
                    string list = "";

                    // Make our lists!
                    for (int j = 0; j < numWords; j++)
                    {
                        // Keep randomising until we have a new unique element
                        while (previous.Contains(element = rand.Next(0, 100)))
                        {

                        }
                        // Add the number to the list and then the wordList phrase to our string
                        previous.Add(element);
                        list += String.Format("{0},", wordList[element]);
                    }

                    // Write out our string to the CSV
                    sw.WriteLine(list.Remove(list.Length - 1, 1));
                }
            }
        }
    }
}