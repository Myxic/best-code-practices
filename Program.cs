using System;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {

        /// <summary>
        ///1. Class and Method names should always be in Pascal Case 

        ///public class Employee
        ///   {
        ///       public Employee GetDetails()
        ///       {
        //...
        ///       }
        ///       public double GetBonus()
        ///      {
        //...
        ///       }
        ///   }
        /// <summary>
        /// 2. Method argument and Local variables should always be in Camel Case
        /// 


        ///public class Employee
        ///  {
        ///    public void PrintDetails(int employeeId, String firstName)
        ///   {
        ///        int totalSalary = 2000;
        // ...
        ///        }
        ///   }

        ///3. Avoid the use of underscore while naming identifiers

        // Correct
        ///public DateTime fromDate;
        ///    public String firstName;


        /// Avoid
        ///    public DateTime from_Date;
        ///    public String first_Name;
        /// 4. Avoid the use of System data types and prefer using the Predefined data types.

        // Correct
        /// int employeeId;
        /// string employeeName;
        /// bool isActive;


        /// Avoid
        /// Int32 employeeId;
        /// String employeeName;
        /// Boolean isActive;
        /// 5.Always prefix an interface with letter I.

        /// Correct
        ///public interface IEmployee
        ///{
        ///}
        ///public interface IShape
        ///{
        //}
        ///public interface IAnimal
        ///{
        ///}

        /// Avoid
        ///public interface Employee
        ///{
        ///}
        ///public interface Shape
        ///{
        ///}
        ///public interface Animal
        ///{
        ///}
        ///6.For better code indentation and readability always align the curly braces vertically.  

        /// Correct
        //class Employee
        //{
        //    static void PrintDetails()
        //    {
        //    }
        //}


        //// Avoid
        //class Employee
        //{
        //    static void PrintDetails()
        //    {
        //    }
        //}
        //7.Always use the using keyword when working with disposable types. It automatically disposes the object when program flow leaves the scope.  

        //using (var conn = new SqlConnection(connectionString))
        //{
        // use the connection and the stream
        ///    using (var dr = cmd.ExecuteReader())
        ///    {
        //
        ///   }
        ///}
        ///8.Always declare the variables as close as possible to their use.  

        /// Correct
        ///String firstName = "Shubham";
        ///Console.WriteLine(firstName);
        ///--------------------------


        /// Avoid
        ///String firstName = "Shubham";
        ///--------------------------
        ///--------------------------
        ///--------------------------
        ///Console.WriteLine(firstName);
        ///9.Always declare the properties as private so as to achieve Encapsulation and ensure data hiding.  

        /// Correct
        ///private int employeeId { get; set; }

        /// Avoid
        ///public int employeeId { get; set; }
        ///10.Always separate the methods, different sections of program by one space.  

        /// Correct
        ///class Employee
        ///{
        ///   private int employeeId { get; set; }

        ///    public void PrintDetails()
        ///    {
        ///        //------------
        ///    }
        ///}

        /// Avoid
        ///class Employee
        ///{

        ///    private int employeeId { get; set; }



        ///    public void PrintDetails()
        ///    {
        ///        //------------
        ///    }

        ///}

        // Correct
        ///public const int MIN_AGE = 18;
        ///public const int MAX_AGE = 60;

        // Avoid
        ///public const int Min_Age = 18;
        ///public const int Ma11.Constants should always be declared in UPPER_CASE.  
        ///x_Age = 60;
        ///
 /// 12The method or function should have only single responsibility(one job).Don’t try to combine multiple functionalities into single function.

           /// Correct:
    ///public void UpdateAddress(Address address) { }
     ///   public void InsertAddress(Address address) { }
    ///Avoid:
    /// public void SaveAddress(Address address)
     ///   {
     ///       if (address.AddressId == 0) { } else { }
     ///   }
     ///








        /// </summary>

    }
}