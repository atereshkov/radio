using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Win32;

using radio.Saver;
using radio.Models;

namespace radio.Dialogs
{
    public class CustomSaveDialog
    {
        public void Create(string defFileName, string defExt, string filter, ObservableCollection<Song> songs)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = defFileName;
            dlg.DefaultExt = defExt;
            dlg.Filter = filter;

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                FileSaveParams fileSaveParams = new FileSaveParams(dlg.FileName, songs);
                IMusicCollectionSaver toFileSaver = new ToFileSaver(fileSaveParams);
                toFileSaver.Save();
            }
        }
    }
}
