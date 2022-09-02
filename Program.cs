using System;


namespace String_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
           
            var pi = Math.PI;

            Console.WriteLine(date);

            Console.WriteLine($"{date,40:MMMM d, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"Year:{date:yyyy}, Month:{date:MM}, Day:{date:dd}");
            Console.WriteLine($"{date,10:dddd}");
            Console.WriteLine($"{date,10:t}{date,10:dddd}");
            Console.WriteLine($"h:{date:hh}, m:{date:mm}, s:{date:ss}");
            Console.WriteLine($"{date:yyyy}.{date:MM}.{date:dd}.{date:hh}.{date:mm}.{date:ss}");

            Console.WriteLine($"{pi:C}");
            Console.WriteLine($"{pi,10:n3}");

        }
    }
}

        