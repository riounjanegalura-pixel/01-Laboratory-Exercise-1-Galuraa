using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class StudentInfo
    {
        public class StudentInfoClass
        {
            // Delegates
            public delegate void DelegateNumber(long number);
            public delegate void DelegateText(string txt);

            // Static variables
            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;
        }


    }
}