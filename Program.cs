using System;

class Program
{
    static void Main(string[] args) {
        string stopWord = "exit";
        string inputWord = " ";

        Console.WriteLine("Вы попали в день сурка, чтоб он закончился ведите стоп слово");

        while (inputWord != stopWord)
        {
            Console.Write("Введите стоп слово: ");
            inputWord = (Console.ReadLine());
            Console.WriteLine("День сурка продолжается.");
        }

        Console.WriteLine("Ура, день сурка окончен!");
    }
}

