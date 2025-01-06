using System;
using System.Reflection.Metadata;

// Evaluate Boolean Expressions to Make Decisions in C# -----------------------------------------------------

/*
System.Console.WriteLine("a" == "a"); // True
System.Console.WriteLine("a" == "A"); // False
System.Console.WriteLine(1 == 2); // False

string myValue = "a";
System.Console.WriteLine(myValue == "a"); // True
*/

// Você pode aprimorar a verificação de igualdade anterior encadeando esses dois métodos auxiliares 
// em ambos os valores, como mostrado na listagem de código a seguir ---------------------------------------

/*
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

// Operador de desigualdade (!=) em C# -------------------------------------------------------------------

/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

// Operadores de comparação em C# -------------------------------------------------------------------------

/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

// Método que retorna um valor booleano -------------------------------------------------------------------

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
*/

// Negação de um valor booleano ----------------------------------------------------------------------------

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/

// Operador de desigualdade vs negação de lógica em C# -------------------------------------------------------------------

/*
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True

string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
*/

// Operador condicional ----------------------------------------------------------------------

/*
int saleAmount = 1001;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}") -> Embutido
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
*/

// Desafio de condicinal --------------------------------------------------------------------

/*
Random coin = new Random();
int flip = coin.Next(0, 2); // ou direto: Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
Console.WriteLine((flip == 0) ? "heads" : "tails");
*/

// Desafio de lógica de decisão --------------------------------------------------------------

/*
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/

// Controlar o escopo da variável e a lógica usando blocos de código em C# ***************************************

/*
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/

// Exemple de if sem {}
/*
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/

// Desafio de escopo de variável -------------------------------------------------------------

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
    
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");