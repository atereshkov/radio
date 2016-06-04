using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;

namespace radio.Dialogs
{
    public class CustomOpenDialog 
    {
        public bool Create(out string FileName)
        {
            bool result = false;
            FileName = "default";
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            myDialog.CheckFileExists = true;

            if (myDialog.ShowDialog() == true)
            {
                FileName = myDialog.FileName;
                result = true;
            }

            return result;
        }
    }
}
