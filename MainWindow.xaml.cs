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
using radio.Search;

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

            ObservableCollection<string> searchList = new ObservableCollection<string>();
            searchList.Add("Name");
            searchList.Add("Artist");
            searchList.Add("Duration");
            searchComboBox.ItemsSource = searchList;
            searchComboBox.SelectedItem = searchList[0];

        }

        private void ListView1ColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();

            SortOrder order = SortOrder.Ascending;
            SortingStrategy sortingStrategy = new SortingStrategy();

            Dictionary<string, ISortingStrategy> sorts = new Dictionary<string, ISortingStrategy>();
            sorts.Add("Name", new SortByName());
            sorts.Add("Artist", new SortByArtist());
            sorts.Add("Duration", new SortByDuration());

            try
            {
                sortingStrategy.SetStrategy(sorts[sortBy], musicList.Songs, order);
            }
            catch (KeyNotFoundException)
            {
                
            }

            sortingStrategy.Sort();

        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (searchBox.Text != "")
                {
                    SearchingStrategy searchingStrategy = new SearchingStrategy();

                    Dictionary<string, ISearchingStrategy<Song>> searchs = new Dictionary<string, ISearchingStrategy<Song>>();
                    searchs.Add("Name", new SearchByName());
                    //sorts.Add("Artist", new SearchByArtist());
                    //sorts.Add("Duration", new SearchByDuration());

                    SearchParams searchParams = new SearchParams(searchBox.Text);
                    try
                    {
                        searchingStrategy.SetStrategy(searchs[searchComboBox.Text], musicList.Songs, searchParams);
                    }
                    catch (KeyNotFoundException keyNotFoundEx) { }
                    
                    ListView1.ItemsSource = searchingStrategy.Search();
                }
                else
                {
                    ListView1.ItemsSource = musicList.Songs;
                }
            }
            catch (NullReferenceException ex) { }
            
        }

    }
}
