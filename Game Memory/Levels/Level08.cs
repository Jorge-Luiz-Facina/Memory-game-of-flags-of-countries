namespace Game_Memory.Levels
{
    class Level08 : Level
    {
        protected override void setProperties()
        {
            amountColumns = 8;
            amountLines = 8;
            amountFlag = 64;
            bonusMultiplier = 8;
            timeStopwatch = 500;
        }

        public override Level nextLevel()
        {
            return new Level09();
        }

        public override string getLevel()
        {
            return "Level 08";
        }
    }
}
