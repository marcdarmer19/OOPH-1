using System;
using System.Collections.Generic;
using System.Text;

namespace OOPH_1
{
    struct Mystruct
    {
        public int Age { get; set; }
        public DateTime birthdate { get; set; }

        public Mystruct(DateTime dirthdate)
        {
            birthdate = dirthdate;
            var yearNow = DateTime.Now.Year;
            var birthdateyear = dirthdate.Year;
            Age = yearNow - birthdateyear;
                
        }
    }
}
