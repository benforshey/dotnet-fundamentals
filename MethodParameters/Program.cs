/**
 * Program
 * Code Challenge
 */
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "example.com";

PrintEmailAddresses(userPairs: corporate);
PrintEmailAddresses(userPairs: external, domain: externalDomain);

void PrintEmailAddresses(string[,] userPairs, string domain = "corporate.com")
{
    for (int i = 0; i < userPairs.GetLength(0); i++)
    {

        string user = "";

        for (int j = 0; j < userPairs.GetLength(1); j++)
        {
            user += userPairs[i, j];
        }

        Console.WriteLine($"{user}@{domain}");
    }
}


/**
 * Program
 * RSVP Application
 */
// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;
//
// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }
//
//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }
//
// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }
//
// RSVP(name: "Rebecca", partySize: 1, allergies: "none", inviteOnly: true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();


/**
 * Program
 * Pass by Value, Pass by Refnerence
 */
// string status = "Healthy";
//
// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");
// SetHealthMutative(false);
// Console.WriteLine($"Mutative: {status}");
//
// void SetHealth(string status, bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }
//
// void SetHealthMutative(bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// int[] array = { 1, 2, 3, 4, 5 };
//
// PrintArray(array);
// Clear(array);
// PrintArray(array);
//
// void PrintArray(int[] array)
// {
//     foreach (int a in array)
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }
//
// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }

// int a = 3;
// int b = 4;
// int c = 0;
//
// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");
//
// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

/**
 * Program
 * Variable Scope
 */
// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);
//
// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }
//
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }
//
// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

/**
 * Program
 * Variable Scope
 */
// string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };
//
// DisplayStudents(students);
// DisplayStudents(new string[] { "Robert", "Vanya" });
//
// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

/**
 * Program
 */
// CountTo(5);
//
// void CountTo(int max)
// {
//     for (int i = 0; i < max; i++)
//     {
//         Console.Write($"{i}, ");
//     }
// }
