using CommandLine;

namespace Konsoliohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    if (o.Test == false)
                    {
                    Console.WriteLine("O.Test equals " + o.Test);
                        Console.WriteLine("Incorrect");
                    }
                    else
                    {
                        Console.WriteLine("OK");
                    }

                    if (o.Verbose == true)
                    {
                    Console.WriteLine("O.Verbose equals " + o.Verbose);
                        Console.WriteLine("Correct");
                    }

                });
        }
    }

    class Options
    {
        [Option('t', "test")]
        public bool Test { get; set; }

        [Option('v', "verbose")]
        public bool Verbose { get; set; }

        [Option('u', "url")]
        public string? Url { get; set; }
    }
}