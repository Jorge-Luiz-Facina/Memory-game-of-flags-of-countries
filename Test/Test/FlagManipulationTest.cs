using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Memory;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class FlagManipulationTest
    {
        [TestInitialize]
        public void Before()
        {
            FlagManipulation.allFlags = new List<Flag>();
            FlagManipulation.loadAllFlags();
        }

        [TestMethod]
        public void loadAllFlagsTest()
        {
            Assert.AreEqual(195, FlagManipulation.allFlags.Count);
        }

        [TestMethod]
        public void loadImageDoubtTest()
        {
            FlagManipulation.loadImageDoubt();
            Assert.AreEqual("doubt",FlagManipulation.doubt.name);
        }

        [TestMethod]
        public void flagAddTest()
        {
            FlagManipulation.add(4);
            Assert.AreEqual(4, FlagManipulation.flags.Count);
            Assert.AreEqual(191, FlagManipulation.allFlags.Count);
        }

        [TestMethod]
        public void flagDuplicateTest()
        {
            FlagManipulation.add(4);
            int amountFlags = FlagManipulation.flags.Count * 2;
            Assert.AreEqual(amountFlags, FlagManipulation.duplicateFlag().Count);
        }
    }
}
