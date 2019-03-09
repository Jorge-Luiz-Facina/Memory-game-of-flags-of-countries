namespace Game_Memory.Levels
{
    class Level07 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 6;
            amountLines = 7;
            amountFlag = 42;
            bonusMultiplier = 7;
            timeStopwatch = 320;
        }

        public override Level nextLevel()
        {
            return new Level08();
        }

        public override string getLevel()
        {
            return "Level 07";
        }
    }
}
