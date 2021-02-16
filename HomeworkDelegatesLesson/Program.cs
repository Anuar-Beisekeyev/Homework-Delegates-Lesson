using System;

namespace HomeworkDelegatesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ракета прошла все подготовительные работы.");
            Console.WriteLine("Все параметры в норме");
            Console.WriteLine("Нажмите кнопку <Пуск>");
            Console.WriteLine();

            RedButton redButton = new RedButton
            {
                SymbolicBorderOfTheButton = '*',
                Text = "Пуск",
                Width = 12,
                Height = 6,
                Action = new ActivateTheButtonDelegate<string>(Console.WriteLine)
            };

            redButton.PrintRedButton();
            Console.WriteLine("Пуск успешно произведен !!!");
            Console.ReadLine();
            
        }
       
    }
}
