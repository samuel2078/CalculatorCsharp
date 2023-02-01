namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {
            Console.WriteLine("Qual operação deseja executar?");
            Console.WriteLine("1--- Soma");
            Console.WriteLine("2--- Subtração");
            Console.WriteLine("3--- Divisão");
            Console.WriteLine("4--- Mulltiplicação");
            Console.WriteLine("5--- Sair da Aplicação");

            Console.WriteLine("---------------");

            Console.WriteLine("Selecione uma opção : ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: divisao(); break;
                case 4: multplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


        }
        static void soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é : " + resultado);
            Console.ReadKey();
              Menu();
        }


        static void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtração é : " + resultado);
            Console.ReadKey(); 
             Menu();

        }

        static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Digite primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("O restultado da divisão é :" + resultado);
            Console.ReadKey();
              Menu();

        }

        static void multplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Digite primeiro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("O restultado da divisão é :" + resultado);
            Console.ReadKey();
              Menu();
        }
    }


}

