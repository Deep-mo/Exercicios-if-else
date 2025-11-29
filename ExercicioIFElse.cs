using System;
using System.Linq;

namespace ExerciciosIfElse;

public static class Program
{
    public static void Main()
    {
        //texto eacolha de texte
        Console.WriteLine("Teremos abaixo alguns exercicios escolha qual gostaria de fazer");
        Console.WriteLine("digite 1 para maioridade");
        Console.WriteLine("digite 2 para par ou impar");
        Console.WriteLine("digite 3 para Teste de Aprovacao");
        Console.WriteLine("digite 4 para comparação de numeros");
        Console.WriteLine("digite 5 para teste senha admin");
        Console.WriteLine("digite 6 para correlacao numero dia ");

        string continuar = "sim";
        while (continuar == "sim")
        {

            string escolhaExEntrada = Console.ReadLine();
            int escolhaEx = int.Parse(escolhaExEntrada);
            if (escolhaEx == 1)
            {//aqui começa a licao maioridade
                Console.WriteLine("Vamos ver se voce è maior de idade,diga a sua idade");
                string idadeTexto = Console.ReadLine();
                int idade = int.Parse(idadeTexto);

                if (idade >= 18)
                {
                    Console.WriteLine("Tudo certo voce è maior de idade");

                }
                else
                {
                    Console.WriteLine("Voce nao è maior de idade");
                }//fim licao maioridade


            }
            else if (escolhaEx == 2)
            {
                //licao numero par ou impar aqui
                Console.WriteLine("Digite um numero e o programa dira se è par ou impar");
                string numeroPIEntrada = Console.ReadLine();

                int numeroPI = int.Parse(numeroPIEntrada);

                if (numeroPI % 2 == 0)
                {
                    Console.WriteLine("O numero " + numeroPI + "è par");

                }
                else
                {
                    Console.WriteLine("O Seu Numero" + numeroPI + "è impar");
                }
            }
            else if (escolhaEx == 3)
            {  // licao aprovado reprovado

                Console.WriteLine("Abaixo pode ser usado um teste simple para provas,jogue um numero e ele testara sr o aluno passou");

                string notaEntrada = Console.ReadLine();
                int notaValor = int.Parse(notaEntrada);

                //resultado e calculo abaixo
                if (notaValor >= 7)
                {
                    Console.WriteLine($"O valor de sua nota è {notaValor}. Você passou");
                }
                else
                {
                    Console.WriteLine("Voce esta abaixao da media,esta reprovado");
                }
            }
            else if (escolhaEx == 4)
            {
                //licao de comparativos entre numeros

                Console.WriteLine("Abaixo voce pode passar dois numeors para serem comparados se sao igaui ou um è maior que o outro");

                Console.WriteLine("Digite o primeiro valor"); //entrada do valor Um por aqui
                string numeroUmEntrada = Console.ReadLine();
                int numeroUm = int.Parse(numeroUmEntrada);

                Console.WriteLine("Agora digite o segundo valor "); //entrada do valor Dois
                string numeroDoisEntrada = Console.ReadLine();
                int numeroDois = int.Parse(numeroDoisEntrada);

                //Calculo abaixo

                if (numeroUm > numeroDois)
                {
                    Console.WriteLine($"O numero {numeroUm} é maior que o numero {numeroDois}");

                }
                else if (numeroUm < numeroDois)
                {
                    Console.WriteLine($"O numero {numeroUm} è menor que o numero {numeroDois}");

                }
                else if (numeroUm == numeroDois)
                {
                    Console.WriteLine("Os dois numeros sao iguais");
                }
            }
            else if (escolhaEx == 5)
            {
                //licao senha e admin
                Console.WriteLine("Aqui è o teste Admin e senha 1234,para compravar digite o usuario e a senha abaixo");

                Console.WriteLine("Nome de usuario :");//parte senha admin
                string senhaString = Console.ReadLine();
                if (senhaString == "admin")
                {
                    Console.WriteLine("Senha correta");

                    Console.WriteLine("Agora digite a senha"); //partr senha 1234
                    string senhaNumeroString = Console.ReadLine();
                    int senhaNumero = int.Parse(senhaNumeroString);
                    if (senhaNumero == 1234)
                    {
                        Console.WriteLine("Senha Correta,passagrm permitida");

                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta");
                    }


                }
                else
                {
                    Console.WriteLine("Nome de usuario incorreto");
                }
            }
            else if (escolhaEx == 6)
            {
                //licao comparativo numero de entrada para dia da semana
                Console.WriteLine("Aqui vamos correlacionar um numero com um dia da semana,lembrando que a semana começa no domingo...digite um numero");

                string diaEntradaN = Console.ReadLine();
                int diaN = int.Parse(diaEntradaN);

                if (diaN == 1)
                {
                    Console.WriteLine($"O dia {diaN} equivale ao Domingo");
                }
                else if (diaN == 2)
                {
                    Console.WriteLine($"O dia {diaN} equivale a Segunda");
                }
                else if (diaN == 3)
                {
                    Console.WriteLine($"O dia {diaN} equivale a Terça");
                }
                else if (diaN == 4)
                {
                    Console.WriteLine($"O dia {diaN} equivale a Quarta");
                }
                else if (diaN == 5)
                {
                    Console.WriteLine($"O dia {diaN} equivale a Quinta");
                }
                else if (diaN == 6)
                {
                    Console.WriteLine($"O dia {diaN} equivale a Sexta");
                }
                else if (diaN == 7)
                {
                    Console.WriteLine($"O dia {diaN} equivale ao Sabado");
                }
                else
                {
                    Console.WriteLine("a entrada nao equivale a um dia da semana");
                }

            }
            Console.WriteLine("quer tentar outra coisa");
            string resposta = Console.ReadLine();

        }
    }
}
