namespace Game_Memory.Levels
{
    class Level02 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 3;
            amountLines = 4;
            amountFlag = 12;
            bonusMultiplier = 2;
            timeStopwatch = 60;
        }

        public override Level nextLevel()
        {
            return new Level03();
        }

        public override string getLevel()
        {
            return "Level 02";
        }
    }
}
