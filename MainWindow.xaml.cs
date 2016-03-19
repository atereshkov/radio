using System;
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

using radio.Models;
using radio.Collections;

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

            List<Genre> genres = new List<Genre>();
            genres.Add(new Genre("Pop"));
            genres.Add(new Genre("Classical"));

            MusicList.Add(new Song("Song name1", "Super Artist", 200, tags, genres, 2003));
            Saver.SaveToFile("music_collection.xml", MusicList.getSongs());

            MusicCollection musicTest = new MusicCollection();
            musicTest.Songs = Loader.ReadFromFile("music_collection.xml");

            Playlist playlist = new Playlist();
            playlist.Add(new Song("some song", "artist", 2000, tags, genres, 2006));
            
        }
    }
}
