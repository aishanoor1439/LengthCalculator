using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Length
    {

//Attributes
        int feet, inch;

//Methods
        public Length()
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Length(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public string getLength()
        {
            return string.Format("Length : {0}' {1} \"", feet, inch);
        }

//Operator overloading
        public static Length operator +(Length l1, Length l2)
        {
            Length l3 = new Length();
            l3.feet = l1.feet + l2.feet;
            l3.inch = l1.inch + l2.inch;
            if (l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }
    }
}
