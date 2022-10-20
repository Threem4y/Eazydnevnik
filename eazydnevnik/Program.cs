using System;

namespace eazydnevnik
{
    class Program
    {
        static void Main()
        {
            DateTime CeychasnayaData = new DateTime(2022, 10, 20);
            DateTime DataZametka1 = new DateTime(2022, 10, 18);
            DateTime DataZametka2 = new DateTime(2022, 10, 19);
            DateTime DataZametka3 = new DateTime(2022, 10, 21);
            DateTime DataZametka4 = new DateTime(2022, 10, 22);
            DateTime DataZametka5 = new DateTime(2022, 10, 23);
            Console.WriteLine(CeychasnayaData);
            int PosiciyaDlyaCtrelochki = 0;
            ConsoleKeyInfo KnopkaChtobDvigalisCtrelki = Console.ReadKey();
            while (KnopkaChtobDvigalisCtrelki.Key != ConsoleKey.Escape)
            {
                if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.DownArrow)
                    Console.SetCursorPosition(0, PosiciyaDlyaCtrelochki++);
                if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.UpArrow)
                    Console.SetCursorPosition(0, PosiciyaDlyaCtrelochki--);
                if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.LeftArrow)
                    CeychasnayaData = CeychasnayaData.AddDays(-1);
                if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.RightArrow)
                    CeychasnayaData = CeychasnayaData.AddDays(+1);
                Console.Clear();
                Console.WriteLine("Дата: " + CeychasnayaData);
                Console.SetCursorPosition(0, PosiciyaDlyaCtrelochki+1);
                Console.WriteLine("->");
                
                if (CeychasnayaData.Year == DataZametka1.Year && (CeychasnayaData.Month == DataZametka1.Month) && (CeychasnayaData.Day == DataZametka1.Day))
                {
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("проснуться");
                    if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Название: Утро");
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Описание заметки: ");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Тебе нужно проснуться, что бы не опоздать на пары");
                        Console.WriteLine("Должно быть выполнено до 07:00, 19,10,2022");
                        Console.SetCursorPosition (0,6);
                        Console.WriteLine(CeychasnayaData);
                    }
                }
                if (CeychasnayaData.Year == DataZametka2.Year && (CeychasnayaData.Month == DataZametka2.Month) && (CeychasnayaData.Day == DataZametka2.Day))
                {
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("Поспать");
                    if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Название: Сон");
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Описание заметки: ");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Тебе нужно лечь спать, что бы не умереть на парах");
                        Console.WriteLine("Должно быть выполнено до 04:00, 20,10,2022");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine(CeychasnayaData);
                    }
                }
                
                if (CeychasnayaData.Year == DataZametka3.Year && (CeychasnayaData.Month == DataZametka3.Month) && (CeychasnayaData.Day == DataZametka3.Day))
                {
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("Практическая работа по c#");
                    if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Название: Практическая по C#");
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Описание заметки: ");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Нужно сделать практическую по c# выполняя всё тз");
                        Console.WriteLine("Должно быть выполнено до 23:59, 20,10,2022");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine(CeychasnayaData);
                    }


                    
                            

                }
                if (CeychasnayaData.Year == DataZametka4.Year && (CeychasnayaData.Month == DataZametka4.Month) && (CeychasnayaData.Day == DataZametka4.Day))
                {
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("Практическая работа по python");
                    if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Название: Первая практическая по Python");
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Описание заметки: ");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Сделать 1-5 задания в первой практической");
                        Console.WriteLine("Должно быть выполнено до 23:59, 23,10,2022");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine(CeychasnayaData);
                    }

                }
                if (CeychasnayaData.Year == DataZametka5.Year && (CeychasnayaData.Month == DataZametka5.Month) && (CeychasnayaData.Day == DataZametka5.Day))
                {
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("Практическая работа по Python");
                    if (KnopkaChtobDvigalisCtrelki.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Название: Вторая практическая по Python");
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Описание заметки: ");
                        Console.WriteLine("----------------");
                        Console.WriteLine("Сделать 1-8 задания во второй практической");
                        Console.WriteLine("Должно быть выполнено до 23:59, 23,10,2022");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine(CeychasnayaData);
                    }





                }
                KnopkaChtobDvigalisCtrelki = Console.ReadKey();

            }            

        }

    }
}
