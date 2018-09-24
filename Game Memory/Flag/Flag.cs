using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory
{
    public class Flag
    {
        public Image image { get; }
        public string name { get; }
        public string tag { get; }

        public Flag(Image image, string name, string tag)
        {
            this.image = image;
            this.name = name;
            this.tag = tag;
        } 
    }
}
