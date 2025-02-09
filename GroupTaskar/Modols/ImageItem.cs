using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTaskar.Modols
{
    public class ImageItem
    {
        public ImageItem(string name, dynamic icon) {
            this.Name = name;
            this.Icon = icon;
        }
        public string Name { get; set; }

        public dynamic Icon { get; set; }
    }
}
