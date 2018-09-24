using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory.Levels
{
    class Level09 : Level
    {
        public override void start()
        {
            stopwatch.end();
        }

        protected override void setProperties()
        {
            throw new Exception("Level Victory");
        }

        public override Level nextLevel()
        {
            throw new Exception("Level Victory");
        }

        public override string getLevel()
        {
            return "Level";
        }
    }
}
