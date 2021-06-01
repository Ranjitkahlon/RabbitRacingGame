using Microsoft.VisualStudio.TestTools.UnitTesting;
using RabbitRacingGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitRacingGame.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void MainFormTest()
        {
            Instruction pujara = new Instruction();
            pujara.Name = "pujara";
            pujara.bet = 20;
            pujara.budget = 50;
            pujara.rabit = 2;
            pujara.winner = 2;
            
            if (pujara.working() == 70)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }


        [TestMethod()]
        public void MainFormTest2()
        {
            Instruction pujara = new Instruction();
            pujara.Name = "pujara";
            pujara.bet = 20;
            pujara.budget = 50;
            pujara.rabit = 3;
            pujara.winner = 2;
            
            if (pujara.working() == 30)
            {
                Assert.IsTrue(true);
            }
           else
            {
                Assert.IsTrue(false);
            }
        }


    }
}