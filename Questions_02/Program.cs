using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        //What is the output of the short program below?
        static string location;
        static DateTime time;
        static void Main(string[] args)
        {
            Console.WriteLine(location==null ?"location is null":location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            Console.ReadLine();
        }
       /* location is null
        1/1/0001 12:00:00 AM
        Although both variables are uninitialized, String is a reference type and DateTime is a value type.As a value type, 
        an unitialized DateTime variable is set to a default value of midnight of 1/1/1 (yup, that’s the year 1 A.D.), not null.*/
    }
}
