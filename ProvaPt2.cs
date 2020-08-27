using System;

namespace provas
{
    class ProvasPt2
    {
        static void Question5()
        {
            var arrayLength = 5;
            var arrayOfNumber = new double?[arrayLength];

            System.Console.WriteLine("Insira os números: ");
            for (int i = 0; i < arrayLength; i++)
            {
                try
                {
                    arrayOfNumber[i] = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    arrayOfNumber[i] = null;
                }
            }
            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayOfNumber[i] != null)
                {
                    System.Console.Write($"{arrayOfNumber[i]}, ");
                }
            }
        }
        
        static void Question6()
        {   
            var totalSalary = 0.0;
            var salary = 0.0;
            var input = "";
            var counter = 0;
            
            System.Console.WriteLine("Digite os salários: (digite 'calcular' para parar a aplicação)");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "calcular")
                {
                    break;
                }
                salary = double.Parse(input);
                counter++;
                if (salary < 0)
                {
                    continue;
                }
                totalSalary += salary;
            }
            var result = totalSalary / counter;
            System.Console.WriteLine($"A média é: {result.ToString("F2")}");
        }

        static void Question7()
        {
            var arrayLength = 5;
            var arrayOfId = new int[arrayLength];
            var counter = 0;

            System.Console.WriteLine("42, SC");
            System.Console.WriteLine("11, RO");
            System.Console.WriteLine("12, AC");
            System.Console.WriteLine("13, AM");
            System.Console.WriteLine("14, RR");
            System.Console.WriteLine("15, PA");
            System.Console.WriteLine("16, AP");
            System.Console.WriteLine("17, TO");
            System.Console.WriteLine("21, MA");
            System.Console.WriteLine("22, PI");
            System.Console.WriteLine("23, CE");
            System.Console.WriteLine("24, RN");
            System.Console.WriteLine("25, PB");
            System.Console.WriteLine("26, PE");
            System.Console.WriteLine("27, AL");
            System.Console.WriteLine("28, SE");
            System.Console.WriteLine("29, BA");
            System.Console.WriteLine("31, MG");
            System.Console.WriteLine("32, ES");
            System.Console.WriteLine("33, RJ");
            System.Console.WriteLine("35, SP");
            System.Console.WriteLine("41, PR");
            System.Console.WriteLine("43, RS");
            System.Console.WriteLine("50, MS");
            System.Console.WriteLine("51, MT");
            System.Console.WriteLine("52, GO");
            System.Console.WriteLine("53, DF");
            
            System.Console.WriteLine("");

            for (int i = 0; i < arrayLength; i++)
            {
                System.Console.WriteLine("Digite seu UF: ");
                Console.ReadLine();
                System.Console.WriteLine("Agora, digite o ID numérico da sua  UF: ");
                arrayOfId[i] = Int32.Parse(Console.ReadLine());
                if (arrayOfId[i] == 42)
                {
                    counter++;
                }
            }
            System.Console.WriteLine($"{(counter * 100) / arrayLength}% das pessoas que digitaram são catarinenses");
        }

        static void Question8()
        {
            var arrayLength = 5;
            var arrayMorning = new string[arrayLength];
            var arrayAfternoon = new string[arrayLength];
            var counter = 0;
            
            for (int i = 0; i < arrayLength; i++)
            {
                System.Console.WriteLine("Digite o aluno matutino: ");
                arrayMorning[i] = Console.ReadLine();
                System.Console.WriteLine("Digite o aluno vespertino: ");
                arrayAfternoon[i] = Console.ReadLine();
            }
            
            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayMorning[i] == arrayAfternoon[i])
                {
                    var arrayFullTime = new string[arrayLength];
                    arrayFullTime[i] = arrayMorning[i];
                    System.Console.Write($"{arrayFullTime[i]}, ");
                    counter++;
                }
            }
            if (counter == 0)
            {
                System.Console.WriteLine("Todos os alunos estudam meio período");
            }
        }
        
        static void Main(string[] args)
        {
            Question8();
        }
    }
}