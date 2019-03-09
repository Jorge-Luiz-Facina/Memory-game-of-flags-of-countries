namespace Game_Memory.Levels
{
    class Level06 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 6;
            amountLines = 6;
            amountFlag = 36;
            bonusMultiplier = 6;
            timeStopwatch = 260;
        }

        public override Level nextLevel()
        {
            return new Level07();
        }

        public override string getLevel()
        {
            return "Level 06";
        }
    }
}
