using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace radio
{
    [XmlInclude(typeof(Tag))]
    public class TagsList
    {
        
        public List<Tag> Tags { get; set; }

        public TagsList() 
        {
            this.Tags = new List<Tag>();
        }

        public TagsList(List<Tag> Tags)
        {
            this.Tags = Tags;
        }

        public void add(Tag tag)
        {
            Tags.Add(tag);
        }

        /*
        public List<Tag> getTags()
        {
            return Tags;
        }
         */

    }
}
