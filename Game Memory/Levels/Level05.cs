using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory.Levels
{
    class Level05 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 5;
            amountLines = 6;
            amountFlag = 30;
            bonusMultiplier = 5;
            timeStopwatch = 200;
        }

        public override Level nextLevel()
        {
            return new Level06();
        }

        public override string getLevel()
        {
            return "Level 05";
        }
    }
}
