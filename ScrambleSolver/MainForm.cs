using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrambleSolver
{
    public partial class WordBuilder : Form
    {
        private static Dictionary<string, string[]> Dictionary { get; set; }
        private int MaxCharacters { get; set; }
        private List<string> Results { get; set; }

        public WordBuilder()
        {
            InitializeComponent();
            Dictionary = ReturnDictionary("words.txt");
            SettingsUpdater();
            TotalWordCount.Text = $"{Dictionary.Count} Words!";
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (InputBox.Text != "")
            {
                Results = new List<string>();
                Results = ReturnResults();
                PopulateListBox(Results, MaxCharacters);
            }
            else
            {
                MainOutput.Items.Clear();
            }
        }
        private void PopulateListBox(List<string> results, int maxCharacters)
        {
            MainOutput.Items.Clear();
            if (results.Count > 0)
            {
                foreach (string word in results.Where(i => i.Length >= 2).OrderByDescending(i => i.Length).Where(i => i.Length <= maxCharacters))
                {
                    MainOutput.Items.Add(word);
                }
            }
        }
        private List<string> ReturnResults()
        {
            string source = string.Concat(InputBox.Text.OrderBy(c => c));
            var result = Enumerable
              .Range(1, (1 << source.Length) - 1)
              .Select(index => string.Concat(source.Where((item, idx) => ((1 << idx) & index) != 0)))
              .SelectMany(key =>
              {
                  if (Dictionary.TryGetValue(key, out string[] words))
                      return words;
                  else
                      return new string[0];
              })
              .Distinct()
              .OrderBy(word => word)
              .ToList();
            return result;
        }
        private Dictionary<String, string[]> ReturnDictionary(string input)
        {
            var f = File.ReadAllLines(input);
            return f.Select(word => new
            {
                Key = String.Concat(word.OrderBy(c => c)),
                Value = word.ToLower().Trim()
            })
                .GroupBy(item => item.Key, item => item.Value)
                .ToDictionary(chunk => chunk.Key, chunk => chunk.ToArray());
        }
        private async void SettingsUpdater()
        {
            while (true)
            {
                LengthTrackBar.Minimum = 2;
                if (Results != null)
                {
                    if (Results.Count > 0)
                    {
                        DiscoveredWordCount.Text = $"{Results.Count} Words!";
                        LengthTrackBar.Maximum = Results.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length;
                    }
                }
                MaxCharacters = LengthTrackBar.Value;
                SelectedMax.Text = MaxCharacters.ToString();
                await Task.Delay(10);
            }
        }
        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            MaxCharacters = LengthTrackBar.Value;
            if (Results != null && Results.Count > 0)
            {
                PopulateListBox(Results, MaxCharacters);
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            GoButton_Click(this, new EventArgs());
        }
    }
}
