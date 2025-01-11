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

// Operador condicional ************************************************************************

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

/*
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
*/

// Ramificar o fluxo de código usando o constructo de mudança de casos em C# ************************************

// Exemplo de switch case -------------------------------------------------------------------

/*
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
*/

// Desafio de switch case -------------------------------------------------------------------

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

// SKU = Stock Keeping Unit

/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

// Iterar por um bloco de código usando a instrução for em C# *************************************************


/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if ( i == 7) break;
}
*/

// Exemplo MUITO IMPORTANTE DE FOR --------------********************

/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/

/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
*/

// Mesmo código, porem, com chaves 

/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
*/

// Desafio for e if  - FizzBuzz -------------------------------------------------------------------------

/*
for (int count = 1; count <= 100; count++) 
{
    if (count % 3 == 0) 
    {
        Console.WriteLine($"{count} Fizz");
    }
    else if (count % 5 == 0) 
    {
        Console.WriteLine($"{count} Buzz");
    }
    else if (count % 3 == 0 && count % 5 == 0) 
    {
        Console.WriteLine($"{count} FizzBuzz");
    }
    else {
        Console.WriteLine(count);
    }
}
*/

// Outro modelo de resolver 

/*
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
*/

// Adicione lógica de loop ao seu código usando as instruções do-while e while em C#-------------

// Exemplo de do-while

/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// Exemplo de while

/*
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// Usar a instrução continue para passar diretamente para a expressão booliana -------------

/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
if (current >= 8) continue;
Como nosso código que escreve o valor de current no console está localizado após o 
if (current >= 8) continue;, o código garante que um valor de current que seja 
maior ou igual a 8 jamais será escrito na janela de saída.
*/

// Desafio de código – Escrever um código para implementar as regras de jogo ------------------

/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do 
{
    int roll = dice.Next(1,11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health");

}  while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/

// Gerencie a entrada do usuário durante esse desafio -------------------------------------------

/*
Ao usar uma instrução Console.ReadLine() para obter a entrada do usuário, é prática comum 
utilizar uma cadeia de caracteres do tipo anulável (designada string?) para a variável 
de entrada e, em seguida, avaliar o valor inserido pelo usuário. O código de exemplo 
a seguir utiliza uma cadeia de caracteres do tipo anulável para capturar a entrada 
do usuário. A iteração continuará enquanto o valor fornecido pelo usuário for nulo:
*/

/*
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
*/

// Exemplo de pedir pelo menos três caracteres --------------------------------------------------

/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/

/*
O método int.TryParse() pode ser utilizado para converter um valor de cadeia de caracteres
 em um número inteiro. O método utiliza dois parâmetros, uma cadeia de caracteres que será 
 avaliada e o nome de uma variável inteira à qual será atribuído um valor. O método retorna 
 um valor Booliano. O código de exemplo a seguir demonstra o uso do método int.TryParse():
 */

// capture user input in a string variable named readResult

/*
string? readResult = "7";
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
Console.WriteLine($"The number is {numericValue} and it is valid: {validNumber}");
*/

// Projeto de código 1 – escrever o código que valida a entrada de inteiro ------------------------

// Exemplo que tentei fazer, melhor solução abaixo
/*
string? readResult;
bool valorEntrada = false;
int valorInteiro = 0;

Console.WriteLine("Entre com um número de 5 e 10");

do 
{
    readResult = Console.ReadLine();

    // Tenta converter a entrada para inteiro
    valorEntrada = int.TryParse(readResult, out valorInteiro);

    if (!valorEntrada)
    {
        Console.WriteLine("Desculpe, você digitou um número inválido. Por favor, tente novamente.");
    }  
    else if (valorInteiro >= 5 && valorInteiro <= 10)
    {
        Console.WriteLine($"Seu valor de entrada ({valorInteiro}) foi aceito.");
        break; // Sai do loop após entrada válida
    }
    else
    {
        Console.WriteLine($"Sua entrada foi {valorInteiro}. Por favor, entre com um número entre 5 e 10.");
    }

} while (true);
*/

// Melhor resolução *********************------------------------

/*
string? readResult;
bool isValid = false;
int parsedNumber = 0;

Console.WriteLine("Enter an integer value between 5 and 10.");

while (!isValid)
{
    readResult = Console.ReadLine();
    
    // Verificar se readResult é nulo
    if (readResult == null)
    {
        Console.WriteLine("Entrada inválida: nenhuma entrada fornecida.");
        continue; // Volta ao início do loop
    }

    // Tentar converter para número
    if (int.TryParse(readResult, out parsedNumber))
    {
        // Validar intervalo
        if (parsedNumber >= 5 && parsedNumber <= 10)
        {
            Console.WriteLine($"Your input value ({parsedNumber}) has been accepted.");
            isValid = true; // Encerrar o loop
        }
        else
        {
            Console.WriteLine($"You entered {parsedNumber}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
    }
}
*/

// Projeto de código 2 – escrever o código que valida a entrada de cadeia de caracteres ----------

/*  
Console.WriteLine("Entre com sua função: Administrador, Gerente ou Usuário");

string? funcao;
bool isValid = false;

do
{
    // Lê a entrada do usuário
    funcao = Console.ReadLine();

    if (funcao == null)
    {
        Console.WriteLine("Entrada inválida. Por favor, insira novamente.");
        continue; // Reinicia o loop
    }

    // Aplica Trim() e ToLower() para padronizar a entrada
    funcao = funcao.Trim().ToLower();

    // Verifica se o valor está entre as opções válidas
    if (funcao == "administrador" || funcao == "gerente" || funcao == "usuário")
    {
        Console.WriteLine($"Seu valor de entrada ('{funcao}') foi aceito.");
        isValid = true; // Sai do loop
    }
    else
    {
        Console.WriteLine($"O nome da função que você inseriu ('{funcao}') não é válido. Insira o nome da sua função (Administrador, Gerente ou Usuário).");
    }

} while (!isValid); // Continua o loop enquanto a entrada não for válida
*/

// Projeto de código 3: escreva um código que processe o conteúdo de uma matriz de caracteres-----

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