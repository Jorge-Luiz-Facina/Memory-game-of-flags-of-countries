using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory.Levels
{
    abstract class Level
    {
        protected int amountColumns;
        protected int amountLines;
        protected int amountFlag;
        protected int numberDoubledFlags;
        protected int bonusMultiplier;
        protected int timeStopwatch;
        private static Window window = new Window();
        protected static StopwatchForm stopwatch = new StopwatchForm();

        private int hits;

        protected abstract void setProperties();
        public abstract Level nextLevel();
        public abstract string getLevel();

        public virtual void start()
        {
            setProperties();
            numberDoubledFlags = amountFlag / 2;
            FlagManipulation.clear();
            FlagManipulation.add(numberDoubledFlags);
            FlagManipulation.duplicateFlag();
            FlagManipulation.random();
            window.setWindow(amountFlag, amountColumns, amountLines);
            stopwatch.start(timeStopwatch);
        }

        public void increaseHits()
        {
            hits++;
        }

        public int getHits()
        {
            return hits;
        }

        public int maxHits()
        {
            return numberDoubledFlags;
        }

        public int multiplierPoints()
        {
            return bonusMultiplier;
        }
    }
}
