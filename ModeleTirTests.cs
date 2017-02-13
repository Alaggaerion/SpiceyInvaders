using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using spicyInvader1._1;

namespace spicyInvader.Tests
{
    [TestClass]
    public class ModeleTirTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.sens = false;
            string resultatSens = "";
            char texture;
            int cycle;
            int uniteDeplAxeX;

            //Act
            resultatSens = Convert.ToString(modeleTir1.sens);
            //Assert
            Assert.AreEqual("false", resultatSens, "Le resultat doit false");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.sens = true;
            string resultatSens = "";
            char texture;
            int cycle;
            int uniteDeplAxeX;

            //Act
            resultatSens = Convert.ToString(modeleTir1.sens);

            //Assert
            Assert.AreEqual("true", resultatSens, "Le resultat doit true");
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.texture = 'X';
            string resultatTexture = "";
            char texture;
            int cycle;
            int uniteDeplAxeX;

            //Act
            resultatTexture = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("X", resultatTexture, "Le resultat doit X");
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.texture = '▒';
            string resultatTexture = "";
            char texture;
            int cycle;
            int uniteDeplAxeX;

            //Act
            resultatTexture = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("▒", resultatTexture, "Le resultat doit ▒");
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.texture = '▒';
            string resultatTexture = "";

            //Act
            resultatTexture = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("▒", resultatTexture, "Le resultat doit ▒");
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.cycle = 3;
            string resultatCycle = "";

            //Act
            resultatCycle = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("1", resultatCycle, "Le resultat doit 1");
        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.cycle = 1;
            string resultatCycle = "";

            //Act
            resultatCycle = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("3", resultatCycle, "Le resultat doit 3");
        }

        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.cycle = 5;
            string resultatCycle = "";

            //Act
            resultatCycle = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("5", resultatCycle, "Le resultat doit 5");
        }

        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.uniteDeplAxeX = 1;
            string resultatUniteDeplAxeX = "";

            //Act
            resultatUniteDeplAxeX = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("1", resultatUniteDeplAxeX, "Le resultat doit 1");
        }

        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            ModeleTir modeleTir1 = new ModeleTir();
            modeleTir1.uniteDeplAxeX = 2;
            string resultatUniteDeplAxeX = "";

            //Act
            resultatUniteDeplAxeX = Convert.ToString(modeleTir1.texture);

            //Assert
            Assert.AreEqual("2", resultatUniteDeplAxeX, "Le resultat doit 2");
        }
    }
}
