using System;
namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Button myButton;
            myButton = new Button();
            System.Console.WriteLine(myButton.Name);
        }
    }
    class Button
    {
        public string Name { get; set; } = "Butao";
    }
}

