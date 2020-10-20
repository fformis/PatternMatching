using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            object teste = "5";

            if (teste is int number){
                Console.WriteLine($"{number} é um número");
            }else{
                Console.WriteLine($"{teste} não é um número");
            }

            object caso = "b teste";

            switch(caso){
                case null: Console.WriteLine("é null"); break;
                case int i: Console.WriteLine("é int"); break;
                case string a when a.StartsWith("b"): Console.WriteLine("é string que começa com b"); break;
                case string s: Console.WriteLine("é string"); break;
            }

        }
    }
}
