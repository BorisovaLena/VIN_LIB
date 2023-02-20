using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public bool CheckVIN(string vin)
        {
            Regex regex = new Regex("^[ABCDEFGHJKLMNPRSTUVWXYZ | 0-9]{17}");
            if (regex.IsMatch(vin) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetVINCountry(string vin)
        {
            bool rez = CheckVIN(vin);
            if (rez == true)
            {
                Regex regex = new Regex("^[A-H]");
                if (regex.IsMatch(vin) == true)
                {
                    return "Африка";
                }
                Regex regex2 = new Regex("^[JKLMNPR]");
                if (regex2.IsMatch(vin) == true)
                {
                    return "Азия";
                }
                Regex regex3 = new Regex("^[STUVWXYZR]");
                if (regex3.IsMatch(vin) == true)
                {
                    return "Европа";
                }
                Regex regex4 = new Regex("^[1-5]");
                if (regex4.IsMatch(vin) == true)
                {
                    return "Северная Америка";
                }
                Regex regex5 = new Regex("^[6-7]");
                if (regex5.IsMatch(vin) == true)
                {
                    return "Океания";
                }
                Regex regex6 = new Regex("^[8,9]");
                if (regex6.IsMatch(vin) == true)
                {
                    return "Южная Америка";
                }
                else
                {
                    return "Ошибка";
                }
            }
            else
            {
                return "Такого vin не существует";
            }
        }
    }
}
