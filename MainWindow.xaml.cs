using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using radio.Models;
using radio.Collections;
using radio.IO;

namespace radio
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Saver.SaveToFile("music_collection.xml", MusicList.getSongs());

            LoadParams loadParams = new LoadParams("music_collection.xml");

            MusicCollection musicTest = new MusicCollection(loadParams, "music collection");



        }
    }
}
