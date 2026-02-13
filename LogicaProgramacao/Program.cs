// ======================================================
// Lógica de Programação em C#
// ======================================================

// Lógica de programação é a forma de organizar instruções
// para que o programa execute tarefas corretamente.

// Em C#, a lógica é estruturada através de:
// variáveis, operadores, condicionais e laços de repetição.

// C# é orientado a objetos,
// então a lógica normalmente é organizada dentro de classes e métodos.


// ======================================================
// Tipos de dados básicos em C#
// ======================================================

// C# é uma linguagem estaticamente tipada.
// Toda variável precisa ter um tipo definido em tempo de compilação.

// Os tipos que usamos na linguagem C#
// são palavras-chave que representam tipos reais do .NET.

// Exemplo:
// int é um apelido para System.Int32
// bool é um apelido para System.Boolean

// Isso acontece porque o C# roda sobre a plataforma .NET.
// O .NET define os tipos reais,
// e o C# fornece palavras mais simples para utilizá-los.



// ======================================================
// Tipos Integrais (Números inteiros)
// ======================================================

// sbyte  -> inteiro de 8 bits com sinal. No .NET: System.SByte ou SByte
// byte   -> inteiro de 8 bits sem sinal. No .NET: System.Byte ou Byte
// short  -> inteiro de 16 bits com sinal. No .NET: System.Int16 ou Int16
// ushort -> inteiro de 16 bits sem sinal. No .NET: System.UInt16 ou UInt16

// int    -> inteiro de 32 bits com sinal (mais usado). No .NET: System.Int32 ou Int32
// Observação: valores inteiros são considerados int por padrão

// uint   -> inteiro de 32 bits sem sinal. No .NET: System.UInt32 ou UInt32 
// Observação: pode usar sufixo U no final do número

// long   -> inteiro de 64 bits com sinal. No .NET: System.Int64 ou Int64
// Observação: usar sufixo L no final do valor para indicar long (ex: 100L)

// ulong  -> inteiro de 64 bits sem sinal. No .NET: System.UInt64 ou UInt64
// Observação: usar sufixo UL no final do valor


// ======================================================
// Tipos Decimais
// ======================================================

// float   -> decimal de 32 bits (precisão simples). No .NET: System.Single
// Observação: números decimais são double por padrão
// Para definir float é obrigatório usar sufixo F (ex: 10.5F)

// double  -> decimal de 64 bits (precisão dupla, mais comum). No .NET: System.Double
// Observação: é o tipo decimal padrão. Pode usar sufixo D no final do valor, mas não é obrigatório

// decimal -> decimal de 128 bits (alta precisão, financeiro). No .NET: System.Decimal
// Observação: é obrigatório usar sufixo M no final do valor (ex: 10.5M)


// ======================================================
// Outros Tipos Fundamentais
// ======================================================

// char   -> representa um único caractere Unicode. No .NET: System.Char
// bool   -> representa verdadeiro ou falso. No .NET: System.Boolean
// string -> representa uma sequência de caracteres. No .NET: System.String



// ======================================================
// Saída de Dados em C# 
// ======================================================

// Saída de dados é quando o programa informa dados para o usuário - nesse caso será imprimindo na tela do PC

// Para imprimirmos alguma informação na tela do computador utilizamos o método (comando):
// Console.WriteLine() - Coloca quebra de linha depois de exibir o valor na tela
// Console.Write() - Não coloca quebra de linha depois de exibir o valor na tela

// 



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
            // Saída de dados em C# - exibindo dados na tela 
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
            //  Operadores em C#
            // ======================================================


            // ======================================================
            // Operadores de Atribuição
            // ======================================================

            // O operador '=' é usado para atribuir um valor a uma variável.
            // Ele substitui o valor atual da variável pelo novo valor.


            // Operadores de Atribuição Composta

            // Esses operadores fazem uma operação matemática
            // e já armazenam o resultado na própria variável.

            // +=  -> soma o valor à variável e salva o resultado nela mesma.
            // -=  -> subtrai o valor da variável e salva o resultado.
            // *=  -> multiplica a variável pelo valor e salva o resultado.
            // /=  -> divide a variável pelo valor e salva o resultado.
            // %=  -> calcula o resto da divisão e salva o resultado.


            // Operadores de Atribuição com Bits

            // Usados para operações binárias (nível de bits).

            // &=  -> aplica AND bit a bit e salva o resultado.
            // |=  -> aplica OR bit a bit e salva o resultado.
            // ^=  -> aplica XOR bit a bit e salva o resultado.
            // <<= -> desloca os bits para a esquerda e salva o resultado.
            // >>= -> desloca os bits para a direita e salva o resultado.


            // Operador de Atribuição Condicional

            // ??= -> só atribui o valor se a variável estiver nula.
            // Muito usado com tipos que permitem null.



            // ======================================================
            // Operadores Aritméticos
            // ======================================================

            // Os operadores aritméticos são usados para realizar
            // cálculos matemáticos entre valores numéricos.


            // +  -> adição. Soma dois valores.

            // -  -> subtração. Subtrai um valor do outro.

            // *  -> multiplicação. Multiplica dois valores.

            // /  -> divisão. Divide um valor pelo outro.

            // Observação: se os dois valores forem inteiros,
            // o resultado será inteiro (descarta a parte decimal).

            // %  -> módulo. Retorna o resto da divisão.


            // ======================================================
            // Operadores Unários Aritméticos
            // ======================================================

            // ++ -> incremento. Aumenta 1 unidade no valor da variável.

            // -- -> decremento. Diminui 1 unidade no valor da variável.

            // +  -> operador unário positivo (mantém o valor positivo).

            // -  -> operador unário negativo (inverte o sinal do valor).



            // ======================================================
            // Entrada de Dados em C#
            // ======================================================

            // Entrada de dados é quando o programa vai ler os dados que o usuário digitou e enviou
            // Para o programa
            // Ou quando o programa vai ler os dados de outra fonte, de outro arquivo por exemplo

            // O comando em C# para você ler os dados digitados pelo usuário é o comando:

            // Console.ReadLine() - Lê da entrada padrão até a quebra de linha e retorna em string


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

            // Os operadores comparativos são usados para comparar valores das variáveis.

            // O resultado de uma comparação sempre será verdadeiro (true) ou falso (false).


            // ==  -> igual a. Verifica se dois valores são iguais.

            // !=  -> diferente de. Verifica se dois valores são diferentes.

            // >   -> maior que. Verifica se o valor da esquerda é maior.

            // <   -> menor que. Verifica se o valor da esquerda é menor.

            // >=  -> maior ou igual a. Verifica se é maior ou igual.

            // <=  -> menor ou igual a. Verifica se é menor ou igual.


            int valorA = 10;

            // Aqui estamos comparando se o valor da variável valorA é menor que 10
            // Para isso usamos um operador comparativo
            // E o resultado dessa comparação vai ser true ou false - nesse caso vai ser false
            // Com isso ao imprimir o valor da variável c1 vamos ter false
            bool c1 = valorA < 10;

            Console.WriteLine(c1);



            // ======================================================
            // Operadores Lógicos
            // ======================================================

            // Os operadores lógicos são usados para combinar
            // expressões booleanas (true ou false).


            // &&  -> AND lógico (E).
            // Retorna true somente se ambas as condições forem verdadeiras.

            // ||  -> OR lógico (OU).
            // Retorna true se pelo menos uma das condições for verdadeira.

            // !   -> NOT lógico (NÃO).
            // Inverte o valor booleano. Se for true vira false, e vice-versa.



            // ======================================================
            // Estrutura Condicional (if-else) em C#
            // ======================================================

            // A estrutura condicional é usada para executar
            // blocos de código com base em uma condição lógica.

            // A condição sempre deve retornar true ou false.


            // ======================================================
            // Estrutura Condicional Simples
            // ======================================================

            // A estrutura simples utiliza apenas o if().
            // O bloco dentro do if() será executado somente se a condição for verdadeira.

            /*
             * if (condição) {
             *    comando 1
             *    comando 2
             * }
             */


            // ======================================================
            // Estrutura Condicional Composta
            // ======================================================

            // A estrutura composta utiliza if() e else.
            // Se a condição for verdadeira, será executado o bloco do if().
            // Caso contrário (se a condição for falsa), será executado o bloco do else.

            /*
             * if (condição) {
             *    comandos se verdadeiro
             * }
             * else {
             *    comandos se falso
             * }
             */


            // ======================================================
            // Estrutura Condicional Encadeada
            // ======================================================

            // A estrutura condicional encadeada é usada quando
            // precisamos testar múltiplas condições diferentes.

            // Ela utiliza if(), else if() e else.

            // O programa avalia as condições de cima para baixo.
            // Quando encontra a primeira condição verdadeira,
            // executa o bloco correspondente e ignora as demais.


            // Estrutura básica:

            /*
             * if (condição1) {
             *    comandos
             * }
             * else if (condição2) {
             *    comandos
             * }
             * else if (condição3) {
             *    comandos
             * }
             * else {
             *    comandos caso nenhuma condição seja verdadeira
             * }
             */


            // Observações:

            // Apenas um bloco será executado.
            // O bloco else é opcional.
            // A ordem das condições é importante,
            // pois a primeira condição verdadeira encerra a verificação das outras condições.




            // Vamos criar um programa onde o usuário entra com um número inteiro
            // E o programa vai ter que dizer se esse número é par ou ímpar
            // Para isso vamos utilizar estruturas condicionais
            // Onde a nossa condição será verificar se o valor digitado é par ou ímpar
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


            // Agora vamos fazer um programa para utilizar estrutura condicional encadeada
            // Para isso vamos criar um programa que vai perguntar a hora ao usuário
            // E dependendo de que horas seja, ele vai imprimir na tela: Bom dia, Boa tarde ou Boa Noite
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

            // Funções representam um bloco de código responsável
            // por executar uma tarefa específica.

            // Elas servem para encapsular um processamento (uma operação)
            // que possui um significado dentro do sistema.

            // Exemplo conceitual:
            // Uma função como Math.Sqrt() representa o cálculo
            // da raiz quadrada de um número informado (passado) para ela.


            // ======================================================
            // Vantagens das Funções
            // ======================================================

            // Modularização  -> divide o programa em partes menores e organizadas.
            // Reaproveitamento -> permite reutilizar o mesmo código (a mesma função) várias vezes.
            // Delegação -> permite separar responsabilidades no sistema.


            // ======================================================
            // Entrada e Saída de Dados
            // ======================================================

            // Funções podem receber dados de entrada,
            // chamados de parâmetros (ou argumentos).

            // Elas podem ou não retornar um valor como saída.
            // Quando retornam, utilizam a palavra-chave "return".


            // ======================================================
            // Funções em Orientação a Objetos
            // ======================================================

            // Em programação orientada a objetos,
            // funções declaradas dentro de classes
            // recebem o nome de métodos.


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

            // A estrutura while é usada para repetir um bloco de código
            // enquanto uma condição for verdadeira.

            // A condição é verificada antes de cada repetição.
            // Se a condição for true, o bloco é executado.
            // Se for false, a repetição é encerrada.

            // É importante garantir que a condição
            // em algum momento se torne falsa,
            // para evitar um loop infinito.

            /*
             * while (condição) {
             *    comando 1
             *    comando 2
             * }
             */


            // Vamos fazer um programa utilizando a estrutura de repetição while
            // Nesse programa vamos pedir pra o usuário digitar um número
            // E vamos mostrar pra o usuário o valor da raiz quadrada desse número digitado com 3 casas
            // Depois do usuário digitar o primeiro valor, e o programa calcular, ele repete o processo
            // Só finaliza e sai do loop caso o usuário digite um valor negativo
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

            // A estrutura for é utilizada quando sabemos
            // antecipadamente quantas vezes o bloco de código
            // deve ser executado.

            // Ela é muito usada para percorrer sequências (que já sabemos)
            // ou repetir alguns comandos, um número definido de vezes.

            // O for possui três partes principais:
            // início      -> onde declaramos e inicializamos a variável de controle.
            // condição    -> define até quando a repetição continuará. Até onde vai a variável de controle
            // incremento  -> atualiza a variável de controle a cada repetição.

            // A repetição acontece enquanto a condição for verdadeira.
            // Quando a condição se torna falsa, o loop é encerrado.

            /*
             * for (inicio; condição; incremento) {
             *    comando 1
             *    comando 2
             * }
             */


            // Vamos fazer um exercicio para testar a estrutura repetitiva for
            // Vamos pedir para o usuário digitar um valor inteiro
            // Caso ele digite 3, por exemplo, vamos pegar desse usuário 3 valores inteiros
            // Ou seja, pedir pra ele digitar 3 valores inteiros
            // Depois vamos usar o for para percorrer esses 3 valores digitamos e somar eles e da o resultado
            // Da soma desses 3 valores
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            // Como já sabemos quantas vezes devemos repetir o valor inteiro a ser pego agora do usuário
            // Pois deve repetir N vezes
            // Logo podemos usar a estrutura repetitiva for e não while

            int soma = 0;
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }

        // Criando a função Maior()
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
