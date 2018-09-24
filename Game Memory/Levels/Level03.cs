using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory.Levels
{
    class Level03 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 4;
            amountLines = 4;
            amountFlag = 16;
            bonusMultiplier = 3;
            timeStopwatch = 90;
        }

        public override Level nextLevel()
        {
            return new Level04();
        }

        public override string getLevel()
        {
            return "Level 03";
        }
    }
}
