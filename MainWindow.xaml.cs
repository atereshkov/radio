﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            MusicCollection MusicList = new MusicCollection();
            List<Tag> tags = new List<Tag>();
            tags.Add(new Tag("tag1"));
            tags.Add(new Tag("tag2"));

            MusicList.add(new Song("Song name1", "Super Artist", 200, tags, 2003));
            Saver.SaveToFile("music_collection.xml", MusicList.getSongs());

        }
    }
}
