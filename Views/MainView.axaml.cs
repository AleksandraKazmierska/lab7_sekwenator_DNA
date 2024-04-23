using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Linq;

namespace lab_7.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        public void Calculate_Kmers_Click(object sender, RoutedEventArgs e)
        {
            string text = sequence.Text.ToLower();


            Dictionary<string, int> kmersCount = new Dictionary<string, int>();

            for (int i = 0; i <= text.Length - 4; i++)
            {
                string kmer = text.Substring(i, 4);
                if (kmersCount.ContainsKey(kmer))
                {
                    kmersCount[kmer]++;
                }
                else
                {
                    kmersCount[kmer] = 1;
                }
            }

            string result = " ";
            foreach (var kvp in kmersCount)
            {
                result += $"{kvp.Key}: {kvp.Value}\n";
            }

            Output.Text = result;
        }
    }
}
