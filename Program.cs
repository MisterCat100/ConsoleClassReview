using Newtonsoft.Json;
using System.Text.Json.Serialization;

public class Program
{
    static void Main()
    {
        //// Project 1
        //for (int i = 37; i <= 32767; i += 10)
        //{
        //    Console.Beep(i, 10);
        //    Console.WriteLine($"Hz = {i}");
        //}
        //Console.Clear();


        //for (int i = 0; i < 100; i++)
        //{
        //    Console.WriteLine($"hI{i}");
        //    Console.WriteLine(Console.GetCursorPosition());
        //    Task.Delay(500).Wait();
        //}


        //// Project 2
        //Console.WriteLine("""
        //    Name: Gleb
        //    Surname: Savin
        //    """);
        //Task.Delay(2000).Wait();
        //// TO --> FROM
        //Console.MoveBufferArea(0, 0, 20, 5, 25, 0);
        //Task.Delay(500).Wait();

        //Console.WriteLine("""
        //    Name: Gleb
        //    Surname: Savin
        //    """);
        //Task.Delay(2000).Wait();
        //// TO --> FROM
        //Console.MoveBufferArea(0, 0, 20, 5, 25, 0, 'F',
        //                        ConsoleColor.Black,
        //                        ConsoleColor.Yellow);
        //Task.Delay(2000).Wait();
        //Console.WriteLine("\n\n\n");


        //while (true)
        //{
        //    // Task.Delay(800).Wait();
        //    Console.WriteLine(Console.GetCursorPosition());
        //}


        //Stream errorStream = Console.OpenStandardError();

        //for (int i = 0; i < 125; i++)
        //{
        //    byte data = (byte)i;
        //    ReadOnlySpan<byte> buffer = new(ref data);
        //    errorStream.Write(buffer);
        //    Task.Delay(800).Wait();
        //}

        //// Project 3
        //int symbolInNum = Console.Read();
        //Console.WriteLine(symbolInNum);
        //Console.WriteLine(((char)symbolInNum));
        //ConsoleKeyInfo symbol = Console.ReadKey(true);
        //Console.WriteLine(JsonConvert.SerializeObject(symbol, Formatting.Indented));

        //Console.WriteLine("hi");
        //Task.Delay(4000).Wait();
        //Console.SetBufferSize(50, 5);
        //Console.WriteLine("12345678910123123123123123123123123123123");
    }
}