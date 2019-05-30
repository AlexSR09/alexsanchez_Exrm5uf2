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
            resultat = llb.EsMesGran(5,10);
            Assert.AreEqual(10, resultat);

        }

        [TestMethod]
        public void EsMesPetit()
        {
            Int32 resultat = 0;
            ClFuncions llb = new ClFuncions();
            resultat = llb.EsMesPetit(5, 2);
            Assert.AreEqual(2, resultat);

        }

        [TestMethod]
        public void Divisors()
        {
            String resultat;
            ClFuncions llb = new ClFuncions();
            resultat = llb.Divisors(50);
            Assert.AreEqual("1,2,5,10,25,50", resultat);

        }
    }
}
