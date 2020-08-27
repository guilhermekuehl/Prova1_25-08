using System;

namespace provas
{
    class ProvaPt1
    {
        

        static void Question1()
        {
            System.Console.WriteLine("Você trabalha quanto tempo por dia?");
            var time = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Quanto você ganha por hora?");
            var money = double.Parse(Console.ReadLine());
            var result = money * time;
            System.Console.WriteLine($"Em um dia trabalhado você ganha {result.ToString("0.00")}");
        }
        
        static void Question2()
        {
            var characters = "";
            var input = "";
            
            while (true)
            {
                System.Console.WriteLine("Digite um caracter: ");    
                input = Console.ReadLine();
                if (input == "finalizar")
                {
                    break;
                }
                characters += input;
            }
            System.Console.WriteLine($"A palavra que você digitou é: {characters}");
        }

        static void Question3()
        {
            var arrayLength = 5;
            var name = new string[arrayLength];
            var single = new string[arrayLength];
            var input = "";

            for (int i = 0; i < arrayLength; i++)
            {
                System.Console.WriteLine("Informe seu nome: ");
                name[i] = Console.ReadLine();
                System.Console.WriteLine("Você é solteiro? ");
                input = Console.ReadLine();     
                if (input == "sim")
                {
                    single[i] = name[i];
                }
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Solteiros: ");

            for (int i = 0; i < arrayLength; i++)
            {
                if (single[i] != null)
                {
                    System.Console.Write($"{single[i]}, ");    
                }           
            }
        }

        static void Question4()
        {
            var year = 0;
            System.Console.WriteLine("Informe o ano do seu nascimento:");
            while (true)
            {
                try
                {
                    year = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Valor inválido, digite novamente: ");
                }    
            }
            if (year >= 2003)
            {
                System.Console.WriteLine("Você é menor de idade");
            }
            else
            {
                System.Console.WriteLine("Você é maior de idade");
            }
            
        }

        static void off(string[] args)
        {
            Question2();    
        }
    }
}
