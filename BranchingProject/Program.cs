/**
 * Program
 * Do-While and While Loops, 3 of 3
 */
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

/**
 * Program
 * Do-While and While Loops, 2 of 3
 */
string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
/**
 * Program
 * Do-While and While Loops, 1 of 3
 */
string? readLineResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readLineResult = Console.ReadLine();
    if (readLineResult != null)
    {
        valueEntered = readLineResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readLineResult = Console.ReadLine();

/**
 * Program
 */
// This week in unnecessary loops...
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//             Console.WriteLine($"You entered: {readResult}");
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);
//
// int numericValue = 0;
// bool isValidNumber = false;
//
// isValidNumber = int.TryParse(readResult, out numericValue);
// Console.WriteLine($"TryParse {(isValidNumber ? "succeeded" : "failed")}. The value is {numericValue}");

/**
 * Program
 * Hero, Do Battle
 *
 * You must use either the do-while statement or the while statement as an outer game loop.
 * The hero and the monster start with 10 health points.
 * All attacks are a value between 1 and 10.
 * The hero attacks first.
 * Print the amount of health the monster lost and their remaining health.
 * If the monster's health is greater than 0, it can attack the hero.
 * Print the amount of health the hero lost and their remaining health.
 * Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
 * Print the winner.
 */
// int heroHealth = 14;
// int monsterHealth = 10;
//
// do
// {
//     int heroAttack = new Random().Next(1, 11);
//     int monsterAttack = new Random().Next(3, 8);
//
//     heroHealth -= monsterAttack;
//     monsterHealth -= heroAttack;
//
//     bool heroIsAlive = heroHealth > 0;
//     bool monsterIsAlive = monsterHealth > 0;
//
//     Console.WriteLine($"Hero attacks monster for {heroAttack} damage. Monster has {(monsterIsAlive ? monsterHealth : "no")} health remaining.");
//     Console.WriteLine($"Monster attacks hero for {monsterAttack} damage. Hero has {(heroIsAlive ? heroHealth : "no")} health remaining.");
//
//     if (!heroIsAlive && !monsterIsAlive)
//     {
//         Console.WriteLine("On this day, both hero and moster fall to the sword.");
//     }
//     else if (!heroIsAlive)
//     {
//         Console.WriteLine("Evil has triumphed this day. Mourn all ye who witness this evil.");
//     }
//     else if (!monsterIsAlive)
//     {
//         Console.WriteLine("The hero has felled another evil beast.");
//     }
// } while (heroHealth > 0 && monsterHealth > 0);
//
/**
 * Program
 * While / Do-While
 */
// Random random = new Random();
// int current = random.Next(1, 11);
//
// do
// {
//     current = random.Next(1, 11);
//
//     if (current >= 8) continue;
//
//     Console.WriteLine($"do while: {current}");
// } while (current != 7);
//
// while (current != 8)
// {
//     Console.WriteLine($"while: {current}");
//
//     current = random.Next(1, 11);
// }
//
// Console.WriteLine($"after while: {current}");

/**
 * Program
 * FizBuzz
 *
 * Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
 * When the current value is divisible by 3, print the term Fizz next to the number.
 * When the current value is divisible by 5, print the term Buzz next to the number.
 * When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
 */

// for (int i = 1; i <= 100; i++)
// {
//     string formatted = i.ToString("D3");
//     bool isDivisibleBy3 = i % 3 == 0;
//     bool isDivisibleBy5 = i % 5 == 0;
//
//     if (isDivisibleBy3 && isDivisibleBy5)
//     {
//         Console.WriteLine($"{formatted} - FizzBuzz");
//     }
//     else if (isDivisibleBy3)
//     {
//         Console.WriteLine($"{formatted} - Fizz");
//     }
//     else if (isDivisibleBy5)
//     {
//         Console.WriteLine($"{formatted} - Buzz");
//     }
//     else
//     {
//         Console.WriteLine(formatted);
//     }
// }


/**
 * Program
 * For Loop Example
 */
// for (int i = 0; i < 10; i++)
// {
//     Console.Write(i + ", ");
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.Write(i + ", ");
// }

// for (int i = 0; i < 10; i += 3)
// {
//     if (i == 6)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
//
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }
//
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

/**
 * Program
 * Switch Statement Example
 */
// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";
//
// string[] product = sku.Split('-');
//
// string type = "";
// string color = "";
// string size = "";
//
// switch (product[0])
// {
//     case "01":
//         type = "Sweat Shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat Pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }
//
// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }
//
// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }
//
// Console.WriteLine($"Product: {size} {color} {type}");
