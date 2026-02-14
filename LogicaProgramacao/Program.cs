using System;

namespace LogicaProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ======================================================
            // Criando variáveis em C# - E utilizando seus tipos básicos
            // ======================================================

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; // Código unicode que representa a letra (caracter) A
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5F;
            double n6 = 4.5;
            string nome = "Maria";

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);




            // ======================================================
            // Saída de dados em C# e Concatenação - exibindo dados na tela 
            // ======================================================

            // Com quebra de linha
            Console.WriteLine("Bom dia!");

            // Sem quebra de linha
            Console.Write("Boa tarde!");

            Console.WriteLine("Boa noite!");


            // Imprimindo uma variável double com duas casas decimais
            // Para isso utilizamos no WriteLine() a função ToString() informando a quantidade de casas
            double saldo = 10.35784;

            Console.WriteLine(saldo.ToString("F2"));


            // Concatenando (juntando) valores de variáveis e exibindo na tela
            int idade = 32;
            double salario = 10.35784;
            string nome2 = "Maria";

            // Queremos imprimir na tela: "Maria tem 32 anos, e tem o salario de: 10,36 reais"
            
            // Usando Placeholders
            Console.WriteLine("{0} tem {1} anos, e tem o salario de: {2:F2} reais", nome2, idade, salario);

            // Usando Interpolação
            Console.WriteLine($"{nome2} tem {idade} anos, e tem o salario de: {salario:F2} reais");

            // Usando Concatenação
            Console.WriteLine(nome + "tem" + idade + " anos, e tem o salario de: " + salario.ToString("F2") + " reais");




            // ======================================================
            // Entrada de Dados em C# - Recebendo valores do usuário
            // ======================================================


            // Pegando um texto (uma frase) digitada pelo usuário e armazenando na variável string
            string frase = Console.ReadLine();

            Console.WriteLine(frase);

            
            // Pegando vários textos digitados pelo usuário e colocando em variáveis diferentes
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            // Lendo (recebendo) valores numéricos inteiros e decimais

            // Lendo número inteiro
            // Como o Console.ReadLine() pega o valor e retorna como string, logo precisamos converter
            // Esse valor recebido, que agora é string, em um inteiro

            // Para isso utilizamos o método .Parse() - passando o valor string recebido para inteiro
            int numeroRecebido = int.Parse(Console.ReadLine());
            char caracterRecebido = char.Parse(Console.ReadLine());
            double pontoFlutuanteRecebido = double.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(numeroRecebido);
            Console.WriteLine(caracterRecebido);
            Console.WriteLine(pontoFlutuanteRecebido);




            // ======================================================
            // Operadores Comparativos (Relacionais)
            // ======================================================


            int valorA = 10;

            // Aqui estamos verificando se o valor da variável "valorA" é menor que 10,
            // utilizando um operador comparativo.
            //
            // O resultado dessa comparação sempre será um valor booleano,
            // ou seja, true ou false.
            // Neste caso específico, o resultado será false.
            //
            // Portanto, ao imprimir o valor da variável "c1",
            // o que será exibido na tela é "false".
            bool c1 = valorA < 10;

            Console.WriteLine(c1);




            // ======================================================
            // Estrutura Condicional (if-else) em C#
            // ======================================================


            // Vamos criar um programa em que o usuário informe um número inteiro.
            // O objetivo é verificar se esse número inteiro informado é par ou ímpar.
            //
            // Para isso, utilizaremos uma estrutura condicional composta,
            // cuja condição dessa estrutura será analisar o valor digitado
            // e determinar se ele é divisível por 2 (par)
            // ou se possui resto na divisão (pois aí será um número ímpar).
            Console.WriteLine("Entre com um número inteiro: ");
            int valorInteiro = int.Parse(Console.ReadLine());

            if(valorInteiro % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }


            // Agora vamos criar um programa para praticar a estrutura condicional encadeada (if / else if / else).
            // O programa solicitará ao usuário que informe a hora atual.
            // Com base no horário informado, será exibida uma mensagem apropriada:
            // "Bom dia", "Boa tarde" ou "Boa noite".
            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }




            // ======================================================
            // Funções
            // ======================================================


            // Fazer um programa para ler três números inteiros e mostrar na tela o maior deles
            Console.WriteLine("Digite três números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            double resultado = Maior(num1, num2, num3);
            
            Console.WriteLine("Maior = " + resultado);




            // ======================================================
            // Estrutura Repetitiva while
            // ======================================================


            // Vamos desenvolver um programa utilizando a estrutura de repetição "while".
            // Nesse programa, solicitaremos ao usuário que digite um número.
            // Em seguida, exibiremos a raiz quadrada desse número,
            // formatada com 3 casas decimais.
            //
            // Após calcular e mostrar o resultado, o programa continuará
            // solicitando novos números e repetindo o processo.
            //
            // A execução só será encerrada quando o usuário digitar
            // um valor negativo, que servirá como condição de parada do loop "while".
            Console.Write("Digite um número: ");
            double numEntrada = double.Parse(Console.ReadLine());

            while (numEntrada >= 0.0)
            {
                double raiz = Math.Sqrt(numEntrada);
                Console.WriteLine(raiz.ToString("F3"));

                Console.Write("Digite um outro número: ");
                numEntrada = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo!");




            // ======================================================
            // Estrutura Repetitiva for
            // ======================================================


            // Vamos criar um exercício para praticar a estrutura de repetição "for".
            // Primeiro, solicitaremos ao usuário que informe um número inteiro.
            // Suponha que ele digite 3, por exemplo.
            // Isso significa que o programa deverá solicitar mais 3 valores inteiros.
            //
            // Em seguida, utilizaremos o laço "for" para percorrer esses 3 valores informados,
            // somá-los e, ao final, exibir o resultado total da soma.
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            // Como já sabemos exatamente quantas vezes o valor inteiro deverá ser solicitado ao usuário,
            // ou seja, a repetição acontecerá N vezes,
            // a estrutura mais adequada é o laço "for",
            // pois ele é indicado quando a quantidade de repetições é previamente conhecida,
            // diferente do "while", que é mais utilizado quando não sabemos ao certo
            // quantas vezes o laço precisará executar.
            int soma = 0;
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }




        // ======================================================
        // Criando a função Maior()
        // ======================================================
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
