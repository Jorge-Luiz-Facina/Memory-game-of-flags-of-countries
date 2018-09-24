using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory.Levels
{
    class Level01 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 2;
            amountLines = 3;
            amountFlag = 6;
            bonusMultiplier = 1;
            timeStopwatch = 40;
        }

        public override Level nextLevel()
        {
            return new Level02();
        }

        public override string getLevel()
        {
            return "Level 01";
        }
    }
}
