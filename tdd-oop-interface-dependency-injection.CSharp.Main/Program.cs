using System.Text;
using tdd_oop_interface_dependency_injection.CSharp.Main;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main.Alphabets;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main.Interfaces;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;



Console.WriteLine("Hello, gamer! Please, choose your language:  ");
var language = Console.ReadLine();

IAlphabet alphabet = null;

switch (language)
{
    case "russian":
        alphabet = new Russian(); break;
    case "greek":
        alphabet = new Greek(); break;
    default:
        alphabet = new English(); break;
}

var scrabble = new Scrabble(alphabet);
Console.WriteLine("Go ahead! Enter your word right here:  ");
var input = ReadLineUTF();

int result = scrabble.score(input);

Console.WriteLine("Your score is: {0} points", result);


static string ReadLineUTF()
{
    ConsoleKeyInfo currentKey;

    var sBuilder = new StringBuilder();
    do
    {
        currentKey = Console.ReadKey();
        // avoid capturing newline
        if (currentKey.Key != ConsoleKey.Enter)
            sBuilder.Append(currentKey.KeyChar);

    }
    // check if Enter was pressed
    while (currentKey.Key != ConsoleKey.Enter);

    // move on the next line
    Console.WriteLine();

    return sBuilder.ToString();
}