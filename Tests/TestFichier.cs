using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Tests
{
    [TestClass]
    public class TestFichier
    {

        [TestMethod]
        public void TestCanWriteOk()
        {
            Fichier f = new Fichier("Test", null);
            f.chmod(6);
            Assert.AreEqual(true, f.canWrite());
        }

        public void TestCanWriteKO()
        {

        }
    }
}
