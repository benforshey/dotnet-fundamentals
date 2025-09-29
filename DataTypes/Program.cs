/**
 * PROGRAM
 * A value type variable stores its values directly in an area of storage called the stack.
 * A reference type variable stores its values in a separate memory region called the heap.
 */
// The Basics
// int for most whole numbers
// decimal for numbers representing money
// bool for true or false values
// string for alphanumeric value

// Reference Type (array): In this example, ref_A and ref_B are array reference types.
// When ref_B = ref_A is executed, ref_B points to the same memory location as ref_A. So, when ref_B[0] is changed, ref_A[0] also changes because they both point to the same memory location. This is a key difference between value types and reference types.
int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");


// Value Type (int): In this example, val_A and val_B are integer value types.
// When val_B = val_A is executed, the value of val_A is copied and stored in val_B. So, when val_B is changed, val_A remains unaffected.
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

// int[] data = new int[5]; // reference type variable
// string shortenedString = "Hello, World!"; // reference type variable
/**
 * PROGRAM: Data Types
 */
// Console.WriteLine("Signed integral types:");
// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}"); // -128 to 127
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}"); // -32768 to 32767
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}"); // -2147483648 to 2147483647
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}"); // -9223372036854775808 to 9223372036854775807
//
// Console.WriteLine("Unsigned integral types:");
// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}"); // 0 to 255
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}"); // 0 to 65535
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}"); // 0 to 4294967295
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}"); // 0 to 18446744073709551615
//
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
