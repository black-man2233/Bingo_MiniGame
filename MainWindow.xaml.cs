using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;


namespace Bingo_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int a;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 5 + (1); i++)
            {
                Ubrugte_ListBox.Items.Add(i);
            }
            MessageBox.Show($"{Ubrugte_ListBox.Items[0]}");

        }




        private void Tryk_knap_Click(object sender, RoutedEventArgs e)
        {


            a = rnd.Next(0, Ubrugte_ListBox.Items.Count);

            if (Ubrugte_ListBox.Items.Contains(a))
            {
                Brugte_listBox.Items.Add(a);
                Ubrugte_ListBox.Items.Remove(a);
            }else 
            {
                a = rnd.Next(0, Ubrugte_ListBox.Items.Count);
                Brugte_listBox.Items.Add(a);
                Ubrugte_ListBox.Items.Remove(a);
            }

            Debug.WriteLine(a);

        }





    }
}

