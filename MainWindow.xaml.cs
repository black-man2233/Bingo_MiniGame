using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Linq;
using StackExchange.Redis;

namespace Bingo_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random talRandomizer = new Random();
        int trukketTal;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 10 + (1); i++)
            {
                Ubrugte_ListBox.Items.Add(i);
            }


        }

        private void Tryk_knap_Click(object sender, RoutedEventArgs e)
        {

            if (!Ubrugte_ListBox.Items.IsEmpty)
            {
                trukketTal = talRandomizer.Next(1, Ubrugte_ListBox.Items.Count);

                if (!Brugte_listBox.Items.Contains(trukketTal))
                {
                    Brugte_listBox.Items.Add(trukketTal);
                    Ubrugte_ListBox.Items.Remove(trukketTal);

                    Trukket_Label.Content = trukketTal;
                }
                Debug.WriteLine(trukketTal);

            }



        }
    }
}


