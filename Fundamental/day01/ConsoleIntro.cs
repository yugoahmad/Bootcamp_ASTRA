namespace day01
{
    class ConsoleIntro
    {
        public static void MultiConsole()
        {
            //concat
            Console.WriteLine("Hello, World!" + " " + "Yugo Ganteng banget!!!");
            Console.Write("dotnet ");

            Console.WriteLine("Code id Bootcamp .NET");

            Console.WriteLine("Code Academy \n.NET");

            //formating number
            Console.WriteLine("Tanggal {0} suhu {1} jarak {2}", DateTime.Today, 12.0, 78);

            //verbatim
            Console.WriteLine(@"I Love
Programming in
Code id");
        }
    }
}