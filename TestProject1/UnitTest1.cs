using VIN_LIB;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN_OnlyFromNumbers()//только цифры
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckVIN_OnlyFromLetters()//только буквы
        {
            string vin = "AAAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckVIN_ForbiddenLetters()//запрещенный символ
        {
            string vin = "AQAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_LengthLess()//длина vin менньше, чем нужно
        {
            string vin = "AQAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_LengthLonger()//длина vin больше, чем нужно
        {
            string vin = "AQAAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_RussianLetters()//использование русских букв вместо английских
        {
            string vin = "ПРИВЕТПРИВЕТПРИВЕ";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetVINCountry_VinFromAfrica()//vin начинающийся на букву
        {
            string vin = "A1111111111111111";
            string execept = "Африка";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_WrongVin()//неверный vin
        {
            string vin = "аррараладад";
            string execept = "Такого vin не существует";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_VinFromOkeania()//vin начинающийся на цифру
        {
            string vin = "61111111111111111";
            string execept = "Океания";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_()//vin начинающийся на цифру
        {
            string vin = "611111L1111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }
    }
}