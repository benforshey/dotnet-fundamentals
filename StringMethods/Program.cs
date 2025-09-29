/**
 * Program
 * Challenge
 */
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string divOpen = "<div>";
string divClose = "</div>";
string spanOpen = "<span>";
string spanClose = "</span>";

string quantity = "";
string output = "";

int divOpenPosition = input.IndexOf(divOpen);
int divClosePosition = input.IndexOf(divClose);
int spanOpenPosition = input.IndexOf(spanOpen);
int spanClosePosition = input.IndexOf(spanClose);


quantity = $"Quantity: {input.Substring(spanOpenPosition + spanOpen.Length, spanClosePosition - (spanOpenPosition + spanClose.Length - 1))}";
output = $"Output: {input.Substring(divOpenPosition + divOpen.Length, divClosePosition - divClose.Length + 1)}";

Console.WriteLine(quantity);
Console.WriteLine(output);

/**
 * Program
 * Replace
 */
// string message = "This--is--ex-amp-le--da-ta";
//
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
//
// Console.WriteLine(message);

/**
 * Program
 * Remove
 */
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
//
// Console.WriteLine(updatedData);

/**
 * Program
 */
// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
//
// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:
//
// char[] openSymbols = { '[', '{', '(' };
//
// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:
//
// int closingPosition = 0;
//
// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//
//     if (openingPosition == -1) break;
//
//     string currentSymbol = message.Substring(openingPosition, 1);
//
//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';
//
//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }
//
//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 
//
//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);
//
//     // Finally, use the techniques you've already learned to display the sub-string:
//
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

/**
 * Program
 */
// string message = "Help (find) the {opening symbols}";
//
// Console.WriteLine($"Searching THIS Message: {message}");
//
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
//
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");
//
// openingPosition = message.IndexOfAny(openSymbols, startPosition);
//
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

/**
 * Program
 */
// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };
//
// int index = message.IndexOfAny(charsToFind);
//
// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

/**
 * Program
 */
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;
//
//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//
//     Console.WriteLine(message.Substring(openingPosition, length));
//
//     // Note the overload of the Substring to return only the remaining unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

/**
 * Program
 */
// string message = "What is the value <span>between the tags</span>?";
//
// const string openSpan = "<span>";
// const string closeSpan = "</span>";
//
// int openingPosition = message.IndexOf(openSpan); // gives the first position of a character or string inside of another string
// int closingPosition = message.IndexOf(closeSpan);
//
// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length)); // returns specified portion of a string, using a starting position and optional length
