using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory.DataBase
{
    [Serializable]
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int score { get; set; }

        public User(String name)
        {
            this.name = name;
            score = 0;
        }

        public User(int score)
        {
            this.score = score;
        }

        public User() { }
    }
}
