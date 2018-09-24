using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory
{
    public static class FlagManipulation
    {
        public static List<Flag> allFlags = new List<Flag>();
        public static List<Flag> flags = new List<Flag>();
        public static Flag doubt;

        public static void loadAllFlags()
        {
            var images = Properties.Resources.ResourceManager
                       .GetResourceSet(CultureInfo.CurrentCulture, true, true)
                       .Cast<DictionaryEntry>()
                       .Where(x => x.Value.GetType() == typeof(Bitmap))
                       .Select(x => new { Name = x.Key.ToString(), Image = x.Value })
                       .ToList();

            for (int i = 1; i < images.Count; i++)
            {
                allFlags.Add(new Flag((Image)images.ElementAt(i).Image, images.ElementAt(i).Name, "first"));
            }
        }

        public static void loadImageDoubt()
        {
            Image image = Image.FromFile(System.Environment.CurrentDirectory + @"\_doubt.png");
            doubt = new Flag(image, "doubt", "single");
        }

        public static void add(int count)
        {
            flags.Clear();
            Random random = new Random();
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                index = random.Next(allFlags.Count);
                flags.Add(allFlags.ElementAt(index));
                allFlags.RemoveAt(index);
            } 
        }

        public static List<Flag> random()
        {
            Random random = new Random();

            for (int i = flags.Count - 1; i > 1; i--)
            {
                int indiceRandom = random.Next(i + 1);

                Flag value = flags[indiceRandom];
                flags[indiceRandom] = flags[i];
                flags[i] = value;
            }
            return flags;
        }

        public static List<Flag> duplicateFlag()
        {
            int count = flags.Count;
            for (int i = 0; i < count; i++)
            {
                flags.Add(new Flag(flags.ElementAt(i).image, flags.ElementAt(i).name, "second"));
            }
            return flags;
        }

        public static void clear()
        {
            flags.Clear();
        }
    }
}
