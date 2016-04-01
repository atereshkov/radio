using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

            LoadParams loadParams = new LoadParams("music_collection.xml");
            MusicCollection musicList = new MusicCollection(loadParams, "music collection");

            ListView1.ItemsSource = musicList.Songs;

            SortingStrategy context = new SortingStrategy();
            context.SetStrategy(new SortByDuration(), musicList.Songs);
            context.Sort();

            //SaveParams saveParams = new SaveParams("music_collection.xml", musicList.Songs);
            //IMusicCollectionSaver toFileSaver = new ToFileSaver();
            //toFileSaver.Save(saveParams);
        }

    }
}
