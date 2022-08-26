using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    internal class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = day;
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }
    }
}
