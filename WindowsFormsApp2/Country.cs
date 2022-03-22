using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Country
    {
        String CountryCode;
        String CountryName;

        //todo Сделать через инициализацую
        public void Set(String CountryCode, String countryName)
        {
            this.CountryCode = CountryCode;
            this.CountryName = countryName;
        }
    }
}
