using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    internal class StudentInfoClass
    {


        // Delegates
        public delegate string DelegateText();
        public delegate long DelegateNumber();

        // Static variables
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;  


        public static string GetFirstName()
        {
           
            return FirstName;
        }

        public static string GetLastName()
        {
          
            return LastName;
        }

        public static string GetMiddleName()
        {
           
            return MiddleName;
        }

        public static string GetAddress()
        {
          
            return Address;
        }

        public static string GetProgram()
        {
           
           return Program;
        }

        public static long GetAge()
        {
            
            return Age;
        }

        public static long GetContactNo()
        {
           
            return ContactNo;
        }

        public static long GetStudentNo()
        {
            ;
            return StudentNo;

        }
    }
}