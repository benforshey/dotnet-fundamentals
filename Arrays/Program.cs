/**
 * PROGRAM
 * Sort / tag an array.
 */
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] splitOrderStream = orderStream.Split(',');

foreach (string order in splitOrderStream)
{
    int length = order.Length;

    if (length == 4)
    {
        Console.WriteLine(order);
    }
    else
    {
        Console.WriteLine($"{order}\t-Error");
    }
}
/**
 * PROGRAM
 * Reverse words in a sentence.
 */
// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] split = pangram.Split(' ');
// string[] reversed = new string[split.Length];
//
// // foreach (string part in split)
// for (int i = 0; i < split.Length; i++)
// {
//     char[] chars = split[i].ToCharArray();
//     Array.Reverse(chars);
//
//     reversed[i] = new string(chars);
// }
//
// string output = String.Join(" ", reversed);
//
// Console.WriteLine(pangram);
// Console.WriteLine(output);
/**
 * PROGRAM
 * Split() and Join()
 * string's Array Methods
 */
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
//
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

/**
 * PROGRAM
 * Sort and reverse the order of array elements.
 * Clear and resize the elements of an array.
 * Split a string into an array of strings or characters (chars).
 * Join array elements into a string.
 */
// RESIZE AN ARRAY TO REMOVE ELEMENTS
// string[] pallets = ["B14", "A11", "B12", "A13"];
//
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
//
// pallets[4] = "C01";
// pallets[5] = "C02";
//
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
//
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// RESIZE AN ARRAY TO ADD ELEMENTS
// string[] pallets = ["B14", "A11", "B12", "A13"];
//
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
//
// pallets[4] = "C01";
// pallets[5] = "C02";
//
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// CLEARING ARRAYS
// string[] pallets = ["B14", "A11", "B12", "A13"];
//
// Console.WriteLine($"Before: {pallets[0]}");
// // Clear sets the value to null, so methods like ToLower() will throw an exception.
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");
//
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// SORTING AND REVERSING ARRAYS
// string[] pallets = ["B14", "A11", "B12", "A13"];
//
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
