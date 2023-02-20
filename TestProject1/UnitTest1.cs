using VIN_LIB;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN_OnlyFromNumbers()//vin состоит только цифр
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckVIN_VinWithSpecialSymbol()//vin содержит специальные знаки
        {
            string vin = "A/1111111111*1111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_OnlyFromLetters()//vin состоит только букв
        {
            string vin = "AAAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckVIN_ForbiddenLetters()//vin содержит запрещенный символ Q
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
        public void CheckVIN_RussianLetters()//vin содержит русские буквы
        {
            string vin = "ПРИВЕТПРИВЕТПРИВЕ";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetVINCountry_VinFromAfrica()//vin начинается на букву
        {
            string vin = "A1111111111111111";
            string execept = "Африка";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_WrongVin()//неверный vin в методе GetVINCountry
        {
            string vin = "аррараладад";
            string execept = "Такого vin не существует";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_VinFromOkeania()//vin начинается на цифру
        {
            string vin = "61111111111111111";
            string execept = "Океания";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_DoesNotReturnNullWithCorrectData()//метод GetVINCountry не возвращает null с правильными данными
        {
            string vin = "61111111111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CheckVIN_DoesNotReturnNullWithCorrectData()//метод CheckVIN не возвращает null с правильными данными
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void GetVINCountry_DoesNotReturnNullWithWrongData()//метод GetVINCountry не возвращает null с неверными данными
        {
            string vin = "Q1111111111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CheckVIN_DoesNotReturnNullWithWrongData()//метод CheckVIN не возвращает null с неверными данными
        {
            string vin = "11111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CheckVIN_ReturnBool()//метод CheckVIN возвращает bool
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        [TestMethod]
        public void GetVINCountry_ReturnString()//метод GetVINCountry возвращает string
        {
            string vin = "61111111111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
    }

}