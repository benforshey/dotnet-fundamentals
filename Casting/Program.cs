/**
 * PROGRAM
 * To perform data conversion, you can use one of several techniques:
 * - Use a helper method on the data type
 * - Use a helper method on the variable
 * - Use the Convert class' methods
 */
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
// float result3 = value3 / (float)value1; // don't actually need the cast
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

/**
 * PROGRAM
 * To perform data conversion, you can use one of several techniques:
 * - Use a helper method on the data type
 * - Use a helper method on the variable
 * - Use the Convert class' methods
 */
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string message = "";
// decimal total = 0;
//
// foreach (string value in values)
// {
//     if (decimal.TryParse(value, out decimal decimalResult))
//     {
//         total += decimalResult;
//     }
//     else
//     {
//         message += value;
//     }
// }
//
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

/**
 * PROGRAM
 * To perform data conversion, you can use one of several techniques:
 * - Use a helper method on the data type
 * - Use a helper method on the variable
 * - Use the Convert class' methods
 */
// TryParse
// string name = "Bob";
// Console.WriteLine(int.Parse(name)); // Throws exception: FormatException

// string value = "102";
// string value = "bob";
// int result = 0;
// When calling a method with an out parameter, you must use the keyword out before the variable, which holds the value. The out parameter is assigned to the result variable in the code (int.TryParse(value, out result). You can then use the value the out parameter contains throughout the rest of your code using the variable result.
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine($"Unable to report the measurement: {value}");
// }
//
// if (result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// CASTING VS CONVERTING
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);
//
// int value2 = Convert.ToInt32(1.5m); // converting rounds
// Console.WriteLine(value2);

// CONVERTING
// int firstNum = 5;
// int secondNum = 7;
// string message = firstNum.ToString() + secondNum.ToString();
// Console.WriteLine(message);

// string firstString = "5";
// string secondString = "7";
// int sum = int.Parse(firstString) + int.Parse(secondString); // cannot (int)firstString + (int)secondString; should use TryParse
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) + Convert.ToInt32(value2); // should use TryParse
// Console.WriteLine(result);

// CASTING
// When you know you're performing a narrowing conversion (from a data type that can hold more information to a data type that can hold less information), you need to perform a cast.
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");
//
// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// A narrowing conversion can lose information.
// decimal myDecimal = 1.234567890m;
// float myFloat = (float)myDecimal;
//
// Console.WriteLine($"decimal: {myDecimal}");
// Console.WriteLine($"float  : {myFloat}");

// IMPLICIT CONVERSION
// When you know you're performing a widening conversion (from a data type that could hold less information to a data type that can hold more information), you can rely on implicit conversion. The compiler handles implicit conversions.
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");
//
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// int first = 2;
// string second = "4";
// // int result = first + second; // compilation error: cannot implicitly convert type 'string' to 'int'
// string result = first + second; // cast to string
// Console.WriteLine(result);

