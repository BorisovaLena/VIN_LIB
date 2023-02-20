using VIN_LIB;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN_OnlyFromNumbers()//������ �����
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckVIN_OnlyFromLetters()//������ �����
        {
            string vin = "AAAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckVIN_ForbiddenLetters()//����������� ������
        {
            string vin = "AQAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_LengthLess()//����� vin �������, ��� �����
        {
            string vin = "AQAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_LengthLonger()//����� vin ������, ��� �����
        {
            string vin = "AQAAAAAAAAAAAAAAAA";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckVIN_RussianLetters()//������������� ������� ���� ������ ����������
        {
            string vin = "�����������������";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetVINCountry_VinFromAfrica()//vin ������������ �� �����
        {
            string vin = "A1111111111111111";
            string execept = "������";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_WrongVin()//�������� vin
        {
            string vin = "�����������";
            string execept = "������ vin �� ����������";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_VinFromOkeania()//vin ������������ �� �����
        {
            string vin = "61111111111111111";
            string execept = "�������";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(execept, actual);
        }

        [TestMethod]
        public void GetVINCountry_DoesNotReturnNullWithCorrectData()//�� ���������� null � ����������� �������
        {
            string vin = "61111111111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CheckVIN_DoesNotReturnNullWithCorrectData()//�� ���������� null � ����������� �������
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void GetVINCountry_DoesNotReturnNullWithWrongData()//�� ���������� null � ��������� �������
        {
            string vin = "Q1111111111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CheckVIN_DoesNotReturnNullWithWrongData()//�� ���������� null � ��������� �������
        {
            string vin = "11111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void CheckVIN_ReturnBool()//����� CheckVIN ���������� bool
        {
            string vin = "11111111111111111";
            Class1 class1 = new Class1();
            bool actual = class1.CheckVIN(vin);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        [TestMethod]
        public void GetVINCountry_ReturnString()//����� GetVINCountry ���������� bool
        {
            string vin = "61111111111111111";
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
    }
}