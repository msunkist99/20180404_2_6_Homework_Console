using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  add this using statement to provide access the Student class in the People folder
using _20180404_2_6_Homework_Console.People;

namespace _20180404_2_6_Homework_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20180404_2_6_Homework_Console";

            bool continueLoop = true;
            string userInputString;
            Student selectedStudent;

            //  the following creates my Dictionary collection named - students - which is a collection
            //  of objects created from the Student class
            //  I create the collection
            //  and then load the dictionary key - student's first name - and theStudent class objects into the collection at the same time that I
            //  load the property values of the Student class object
            Dictionary<string, Student> students = new Dictionary<string, Student>()
            {
                {"Abby", new Student{LastName = "Smith", FirstName = "Abby", Grade = 1, GPA = 3.25, FirstNamesEnum = FirstNames.Abby} },
                {"Alex", new Student() {LastName = "Wallen", FirstName = "Alex", Grade = 2, GPA = 2.5, FirstNamesEnum = FirstNames.Alex} },
                {"Lauren", new Student() {LastName = "Jones", FirstName = "Lauren", Grade = 8, GPA = 2, FirstNamesEnum = FirstNames.Lauren } },
                {"Drew", new Student() {LastName = "Star", FirstName = "Drew", Grade = 9, GPA = 3.75, FirstNamesEnum = FirstNames.Drew } },
                {"Sara", new Student() {LastName = "Jordan", FirstName = "Sara", Grade = 10, GPA = 4, FirstNamesEnum = FirstNames.Sara } },
                {"Cameron", new Student() {LastName = "Barnes", FirstName = "Cameron", Grade = 11, GPA = 3.5, FirstNamesEnum= FirstNames.Cameron} },
                {"Linsey", new Student() {LastName = "Pointer", FirstName = "Linsey", Grade = 10, GPA = 3, FirstNamesEnum = FirstNames.Lindsey } },
                {"Ashley", new Student() {LastName = "Fletcher", FirstName = "Ashley", Grade = 9, GPA = 3.25, FirstNamesEnum = FirstNames.Ashley } },
                {"Jaden", new Student() {LastName = "Williams", FirstName = "Jaden", Grade = 11, GPA = 2.75, FirstNamesEnum = FirstNames.Jaden } },
                {"Danielle", new Student() {LastName = "Powers", FirstName = "Danielle", Grade = 10, GPA = 2.25, FirstNamesEnum = FirstNames.Danielle } }
            };

            foreach (KeyValuePair<string, Student> student in students)
            {
                Console.WriteLine("{0} {1}", student.Value.FirstName, student.Value.LastName);
            }

            while (continueLoop == true)
            {
                Console.WriteLine("Enter the first name");
                userInputString = Console.ReadLine();

                if (userInputString == "")
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    continueLoop = false;
                    break;
                }
                // I am looking for the key value (first name input from the user) in my dictionary collection
                if (students.TryGetValue(userInputString, out selectedStudent) == true)
                {
                    Console.WriteLine("Last name is - {0}\r\n", ReturnLastName(selectedStudent.FirstNamesEnum));
                }
                else
                {
                    // the key value (first name input from the user) was not found in my dictionary collection
                    Console.Write("First name not found - re-enter the first name");
                }
            }
        }

        // look up the last name using the switch/case user the FirstNamesEnum value from the Student class
        static string ReturnLastName (FirstNames firstName)
        {
            switch (firstName)
            {
                case FirstNames.NoName:
                    Console.Write("xxx - " + FirstNames.NoName + " - ");
                    return "NoName";
                case FirstNames.Abby:
                    Console.Write("xxx - " + FirstNames.Abby + " - " );
                    return "Smith";
                case FirstNames.Alex:
                    Console.Write("xxx - " + FirstNames.Alex + " - ");
                    return "Wallen";
                case FirstNames.Lauren:
                    Console.Write("xxx - " + FirstNames.Lauren + " - ");
                    return "Jones";
                case FirstNames.Drew:
                    Console.Write("xxx - " + FirstNames.Drew + " - ");
                    return "Star";
                case FirstNames.Sara:
                    Console.Write("xxx - " + FirstNames.Sara + " - ");
                    return "Jordan";
                case FirstNames.Cameron:
                    Console.Write("xxx - " + FirstNames.Cameron + " - ");
                    return "Barnes";
                case FirstNames.Lindsey:
                    Console.Write("xxx - " + FirstNames.Lindsey + " - ");
                    return "Pointer";
                case FirstNames.Ashley:
                    Console.Write("xxx - " + FirstNames.Ashley + " - ");
                    return "Fletcher";
                case FirstNames.Jaden:
                    Console.Write("xxx - " + FirstNames.Jaden + " - ");
                    return "Williams";
                case FirstNames.Danielle:
                    Console.Write("xxx - " + FirstNames.Danielle + " - ");
                    return "Powers";
                default:
                    return "You entered bad input";
            }
        }
    }
}
