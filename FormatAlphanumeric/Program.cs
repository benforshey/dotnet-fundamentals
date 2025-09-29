/**
 * program
 *
 */
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string comparisonTable = $"{currentProduct}\t\t{currentReturn.ToString("P2").PadRight(12)}{currentProfit:C2}\n";
comparisonTable += $"{newProduct}\t\t{newReturn.ToString("P2").PadRight(12)}{newProfit:C2}";

string messageBody = @$"Dear {customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.

Our new product, {newProduct}, offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.

Here's a quick comparison:

{comparisonTable}
";

Console.WriteLine(messageBody);
//
// Console.WriteLine($"Dear {customerName}");
//
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// Your logic here

// Console.WriteLine(comparisonMessage);

/**
 * program
 *
 */
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";
//
// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
//
// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

/**
 * program
 * 
 */
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;
//
// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"\tShares: {productShares:N3} Product");
// Console.WriteLine($"\t\tSub Total: {subtotal:C}");
// Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
// Console.WriteLine($"\t\tTotal Billed: {total:C}");

/**
 * PROGRAM
 * 
 */
//// Combined Formatting Approaches
// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
//
// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
//
// Console.WriteLine(yourDiscount);
// Console.WriteLine($"You saved {(price - salePrice):C2} off the regular price of {price:C2}, with a discount of {((price - salePrice) / price):P2}!");

// // Formatting Percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// // Formatting Numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// // Formatting Currency
// // note: for me, this outputs the universal currrency symbol (¤); dotnet allows you to set "culture" info to localize the currency symbol.
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// // String Interpolation
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// // Composite Formatting
// string first = "Hello";
// string second = "World";
// Console.WriteLine("{0} {1}!", first, second);
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);
