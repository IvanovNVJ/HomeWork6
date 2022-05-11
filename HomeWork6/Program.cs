using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork6
{
    internal class Program
    {
        static void WriteFile()
        {
            using (StreamWriter SWFile = new StreamWriter("directory.txt", true, Encoding.Unicode))
            {
                char end_flag = 'д';
                do
                {
                    string note = string.Empty;
                    Console.WriteLine("Введите ID: ");
                    note += $"{Console.ReadLine()}#";

                    string NoteDateTime = DateTime.Now.ToString();
                    Console.WriteLine($"Дата и время записи: {NoteDateTime}");
                    note += $"{NoteDateTime}#";

                    Console.WriteLine("Введите Ф.И.О: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите возраст: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите рост: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите дату рождения: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите место рождения: ");
                    note += $"{Console.ReadLine()}#";

                    SWFile.WriteLine(note);

                    Console.WriteLine("Продолжить н/д");
                    end_flag = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(end_flag) == 'д');
            }
            
        }

        static void ReadFile()
        { 
            using (StreamReader SRFile = new StreamReader("directory.txt", Encoding.Unicode))
            {
                string check_string;
                while((check_string = SRFile.ReadLine()) != null)
                {
                    string[] resulting_string = check_string.Split('#');
                    for (int i = 0; i < resulting_string.Length; i++) Console.WriteLine(resulting_string[i]);
                }
            }
        
        }

        static void Main()
        {
            
            
            while (true)
            {
                Console.WriteLine("Для добавления записи нажмите 1, для загрузки записей из справочника нажмине 2," +
                    "для выхода из программы нажмите Enter");
                var flag = Console.ReadKey().Key;
                if (flag != ConsoleKey.Enter)
                {
                    switch (flag)
                    {
                        case ConsoleKey.D1: Console.Clear(); WriteFile(); break;
                        case ConsoleKey.D2: Console.Clear(); ReadFile(); break;
                        default: Console.Clear(); Console.WriteLine("Введен неверный знак"); break;
                    }
                }
                else break;
            }
                
        }
           
    }
}
