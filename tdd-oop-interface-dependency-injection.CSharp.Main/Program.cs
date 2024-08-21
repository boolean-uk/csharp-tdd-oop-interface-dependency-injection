
using tdd_oop_interface_dependency_injection.CSharp.Main;

Scrabble<EnglishAlphabet> englishScrabble = new Scrabble<EnglishAlphabet>();
Scrabble<GreekAlphabet> greekScrabble = new Scrabble<GreekAlphabet>();
Scrabble<RussianAlphabet> russianScrabble = new Scrabble<RussianAlphabet>();

string[] testWords = { "HELLO", "ΚΑΛΗΜΕΡΑ", "Привет" };

Console.WriteLine("English Scrabble Scores:");
foreach (var word in testWords)
{
    int score = englishScrabble.score(word.ToUpper()); 
    Console.WriteLine($"{word} : {score}");
}

Console.WriteLine("\nGreek Scrabble Scores:");
foreach (var word in testWords)
{
    int score = greekScrabble.score(word.ToUpper()); 
    Console.WriteLine($"{word} : {score}");
}

Console.WriteLine("\nRussian Scrabble Scores:");
foreach (var word in testWords)
{
    int score = russianScrabble.score(word.ToUpper()); 
    Console.WriteLine($"{word} : {score}");
}
    
