namespace Game_Memory.Levels
{
    class Level04 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 4;
            amountLines = 5;
            amountFlag = 20;
            bonusMultiplier = 4;
            timeStopwatch = 160;
        }

        public override Level nextLevel()
        {
            return new Level05();
        }

        public override string getLevel()
        {
            return "Level 04";
        }
    }
}
