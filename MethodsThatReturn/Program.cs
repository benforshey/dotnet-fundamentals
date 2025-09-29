/**
 * Program
 * Code Challenge
 */
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string? response = Console.ReadLine();

    if (response == null)
    {
        return false;
    }

    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}

/**
 * Program
 * Check For Change
 */
// int target = 30;
// int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// int[,] result = TwoCoins(coins, target);
//
// if (result.Length == 0)
// {
//     Console.WriteLine("No two coins make change");
// }
// else
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (result[i, 0] == -1)
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//     }
// }
//
// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//     int count = 0;
//
//     for (int curr = 0; curr < coins.Length; curr++)
//     {
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if (coins[curr] + coins[next] == target)
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0))
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0, 0] : result;
// }

/**
 * Program
 * Check Palindrome
 */
// bool IsPalindrome(string word)
// {
//     int start = 0;
//     int end = word.Length - 1;
//
//     while (start < end)
//     {
//         if (word[start] != word[end])
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }
//
//     return true;
// }
//
// bool[] list = { IsPalindrome("racecar"), IsPalindrome("tenet"), IsPalindrome("deified"), IsPalindrome("super") };
//
// foreach (bool item in list)
// {
//     Console.WriteLine(item);
//
// }

/**
 * Program
 * Reverse Strings
 */
// string input = "there are snakes at the zoo";
//
// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));
//
// string ReverseSentence(string input)
// {
//     string result = "";
//     string[] words = input.Split(" ");
//
//     //NOTE: Replace this with a `i--` for loop to reverse order of words in sentence.
//     foreach (string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }
//
//     return result.Trim();
// }
//
// string ReverseWord(string word)
// {
//     string result = "";
//
//     for (int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }
//
//     return result;
// }
