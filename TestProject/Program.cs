/*
 * Program
 */
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int sum = numbers.Sum((n) =>
{
    if (n == 42)
    {
        Console.WriteLine("Set contains 42");
    }

    return n;
});

Console.WriteLine($"Total: {sum}");

/*
 * Program
 */
// bool flag = true;
//
// if (flag)
// {
//     Console.WriteLine(flag);
// }
//
// // For single-line executions (like JS), we can do:
// if (flag)
//     Console.WriteLine(flag);
//
// // or:
// if (flag) Console.WriteLine(flag);
//
// // But is this readable?
// string name = "stEve";
//
// if (name.ToLower() == "bob") Console.WriteLine("Found Bob");
// else if (name.ToLower() == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");
//
// // vs the readability of:
// if (name.ToLower() == "bob")
//     Console.WriteLine("Found Bob");
// else if (name.ToLower() == "steve")
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");
//
// Code sample 1; Use of unassigned local variable 'value'
// bool flag = true;
// int value;
//
// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }
//
// Console.WriteLine($"Outside the code block: {value}");

// Code sample 2
// int value;
// bool flag = false;
//
// if (flag || true)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }
//
// Console.WriteLine($"Outside the code block: {value}");

/*
 * Program
 */
// string permission = "Admin|Manager";
// int level = 53;
//
// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;
//
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// // These two lines of code will create the same output
// string pangram = "The quick brown fox jumps over the lazy dog.";
//
// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));
//
// Console.WriteLine(1 == 2);
// Console.WriteLine(1 != 2);
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

/*
 * Program
 */
// Random dice = new Random();
//
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
//
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//
//         total += 2;
//     }
// }

/*
 * Program
 */
/*
   This code reverses a message, counts the number of times a particular character appears, then prints the results to the console window.
 */
// string originalMessage = "The quick brown fox jumps over the lazy dog.";
//
// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);
//
// int letterCount = 0;
//
// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }
//
// string newMessage = new String(message);
//
// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

/*
 * Program
 */
// string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
//
// foreach (string orderID in fraudulentOrderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         Console.WriteLine($"Fraudulent order: {orderID}");
//     }
// }

/*
 * Program
 */
// string[] names = { "Rowena", "Robin", "Bao" };
// // string[] names = ["Rowena", "Robin", "Bao"];
//
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
//
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
//
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

/*
 * Program
 */
// string[] fraudulentOrderIDs = new string[3]; // or new String[3];
//
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = ["A123", "B456", "C789"]; // or the older array syntax { "A123", "B456", "C789" }
//
// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
//
// fraudulentOrderIDs[0] = "F000";
//
// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

/*
 * Program
 */
// const int winningScore = 15;
//
// Random dice = new(); // equivalent to Random dice = new Random(); because we provide the target type of `Random`.
//
// int[] rolls = { dice.Next(1, 7), dice.Next(1, 7), dice.Next(1, 7) };
// int distinctCount = rolls.Distinct().Count();
// int sumOfRolls = rolls.Aggregate(0, (acc, n) => acc + n);
// int bonus = 0;
//
// if (distinctCount == 1)
// {
//     // we rolled triples
//     bonus += 6;
// }
// else if (distinctCount == 2)
// {
//     // we rolled doubles
//     bonus += 2;
// }
//
// bool hasWon = sumOfRolls + bonus >= winningScore;
//
// Console.WriteLine($"First roll: {rolls[0]}");
// Console.WriteLine($"Second roll: {rolls[1]}");
// Console.WriteLine($"Third roll: {rolls[2]}");
// Console.WriteLine($"Sum of rolls: {sumOfRolls}");
// Console.WriteLine($"Bonus: {bonus}");
// Console.WriteLine($"You {(hasWon ? "win" : "lose")}");

/*
 * Program
 */
// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);
//
// Console.WriteLine(largerValue);
