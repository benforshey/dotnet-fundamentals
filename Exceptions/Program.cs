/**
 * Program
 * Challenge
    This application manages transactions at a store check-out line. The check-out line has a cash register, and the register has a cash till that is prepared with a number of bills each morning. The till includes bills of four denominations: $1, $5, $10, and $20. The till is used to provide the customer with change during the transaction. The item cost is a randomly generated number between 2 and 49. The customer offers payment based on an algorithm that determines a number of bills in each denomination. 

    Each day, the cash till is loaded at the start of the day. As transactions occur, the cash till is managed in a method named MakeChange (customer payments go in and the change returned to the customer comes out). A separate "safety check" calculation that's used to verify the amount of money in the till is performed in the "main program". This safety check is used to ensure that logic in the MakeChange method is working as expected.
*/

string? readResult = null;
bool useTestData = true;

Console.Clear();

int[] cashTill = new int[] { 0, 0, 0, 0 };
int registerCheckTillTotal = 0;

// registerDailyStartingCash: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] testData = new int[] { 6, 10, 17, 20, 31, 36, 40, 41 };
int testCounter = 0;

LoadTillEachMorning(registerDailyStartingCash, cashTill);

registerCheckTillTotal = registerDailyStartingCash[0, 0] * registerDailyStartingCash[0, 1] + registerDailyStartingCash[1, 0] * registerDailyStartingCash[1, 1] + registerDailyStartingCash[2, 0] * registerDailyStartingCash[2, 1] + registerDailyStartingCash[3, 0] * registerDailyStartingCash[3, 1];

// display the number of bills of each denomination currently in the till
LogTillStatus(cashTill);

// display a message showing the amount of cash in the till
Console.WriteLine(TillAmountSummary(cashTill));

// display the expected registerDailyStartingCash total
Console.WriteLine($"Expected till value: {registerCheckTillTotal}\n\r");

var valueGenerator = new Random((int)DateTime.Now.Ticks);

int transactions = 40;

if (useTestData)
{
    transactions = testData.Length;
}

while (transactions > 0)
{
    transactions -= 1;
    int itemCost = valueGenerator.Next(2, 50);

    if (useTestData)
    {
        itemCost = testData[testCounter];
        testCounter += 1;
    }

    int paymentOnes = itemCost % 2;                 // value is 1 when itemCost is odd, value is 0 when itemCost is even
    int paymentFives = (itemCost % 10 > 7) ? 1 : 0; // value is 1 when itemCost ends with 8 or 9, otherwise value is 0
    int paymentTens = (itemCost % 20 > 13) ? 1 : 0; // value is 1 when 13 < itemCost < 20 OR 33 < itemCost < 40, otherwise value is 0
    int paymentTwenties = (itemCost < 20) ? 1 : 2;  // value is 1 when itemCost < 20, otherwise value is 2

    // display messages describing the current transaction
    Console.WriteLine($"Customer is making a ${itemCost} purchase");
    Console.WriteLine($"\t Using {paymentTwenties} twenty dollar bills");
    Console.WriteLine($"\t Using {paymentTens} ten dollar bills");
    Console.WriteLine($"\t Using {paymentFives} five dollar bills");
    Console.WriteLine($"\t Using {paymentOnes} one dollar bills");

    try
    {
        // MakeChange manages the transaction and updates the till 
        MakeChange(itemCost, cashTill, paymentTwenties, paymentTens, paymentFives, paymentOnes);

        Console.WriteLine($"Transaction successfully completed.");
        registerCheckTillTotal += itemCost;
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Could not complete transaction: {e.Message}");
    }
}

Console.WriteLine("Press the Enter key to exit");
do
{
    readResult = Console.ReadLine();

} while (readResult == null);

static void LoadTillEachMorning(int[,] registerDailyStartingCash, int[] cashTill)
{
    cashTill[0] = registerDailyStartingCash[0, 1];
    cashTill[1] = registerDailyStartingCash[1, 1];
    cashTill[2] = registerDailyStartingCash[2, 1];
    cashTill[3] = registerDailyStartingCash[3, 1];
}

static void MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
    cashTill[3] += twenties;
    cashTill[2] += tens;
    cashTill[1] += fives;
    cashTill[0] += ones;

    int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
    int changeNeeded = amountPaid - cost;

    if (changeNeeded < 0)
        throw new InvalidOperationException("InvalidOperationException: Not enough money provided to complete the transaction.");

    Console.WriteLine("Cashier Returns:");

    while ((changeNeeded > 19) && (cashTill[3] > 0))
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0))
    {
        cashTill[0]--;
        changeNeeded--;
        Console.WriteLine("\t A one");
    }

    if (changeNeeded > 0)
        throw new InvalidOperationException("InvalidOperationException: The till is unable to make the correct change.");
}

static void LogTillStatus(int[] cashTill)
{
    Console.WriteLine("The till currently has:");
    Console.WriteLine($"{cashTill[3] * 20} in twenties");
    Console.WriteLine($"{cashTill[2] * 10} in tens");
    Console.WriteLine($"{cashTill[1] * 5} in fives");
    Console.WriteLine($"{cashTill[0]} in ones");
    Console.WriteLine();
}

static string TillAmountSummary(int[] cashTill)
{
    return $"The till has {cashTill[3] * 20 + cashTill[2] * 10 + cashTill[1] * 5 + cashTill[0]} dollars";

}
/**
 * Program
 * Challenge
 */
// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };
//
// try
// {
//     Workflow1(userEnteredValues);
//     Console.WriteLine("'Workflow1' completed successfully.");
//
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(ex.Message);
// }
//
// static void Workflow1(string[][] userEnteredValues)
// {
//     foreach (string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             Process1(userEntries);
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine("'Process1' encountered an issue, process aborted.");
//             Console.WriteLine(ex.Message);
//             Console.WriteLine();
//         }
//     }
// }
//
// static void Process1(String[] userEntries)
// {
//     int valueEntered;
//
//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);
//
//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
//             }
//         }
//         else
//         {
//             throw new FormatException("Invalid data. User input values must be valid integers.");
//         }
//     }
// }

/**
 * Program
 * Throw Exceptions
    When you have two or more exception types to choose from, select the exception type that fits the issue more closely. In this case, the two exception types are aligned to the issue equally. When you have two or more exception types that are aligned to the issue equally, select the most narrowly scoped exception type. Whenever possible, exceptions should be caught at the call stack level where they can be handled.
 */
// // Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());
//
// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());
//
// decimal averageValue = 0;
//
// bool exit = false;
//
// do
// {
//     try
//     {
//         // Calculate the sum of the even numbers between the bounds
//         averageValue = AverageOfEvenNumbers(lowerBound, upperBound);
//
//         // Display the result to the user
//         Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
//
//         exit = true;
//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine("An error has occurred.");
//         Console.WriteLine(ex.Message);
//         Console.WriteLine($"The upper bound must be greater than {lowerBound}");
//         Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
//         string? userResponse = Console.ReadLine();
//
//         if (userResponse.ToLower().Contains("exit"))
//         {
//             exit = true;
//         }
//         else
//         {
//             exit = false;
//             upperBound = int.Parse(userResponse);
//         }
//     }
// } while (exit == false);
//
// // Wait for user input
// Console.ReadLine();
//
// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {
//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//     }
//
//     int sum = 0;
//     int count = 0;
//     decimal average = 0;
//
//     for (int i = lowerBound; i <= upperBound; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += i;
//             count++;
//         }
//     }
//
//     average = (decimal)sum / count;
//
//     return average;
// }

/**
 * Program
 * Throw Exceptions
    - Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
    - Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
    - Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
    - Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.
 */
// using System.Diagnostics;
//
// Debug.Assert(true, "This is a debug-only assertion; this won't show in production.");
//
// try
// {
//     OperatingProcedure1();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine("Exiting application.");
// }
//
// static void OperatingProcedure1()
// {
//     string[][] userEnteredValues = new string[][]
//     {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
//     };
//
//     foreach (string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             BusinessProcess1(userEntries);
//         }
//         catch (Exception ex)
//         {
//             if (ex.StackTrace.Contains("BusinessProcess1"))
//             {
//                 if (ex is FormatException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
//                 }
//                 else if (ex is DivideByZeroException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");
//
//                     // re-throw the original exception
//                     throw;
//                 }
//                 else
//                 {
//                     // create a new exception object that wraps the original exception
//                     throw new ApplicationException("An error occurred - ", ex);
//                 }
//             }
//         }
//
//     }
// }
//
// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;
//
//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);
//
//             checked
//             {
//                 int calculatedValue = 4 / valueEntered;
//             }
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//         catch (DivideByZeroException)
//         {
//             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
//             throw unexpectedDivideByZeroException;
//         }
//     }
// }

/**
 * Program
 * Challenge
 */
// checked
// {
//     try
//     {
//         int num1 = int.MaxValue;
//         int num2 = int.MaxValue;
//         int result = num1 + num2;
//         Console.WriteLine("Result: " + result);
//     }
//     catch (OverflowException ex)
//     {
//         Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
//     }
// }
//
// try
// {
//     string? str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null. " + ex.Message);
// }
//
// try
// {
//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range. " + ex.Message);
// }
//
// try
// {
//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
// }
//
// Console.WriteLine("Exiting program.");

/**
 * Program
 * Catching Multiple Exception Types
 */
// // inputValues is used to store numeric values entered by a user
// string[] inputValues = new string[] { "three", "9999999999", "0", "2" };
//
// foreach (string inputValue in inputValues)
// {
//     int numValue = 0;
//     try
//     {
//         numValue = int.Parse(inputValue);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid readResult. Please enter a valid number.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number you entered is too large or too small.");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }

/**
 * Program
 * Catching Specific Exception Types
 */
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }
//
// Console.WriteLine("Exit program");
//
// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException ex) // The catch block in Process1 is not executed. This is the behavior that you wanted. Only catch the exceptions that your code is prepared to handle.
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }
//
// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     // int number2 = 0;
//     byte smallNumber;
//
//     Console.WriteLine(float1 / float2);
//     // Console.WriteLine(number1 / number2);
//     checked
//     {
//         smallNumber = (byte)number1;
//     }
// }
/**
In a checked context, the conversion succeeds if the source value is within the range of the destination type. Otherwise, an OverflowException is thrown. In an unchecked context, the conversion always succeeds, and proceeds as follows:

    - If the source type is larger than the destination type, then the source value is truncated by discarding its "extra" most significant bits. The result is then treated as a value of the destination type.

    - If the source type is smaller than the destination type, then the source value is either sign-extended or zero-extended so that it's of the same size as the destination type. Sign-extension is used if the source type is signed; zero-extension is used if the source type is unsigned. The result is then treated as a value of the destination type.

    - If the source type is the same size as the destination type, then the source value is treated as a value of the destination type.
 */

/**
 * Program
 * Challenge
 */
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }
//
// Console.WriteLine("Exit program");
//
// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//
//     }
//     catch
//     {
//         Console.WriteLine("Exception caught in Process1");
//     }
// }
//
// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

/**
 * Program
 */
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }
//
// Console.WriteLine("Exit program");
//
// static void Process1()
// {
//     WriteMessage();
// }
//
// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

// try
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//
//     Console.WriteLine(float1 / float2); // Logs inifinity
//     Console.WriteLine(number1 / number2);
//     Console.WriteLine("Exit program");
// }
// catch
// {
//     Console.WriteLine("Catch block");
//
// }
// finally
// {
//     Console.WriteLine("Finally block");
// }

/**
 * Program
 The .NET runtime throws exceptions when basic operations fail. Here's a short list of runtime exceptions and their error conditions:
    - ArrayTypeMismatchException: Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
    - DivideByZeroException: Thrown when an attempt is made to divide an integral value by zero.
    - FormatException: Thrown when the format of an argument is invalid.
    - IndexOutOfRangeException: Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
    - InvalidCastException: Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.
    - NullReferenceException: Thrown when an attempt is made to reference an object whose value is null.
    - OverflowException: Thrown when an arithmetic operation in a checked context overflows.
 */
// decimal x = 400;
// // decimal x = 255;
// byte i;
//
// i = (byte)x; // OverflowException occurs
// Console.WriteLine(i);

// int[] values = null;
// for (int i = 0; i <= 9; i++)
//     values[i] = i * 2; // NullReferenceException occurs

// string? lowCaseString = null;
// Console.WriteLine(lowCaseString.ToUpper()); // NullReferenceException occurs

// object obj = "This is a string";
// int num = (int)obj; // InvalidCastException occurs

// int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
// int[] values2 = new int[6];
//
// values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
// // values2[values2.Length - 1] = values1[values1.Length - 1];

// int valueEntered;
// string userValue = "two";
// // string userValue = "2";
// valueEntered = int.Parse(userValue); // FormatException occurs

// int number1 = 3000;
// int number2 = 0;
// // int number2 = 10;
// Console.WriteLine(number1 / number2); // DivideByZeroException occurs

// string[] names = { "Dog", "Cat", "Fish" };
// Object[] objs = (Object[])names;
//
// Object obj = (Object)13;
// // Object obj = (Object)"Bird";
// objs[2] = obj; // ArrayTypeMismatchException occurs

/**
 * Program
 * Exception handling in a C# application is generally implemented using one or more of the following patterns:
    - The try-catch pattern consists of a try block followed by one or more catch clauses. Each catch block is used to specify handlers for different exceptions.
    - The try-finally pattern consists of a try block followed by a finally block. Typically, the statements of a finally block run when control leaves a try statement.
    - The try-catch-finally pattern implements all three types of exception handling blocks. A common scenario for the try-catch-finally pattern is when resources are obtained and used in a try block, exceptional circumstances are managed in a catch block, and the resources are released or otherwise managed in the finally block.
*/

/** Nested */
//// Call stack unwinding is the process that the .NET runtime uses when a C# program encounters an error.
// try
// {
//     // Step 1: code execution begins
//     try
//     {
//         // Step 2: an exception occurs here
//     }
//     finally
//     {
//         // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
//     }
// }
// catch // Step 3: the system finds a catch clause that can handle the exception
// {
//     // Step 5: the system transfers control to the first line of the catch code block
// }
//
// /** "Normal" */
// try
// {
//     // try code block - code that may generate an exception
// }
// catch
// {
//     // catch code block - code to handle an exception
//     // If no catch clause is found to handle the exception, the runtime terminates the application and displays an error message to the user.
// }
// finally
// {
//     // finally code block - code to clean up resources
//     // If more than one finally block is found, they are executed in order, starting with the one closest to the code that caused the exception to be thrown.
// }
