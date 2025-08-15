using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public static string GetFirstName(string FirstName)
        {
            StudentInfoClass.FirstName = FirstName;
            return FirstName;
        }

        public static string GetLastName(string LastName)
        {
            StudentInfoClass.LastName = LastName;
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            StudentInfoClass.MiddleName = MiddleName;
            return MiddleName;
        }

        public static string GetAddress(string Address)
        {
            StudentInfoClass.Address = Address;
            return Address;
        }

        public static string GetProgram(string Program)
        {
            StudentInfoClass.Program = Program;
            return Program;
        }

        public static long GetAge(long Age)
        {
            StudentInfoClass.Age = Age;
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            StudentInfoClass.ContactNo = ContactNo;
            return ContactNo;
        }

        public static long GetStudentNo(long StudentNo)
        {
            StudentInfoClass.StudentNo = StudentNo;
            return StudentNo;

        }
    }
}