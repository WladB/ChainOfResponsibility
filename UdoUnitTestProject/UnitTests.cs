using Chain_of_Responsibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestForBot1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bot bot = new Bot();
            Operator operat = new Operator();
            Geek geek = new Geek();
            bot.SetNext(operat).SetNext(geek);
            Assert.AreEqual(bot.Handle("У мене не працює комп'ютер").ToString(), "Спробуйте вимкнути та увімкнути знову комп'ютер");
            Assert.AreEqual(bot.Handle("перестав працювати комп'ютер"), null);
        }
       
    }
    [TestClass]
    public class UnitTestForBot2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bot bot = new Bot();
            Operator operat = new Operator();
            Geek geek = new Geek();
            bot.SetNext(operat).SetNext(geek);
            Assert.AreEqual(bot.Handle("у мене не вмикається комп'ютер").ToString(), "Спробуйте вимкнути та увімкнути знову живлення у  комп'ютер");
            Assert.AreEqual(bot.Handle("зламався комп'ютер"), null);
        }

    }
    [TestClass]
    public class UnitTestForOperator1
    {
        [TestMethod]
        public void TestMethod2()
        {
            Bot bot = new Bot();
            Operator operat = new Operator();
            Geek geek = new Geek();
            bot.SetNext(operat).SetNext(geek);
            Assert.AreEqual(bot.Handle("мені не допомогло вимкнути та увімкнути знову комп'ютер").ToString(), "Спробуйте ще раз вимкнути та увімкнути знову комп'ютер");
            Assert.AreEqual(bot.Handle("допомогло- вимкнути та увімкнути знову комп'ютер"), null);
        }
    }
    [TestClass]
    public class UnitTestForOperator2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Bot bot = new Bot();
            Operator operat = new Operator();
            Geek geek = new Geek();
            bot.SetNext(operat).SetNext(geek);
            Assert.AreEqual(bot.Handle("мені не допомагає вимкнути та увімкнути знову комп'ютер").ToString(), "Спробуйте ще раз вимкнути та увімкнути знову комп'ютер");
            Assert.AreEqual(bot.Handle("не спрацювало- вимкнути та увімкнути знову комп'ютер"), null);
        }
    }
    [TestClass]
    public class UnitTestForGeek
    {
        [TestMethod]
        public void TestMethod3()
        {
            Bot bot = new Bot();
            Operator operat = new Operator();
            Geek geek = new Geek();
            bot.SetNext(operat).SetNext(geek);
            Assert.AreEqual(bot.Handle("мені це також не допомогло вимкнути та увімкнути знову комп'ютер").ToString(), "Спробуйте щось окрім цього: вимкнути та увімкнути знову комп'ютер");
            Assert.AreEqual(bot.Handle("мені все ще не допомогло вимкнути та увімкнути знову комп'ютер"), null);
        }
    }
}
