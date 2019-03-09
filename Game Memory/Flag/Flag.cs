using System.Drawing;

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
