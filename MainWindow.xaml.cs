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
        int trukketTal = 0;
        List<int> trukketList = new List<int>();



        public MainWindow()
        {
            InitializeComponent();
            GameStart(90);

            Trukket_Label.Content = "Trukket tal Vises her";

            Brugte_listBox.Items.Reverse();
           
        }

        private void Tryk_knap_Click(object sender, RoutedEventArgs e)
        {

            if (!Ubrugte_ListBox.Items.IsEmpty)
            {
                trukketTal = talRandomizer.Next(0, Ubrugte_ListBox.Items.Count - 1);


                Trukket_Label.Content = $"{Ubrugte_ListBox.Items[trukketTal]}";


                Brugte_listBox.Items.Add(Ubrugte_ListBox.Items[trukketTal]);

                Ubrugte_ListBox.Items.Remove(Ubrugte_ListBox.Items[trukketTal]);

            }
            else if (Ubrugte_ListBox.Items.IsEmpty)
            {
               var resultat =  MessageBox.Show("Vil du starte Forfra?", "Genstart?", MessageBoxButton.YesNo);
                if (resultat == MessageBoxResult.Yes)
                {
                    GameStart(90);
                }
                else
                {
                    this.Close();
                }
            }



        }

        void GameStart(int antal)
        {
            Trukket_Label.Content = String.Empty;
            Trukket_Label.Content = "Trukket tal Vises her";
            Brugte_listBox.Items.Clear();
            Ubrugte_ListBox.Items.Clear();

            for (int i = 1; i < antal + (1); i++)
            {
                Ubrugte_ListBox.Items.Add(i);
            }

        }
    }
}


