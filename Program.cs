using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Atividade1();
            Atividade2();
            Atividade3();
            Atividade4();
            Atividade5();
            Atividade6();

            Console.ReadKey();
        }  

        static void Atividade1()
        {
            int[] Vetor4;

            Vetor4 = new int[4];

            Console.WriteLine("Insira um número de cada vez: ");
            Vetor4[0] = Convert.ToInt32(Console.ReadLine() + 7);
            Vetor4[1] = Convert.ToInt32(Console.ReadLine() + 7);
            Vetor4[2] = Convert.ToInt32(Console.ReadLine() + 7);
            Vetor4[3] = Convert.ToInt32(Console.ReadLine() + 7);

            Console.WriteLine("o número criptografado é: " + Vetor4[2] + Vetor4[3] + Vetor4[0] + Vetor4[1]);
        }

     

        static void Atividade2()
        {

            string conta;
            double saldo;
            double debito;
            double credito;
            double limite;
            int op = 0;


            Console.WriteLine("Insira o número da conta: ");
            conta = Console.ReadLine();
            Console.WriteLine("Insira o saldo inicial do mês: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor total da fatura deste mês: ");
            debito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do limite disponivel no inicio do mês: ");
            credito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o limite de crédito da conta: ");
            limite = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite 1 para calcular o limite disponivel ou 2 para inserir os valores novamente!");

            switch (op)
            {
                case 1:
                    op = Convert.ToInt32(saldo + debito - credito);

                    Console.WriteLine("o Limite atualizado é: " + op);

                    if (limite < op)

                        Console.WriteLine("Limite de Crédito Excedido!");

                    break;

                //case 2: não lembro como trata isto


            }

        }

        static void Atividade3()
        {
            
                int numero = 0;
                int i = 1;

                while (i < 10)
                {
                    i = i + 1;
                    Console.WriteLine("Insira o numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero / 2 == 1)
                    {
                        Console.WriteLine("O número é par!");
                    }

                    else
                    {
                        Console.WriteLine("O número é inpar!");
                    }
                }
            
        
        }

        static void Atividade4()
        {
            int lado1;
            int lado2;
            int lado3;

            Console.WriteLine("Insira o valor do lado do triangulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado do triangulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado do triangulo: ");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero");
            }

            if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("Triângulo Isóseles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }

        }

        static void Atividade5()
        {
            int i;
            string[] vogais;
            vogais = new string[5];

            vogais[0] = "A";
            vogais[1] = "E";
            vogais[2] = "I";
            vogais[3] = "O";
            vogais[4] = "U";

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira uma letra: ");

               // um pouco de dificuldade aqui, gostaria de pesquisar mais, mas tenho que fazer as outras atividades, sorry if(isAlpha)
            }

        }

        static void Atividade6()
        {

            int numero = 0;
            int cont = 0;

            Console.WriteLine("Insira um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                if (numero % 1 == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine("O número" + numero + "é um número primo");
            }

            else
            {
                Console.WriteLine("O número" + numero + "não é um número primo");
            }
            Console.ReadKey();
        }


    }
}

