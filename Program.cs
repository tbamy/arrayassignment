using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an array of 10 students
        string[] studentsArray = { "Paul Pogba", "Mason Greenwood", "Bruno Fernandes", "Sergio Ramos", "Lionel Messi", "Christiano Ronaldo", "Neymar Jnr", "Kylian Mbappe", "Marcus Rashford", "Erling Haaland" };

        // Create a list of student ages
        List<int> studentAges = new List<int> { 20, 18, 22, 19, 21, 18, 23, 24, 20, 19 };

        // Query if a student whose age is 18 is in the list
        bool hasStudentWithAge18 = studentAges.Contains(18);

        // Display the result
        if (hasStudentWithAge18)
        {
            Console.WriteLine("There is a student with age 18 in the list.");
        }
        else
        {
            Console.WriteLine("There is no student with age 18 in the list.");
        }

    }
}
