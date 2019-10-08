using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertStringToTitleCase
{
    public partial class Form1 : Form
    {
        Dictionary<long, string> quotesDictionary = new Dictionary<long, string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            idInpuTextBox.Visible = false;
        }

        private void normaliseButton_Click(object sender, EventArgs e)
        {
            
                string quoteString = TitleCaseString( addQuoteTextBox.Text);
           
            long quoteID = 0;
                if (autoRadioButton.Checked)
                {
                    idInpuTextBox.Text = DoRandom().ToString();
                if (GetValidation()) {
                    quoteID =Convert.ToInt64( idInpuTextBox.Text);
                }
            }
            else if (manualRadioButton.Checked)
                {
                if(GetValidation())
                    quoteID =Convert.ToInt64( idInpuTextBox.Text);
                }
            if (GetValidation())
            {
                quotesDictionary.Add(quoteID, quoteString);
                ListViewItem items = new ListViewItem(quoteID.ToString());
                items.SubItems.Add(quoteString);
                mainListView.Items.Add(items);
            }
            GetTextBoxClear();
            addQuoteTextBox.Focus();

        }
        private bool GetValidation()
        {
            bool output = true;

            if (idInpuTextBox.Text.Length == 13)
            {
                long IDnumber = 0;
                bool IDinput = long.TryParse(idInpuTextBox.Text, out IDnumber);
                if (!IDinput)
                {
                    output = false;
                    MessageBox.Show("Please Enter A 13 Digit Valid ID Number");
                }

            }
            else {
                output = false;
                MessageBox.Show("Please Enter A 13 Digit Valid ID Number");
            }
            if (String.IsNullOrWhiteSpace(addQuoteTextBox.Text)) {
                MessageBox.Show("Please enter your quotes!!!");
                output = false; }
            
            return output;
        }
        private long DoRandom()
        {
            Random r = new Random();

            int number = r.Next(999999999);
            int number2 = r.Next(9999);

            return ((long)number2 * (long)1000000000) + (long)number;
        }
        public void GetSearchClear()
        {
            searchListView.Items.Clear();
            searchTextBox.Clear();
        }
        public void GetTextBoxClear()
        {
            addQuoteTextBox.Clear();
            idInpuTextBox.Clear();
        }

        private void manualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            idInpuTextBox.Visible = true;

        }
        public static String TitleCaseString(String s)
        {
            if (s == null) return s;

            String[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                Char firstChar = Char.ToUpper(words[i][0]);
                String rest = "";
                if (words[i].Length > 1)
                {
                    rest = words[i].Substring(1).ToLower();
                }
                words[i] = firstChar + rest;
            }
            return String.Join(" ", words);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            quotesDictionary.Remove(Convert.ToInt64(mainListView.SelectedItems[0].Text));
            mainListView.SelectedItems[0].Remove();
            
        }

        private void mainListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem mainItem = mainListView.SelectedItems[0];
            string idItem = mainItem.SubItems[0].Text;
            string quoteItem = mainItem.SubItems[1].Text;
            MessageBox.Show($"Id: {idItem} \n" +
                            $"Quote: {quoteItem}","Id And Quote",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           long keyDic=Convert.ToInt64( searchTextBox.Text);
            string valueDic = quotesDictionary[keyDic];
            MessageBox.Show($"Key: {keyDic}" +
                            $"Vaue: {valueDic}");
        }



          private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
          {
              if(e.KeyCode == Keys.Enter)
              {
                  long keyOFQuote = 0;
                  bool tryConvertKey = long.TryParse(searchTextBox.Text, out keyOFQuote);
                  if (tryConvertKey)
                  {
                      foreach (KeyValuePair<long,string> keny in quotesDictionary)
                      {
                          if (keny.Key.ToString().Contains(searchTextBox.Text))
                          {
                              string newSubItem = quotesDictionary[keny.Key];
                              ListViewItem newItem = new ListViewItem(keny.Key.ToString());
                              newItem.SubItems.Add(newSubItem);
                              searchListView.Items.Add(newItem);
                              break;
                          }
                      }
                  }
                  else if (!tryConvertKey)
                  {
                    string searchValue = TitleCaseString(searchTextBox.Text);
                    foreach (KeyValuePair<long, string> keny in quotesDictionary)
                    {
                        if (keny.Value.ToString().Contains(searchValue))
                        {
                            string newSubItem = quotesDictionary[keny.Key];
                            ListViewItem newItem = new ListViewItem(keny.Key.ToString());
                            newItem.SubItems.Add(newSubItem);
                            searchListView.Items.Add(newItem);
                            break;
                        }
                    }

                }
                  else
                  {
                      MessageBox.Show("Please enter right key or quote to get the value");
                  }
                searchTextBox.Text = " ";
              }
          }

        private void clrSearchButton_Click(object sender, EventArgs e)
        {
            GetSearchClear();
            addQuoteTextBox.Focus();
        }
    }
}
