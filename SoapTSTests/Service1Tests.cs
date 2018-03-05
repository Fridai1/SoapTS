using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapTS.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        private Service1 s;

        public Service1Tests()
        {
            s = new Service1();
        }

        [TestMethod()]
        public void GetNameTest()
        {
            Assert.AreEqual("Nikolai", s.GetName());
        }
    }
}