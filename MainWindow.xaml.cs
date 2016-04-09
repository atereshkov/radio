using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;

using radio.Models;
using radio.Collections;
using radio.Loader;
using radio.Saver;
using radio.Sort;

namespace radio
{
    public partial class MainWindow : Window
    {
        MusicCollection musicList;
        Playlist playlist;

        public MainWindow()
        {
            InitializeComponent();

            FileLoadParams fileLoadParams = new FileLoadParams("music_collection.xml");
            ILoader<ObservableCollection<Song>> fromFileLoader = new FromFileLoader(fileLoadParams);
            musicList = new MusicCollection(fromFileLoader.Load(), "music collection");

            ListView1.ItemsSource = musicList.Songs;
            
            durationLabel.Content = musicList.Count() + " tracks (" + musicList.getStringDuration() + ")";

            playlist = new Playlist();
            playlistListView.ItemsSource = playlist.Songs;

            //FileSaveParams fileSaveParams = new FileSaveParams("music_collection.xml", musicList.Songs);
            //IMusicCollectionSaver toFileSaver = new ToFileSaver(fileSaveParams);
            //toFileSaver.Save();
        }

        private void ListView1ColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();

            SortOrder order = SortOrder.Ascending;
            SortingStrategy sortingStrategy = new SortingStrategy();

            if (sortBy.Equals("Name"))
            {
                sortingStrategy.SetStrategy(new SortByName(), musicList.Songs, order);
            }

            if (sortBy.Equals("Artist"))
            {  
                sortingStrategy.SetStrategy(new SortByArtist(), musicList.Songs, order);
            }

            if (sortBy.Equals("Duration"))
            {
                sortingStrategy.SetStrategy(new SortByDuration(), musicList.Songs, order);
            }

            sortingStrategy.Sort();

        }

    }
}
