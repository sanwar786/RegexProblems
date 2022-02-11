using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemsREGEX
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateEmail();
            ValidateMobileNumber();
            ValidatePassword();
            Console.ReadLine();
        }
        public static void ValidateFirstName()
        {
            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();

            //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
            string fNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if
                (Regex.IsMatch(firstName, fNamePattern))
                Console.WriteLine("The Entered First Name Is Valid\n");
            else
            {
                Console.WriteLine("First name should starts with Upper Case and should have minimum Three characters\n");
                ValidateFirstName();
            }
        }

        //Method to check and take the last name using regex(UC2)
        public static void ValidateLastName()
        {
            Console.Write("Enter Your Last Name : ");
            string lastName = Console.ReadLine();

            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
            string lNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if 
                (Regex.IsMatch(lastName, lNamePattern))
                Console.WriteLine("The Given Last Name Is Valid\n");
            else
            {
                Console.WriteLine("Last name should starts with Upper Case and should have minimum Three characters\n");
                ValidateLastName();
            }
        }

        //Method to check and take the valid email using regex(UC3)
        public static void ValidateEmail()
        {
            Console.Write("Enter Your Email Id : ");
            string emailId = Console.ReadLine();

            //Pattern for checking the email id(UC3)
            string emailIdPattern = "^[a-zA-Z0-9]{3,7}([._+-][0-9a-zA-Z]{1,7})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if 
                (Regex.IsMatch(emailId, emailIdPattern))
                Console.WriteLine("The Given Email Id is Valid\n");
            
            else
            {
                Console.WriteLine("The Given Email Id is Not Valid e.g:-abc.xyz@bl.co.in(Email has three mandatory part - abc, bl & co and two optional =xyz & in with precise @ and .position\n");
                ValidateEmail();
            }
        }

        //Method to check and take the valid mobile number using regex(UC4)
        public static void ValidateMobileNumber()
        {
            Console.Write("Enter Your Mobile Number : ");
            string mobileNum = Console.ReadLine();

            //Pattern for checking the mobile number(UC4)
            string mobNumPattern = @"^\+91-[1-9]{1}[0-9]{9}$";
            if 
                (Regex.IsMatch(mobileNum, mobNumPattern))
                Console.WriteLine("The Given Mobile Number is Valid\n");
            else
            {
                Console.WriteLine("The Number Should Follow 91 10 digits E.g. +91-9140626617\n");
                ValidateMobileNumber();
            }
        }

        //Method to check and take the valid password using regex(UC5,UC6,UC7 & UC8)
        public static void ValidatePassword()
        {
            Console.Write("Enter Your Password : ");
            string password = Console.ReadLine();

            //Pattern for checking the password for having atleast one uppercase and number and exactly one special character(UC5,UC6,UC7 & UC8)
            string passwordPattern = "^(?=.*[A-Z])(?=.*[\\d])(?=.*[\\W])[a-zA-Z0-9[~!@#$%^&*()_+{}:\"<>?]{8,}$";
            string specialChar = "[~!@#$%^&*()_+{}:\" <>?]";
            int count = Regex.Matches(password, specialChar).Count;
            Console.WriteLine(count);
            if 
                (Regex.IsMatch(password, passwordPattern) && count == 1)
                Console.WriteLine("The Given Password is Valid\n");
            else
            {
                Console.WriteLine("The Given Password is Not Valid\n");
                ValidatePassword();
            }
        }
    }
}
