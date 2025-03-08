namespace _Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double v1, v2, resultado;
                string op;


                while (true)
                {

                    op = Console.ReadLine();
                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                    }
                }


                while (true)
                {
                    string valor = Console.ReadLine();



                    if (double.TryParse(valor, out v1))
                    {
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Opção inválida");
                    }
                }

                while (true)
                {
                    string valor = Console.ReadLine();



                    if (double.TryParse(valor, out v2))
                    {
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Opção inválida");
                    }
                }

                switch (op)
                {
                    case "+":

                        {
                            resultado = v1 + v2;
                            Console.WriteLine($"{op}: {v1} + {v2} = {resultado}");
                            break;
                        }


                    case "-":
                        {
                            resultado = v1 - v2;
                            Console.WriteLine($"{op}: {v1} - {v2} = {resultado}");
                            break;
                        }

                    case "*":
                        {
                            resultado = v1 * v2;
                            Console.WriteLine($"{op}: {v1} * {v2} = {resultado}");
                            break;
                        }

                    case "/":
                        {
                            if (v1 == 0 || v2 == 0)
                            {
                                Console.WriteLine("Não é possível dividir por 0");
                                break;
                            }

                            resultado = v1 / v2;
                            Console.WriteLine($"{op}: {v1} / {v2} = {resultado}");
                            break;
                        }

                }
            }

        }
    }
}