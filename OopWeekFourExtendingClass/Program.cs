// 4.6 Extending classes

// Now that you understand the concept of inheritance, let's consider using this knowledge to extend classes.
// When creating a class that is an extension of another class, you need to use a single colon between the derived class name and
// its base class name. Inheritance only works in one direction in the same way that a child inherits from a parent.

using System;
using static System.Console;
namespace DemoLoan1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring loan object
            // Stage 1: Create a class - step2
            Loan aLoan = new Loan();

            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000;
            WriteLine("Loan #{0} for {1} is {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));

            // Declaring a CarLoan object and set values for this object
            // stage2 - step2
            CarLoan aCarLoan = new CarLoan();

            aCarLoan.LoanNumber = 3351;
            aCarLoan.LastName = "Mira";
            aCarLoan.LoanAmount = 20000;
            aCarLoan.Make = "Honda";
            aCarLoan.Year = 2007;

            // stage2 - step3
            WriteLine("Car Loan #{0} for {1} is {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            WriteLine("Loan #{0} is for {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
        }
    }
    class Loan
    {
        // Loan properties
        // Stage 1: Create a class - step1
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount { get; set; }

    }

    // stage2 - step1
    class CarLoan : Loan
    {
        public int Year { get; set; }
        public string Make { get; set; }
    }

}