using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

using radio.Models;
using radio.Collections;
using radio.Loader;
using radio.Saver;
using radio.Sort;

namespace radio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FileLoadParams fileLoadParams = new FileLoadParams("music_collection.xml");
            ILoader<ObservableCollection<Song>> fromFileLoader = new FromFileLoader(fileLoadParams);
            MusicCollection musicList = new MusicCollection(fromFileLoader.Load(), "mus collection");

            ListView1.ItemsSource = musicList.Songs;

            SortingStrategy sortingStrategy = new SortingStrategy();
            sortingStrategy.SetStrategy(new SortByArtist(), musicList.Songs);
            sortingStrategy.Sort();

            //FileSaveParams fileSaveParams = new FileSaveParams("music_collection.xml", musicList.Songs);
            //IMusicCollectionSaver toFileSaver = new ToFileSaver(fileSaveParams);
            //toFileSaver.Save();
        }

    }
}
