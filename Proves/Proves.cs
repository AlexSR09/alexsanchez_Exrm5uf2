using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Llibreria;
using System.Collections.Generic;

namespace Proves
{
    [TestClass]
    public class Proves
    {
        [TestMethod]
        public void EsPrimer()
        {
            bool resultat = true;
            ClFuncions llb = new ClFuncions();
            resultat = llb.EsPrimer(3);
            Assert.AreEqual( true, resultat);

        }

        [TestMethod]
        public void EsMesGran()
        {
            Int32 resultat = 0;
            ClFuncions llb = new ClFuncions();
            resultat = llb.EsMesGran(5,5);
            Assert.AreEqual(10, resultat);

        }
    }
}
