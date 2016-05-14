using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Search
{
    public class TagsSearchCriteria : ISearchingCriteria<bool>
    {
        public string Tag { get; set; }

        public TagsSearchCriteria()
        {

        }

        public TagsSearchCriteria(String tag)
        {
            this.Tag = tag;
        }

        public bool checkCriteria(Song song)
        {
            bool result = false;

            foreach (Tag songTag in song.Tags)
            {
                if (songTag.ToString().ToLower().Contains(Tag.ToLower()))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
