#region Exploring unary operators
int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b}");
#endregion

#region Exploring unary operators
int c = 3;
int d = ++c;
// Prefix means increment c before assigning it.
Console .WriteLine($"c is {c}, d is {d}");
#endregion

#region operadores aritmeticos logicos
int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f = {g / f}");
#endregion

#region operadores de asignacion
int p1= 6;
p1+= 3; // Equivalent to: p = p + 3;
p1-= 3; // Equivalent to: p = p - 3;
p1*= 3; // Equivalent to: p = p * 3;
p1/= 3; // Equivalent to: p = p / 3;
#endregion

#region Operadores que utilizan null
string? authorName = Console.ReadLine();
// Prompt user to enter an author name.
// The maxLength variable will be the length of authorNameif it is
// not null, or 30 if authorName is null. intmaxLength = authorName?.Length ?? 30;
// The authorName variable will be "unknown" if authorNamewas null.
authorName ??= "unknown";
#endregion

#region operadores logicos
bool p = true;
bool q = false;
Console.WriteLine($"AND | p | q ");
Console.WriteLine($"p | {p & p,-5} | {p & q,-5} ");
Console.WriteLine($"q | {q & p,-5} | {q & q,-5} ");
Console.WriteLine($"OR | p | q ");
Console.WriteLine($"p | {p | p,-5} | {p | q,-5} ");
Console.WriteLine($"q | {q | p,-5} | {q | q,-5} ");
Console.WriteLine();
Console.WriteLine($"XOR | p | q ");
Console.WriteLine($"p | {p ^ p,-5} | {p ^ q,-5} ");
Console.WriteLine($"q | {q ^ p,-5} | {q ^ q,-5} ");
#endregion

#region operadores bitwise y binary shift
Console.WriteLine();
int x = 10;
int y = 6;
Console.WriteLine($"Expression | Decimal | Binary");
Console.WriteLine($"-------------------------------");
Console.WriteLine($"y | {y,7} | {y:B8}");
Console.WriteLine($"x & y | {x & y,7} | {x & y:B8}");
Console.WriteLine($"x | y | {x | y,7} | {x | y:B8}");
Console.WriteLine($"x ^ y | {x ^ y,7} | {x ^ y:B8}");
#endregion