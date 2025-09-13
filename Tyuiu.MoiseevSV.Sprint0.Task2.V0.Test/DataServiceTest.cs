using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MoiseevSV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MoiseevSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheakGetMassageValid()
        {
            var name = "Степан";
            var res = DataService.GetMassage(name);
            Assert.AreEqual("Привет, Степан", res);
        }
    }
}
