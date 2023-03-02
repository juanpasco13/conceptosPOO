using System;
using System.Collections.Generic;
using System.Text;

namespace conceptosPOO
{
    public class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day;
        #endregion

        #region Methods
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = ValidateMonth(month);
            _day = day;
        }

        private int ValidateMonth(int month)
        {
            return (month > 0 && month < 13)?month : 0;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            // Formas de imprimir un String de varios ITEMs
            //return $"{_day}/{_month}/{_year}";
            return String.Format("{0}/{1}/{2}", _day, _month, _year);
        }
        #endregion
    }
}
