using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDelegatesLesson
{
    public delegate void ActivateTheButtonDelegate<T>(params T[] data);
    public class RedButton
    {
        public char SymbolicBorderOfTheButton { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Text { get; set; }       
        public ActivateTheButtonDelegate<string> Action { get; set; }
       
        public void PrintRedButton()
        {
            for(int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    if(j == 0 | i == 0 | j == Width - 1 | i == Height - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkGray; 
                        Console.Write(SymbolicBorderOfTheButton);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(4,6);
            Console.Write(Text);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            
        }        
    }
}
