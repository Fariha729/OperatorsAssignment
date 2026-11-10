// Import Console to display the comparison results.
using System;

// Group the program and Employee class in the same namespace.
namespace OperatorsAssignment
{
    internal class Program
    {
        // Start the console application.
        private static void Main()
        {
            // Create the first employee and assign all three properties.
            Employee firstEmployee = new Employee
            {
                Id = 101,
                FirstName = "Alex",
                LastName = "Smith"
            };

            // Create a separate employee with the same Id but different names.
            Employee secondEmployee = new Employee
            {
                Id = 101,
                FirstName = "Jordan",
                LastName = "Lee"
            };

            // Demonstrate that matching IDs are equal regardless of the names.
            Console.WriteLine("Same IDs:");
            Console.WriteLine("firstEmployee == secondEmployee: " + (firstEmployee == secondEmployee));
            Console.WriteLine("firstEmployee != secondEmployee: " + (firstEmployee != secondEmployee));

            // Change the second Id to demonstrate the unequal case.
            secondEmployee.Id = 202;
            Console.WriteLine("Different IDs:");
            Console.WriteLine("firstEmployee == secondEmployee: " + (firstEmployee == secondEmployee));
            Console.WriteLine("firstEmployee != secondEmployee: " + (firstEmployee != secondEmployee));
        }
    }
}
