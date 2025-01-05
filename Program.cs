using System;

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
