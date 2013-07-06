using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyrion.Services;
using Id3;
using System.IO;

namespace Tyrion.Tests
{
    [TestClass]
    public class MusicDirectoryTests
    {
        [TestMethod]
        public void Test_AddNonDefault()
        {
            Assert.IsTrue(MusicDirectory.Add(new Id3Tag(),"",new ModelServiceTest(), new ModelServiceTest(), new ModelServiceTest()));
        }
        [TestMethod]
        public void Test_AddDefault()
        {
            Assert.IsTrue(MusicDirectory.Add("","", new ModelServiceTest(),1));
        }
    }
}
