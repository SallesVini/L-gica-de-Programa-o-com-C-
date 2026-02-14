### 🧠 LÓGICA DE PROGRAMAÇÃO EM C#

Lógica de programação é a forma de organizar instruções  
para que o programa execute tarefas corretamente.

Em C#, a lógica é estruturada através de:  
variáveis, operadores, condicionais e laços de repetição.

C# é orientado a objetos,  
então a lógica normalmente é organizada dentro de classes e métodos.

---

#### 🧠 Tipos de dados básicos em C#

C# é uma linguagem estaticamente tipada.  
Toda variável precisa ter um tipo definido em tempo de compilação.

Os tipos que usamos na linguagem C#  
são palavras-chave que representam tipos reais do .NET.

Exemplo:

- int é um apelido para System.Int32  
- bool é um apelido para System.Boolean  

Isso acontece porque o C# roda sobre a plataforma .NET.  
O .NET define os tipos reais,  
e o C# fornece palavras mais simples para utilizá-los.

---

#### 🧠 Tipos Integrais (Números inteiros)

- sbyte  -> inteiro de 8 bits com sinal. No .NET: System.SByte ou SByte  
- byte   -> inteiro de 8 bits sem sinal. No .NET: System.Byte ou Byte  
- short  -> inteiro de 16 bits com sinal. No .NET: System.Int16 ou Int16  
- ushort -> inteiro de 16 bits sem sinal. No .NET: System.UInt16 ou UInt16  

- int    -> inteiro de 32 bits com sinal (mais usado). No .NET: System.Int32 ou Int32  
  Observação: valores inteiros são considerados int por padrão  

- uint   -> inteiro de 32 bits sem sinal. No .NET: System.UInt32 ou UInt32  
  Observação: pode usar sufixo U no final do número  

- long   -> inteiro de 64 bits com sinal. No .NET: System.Int64 ou Int64  
  Observação: usar sufixo L no final do valor (ex: 100L)  

- ulong  -> inteiro de 64 bits sem sinal. No .NET: System.UInt64 ou UInt64  
  Observação: usar sufixo UL no final do valor  

---

#### 🧠 Tipos Decimais

- float   -> decimal de 32 bits (precisão simples). No .NET: System.Single  
  Observação: números decimais são double por padrão  
  Para definir float é obrigatório usar sufixo F (ex: 10.5F)  

- double  -> decimal de 64 bits (precisão dupla, mais comum). No .NET: System.Double  
  Observação: é o tipo decimal padrão. Pode usar sufixo D, mas não é obrigatório  

- decimal -> decimal de 128 bits (alta precisão, financeiro). No .NET: System.Decimal  
  Observação: é obrigatório usar sufixo M (ex: 10.5M)  

---

#### 🧠 Outros Tipos Fundamentais

- char   -> representa um único caractere Unicode. No .NET: System.Char  
- bool   -> representa verdadeiro ou falso. No .NET: System.Boolean  
- string -> representa uma sequência de caracteres. No .NET: System.String  

---

#### 🧠 Saída de Dados em C#

Saída de dados é quando o programa informa dados para o usuário  
(imprimindo na tela do computador).

Para imprimir informações na tela utilizamos:

- Console.WriteLine() -> coloca quebra de linha depois de exibir  
- Console.Write()     -> não coloca quebra de linha  

---

#### 🧠 Criando variáveis em C# - Utilizando seus tipos básicos

```csharp
bool completo = false;
char genero = 'F';
char letra = '\u0041'; // Código unicode que representa a letra A
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
```

---

#### 🧠 Operadores em C#

#### Operadores de Atribuição

O operador `=` é usado para atribuir um valor a uma variável.  
Ele substitui o valor atual da variável pelo novo valor.

#### Operadores de Atribuição Composta

Esses operadores fazem uma operação matemática e já armazenam o resultado na própria variável.

- +=  -> soma e salva na própria variável  
- -=  -> subtrai e salva  
- *=  -> multiplica e salva  
- /=  -> divide e salva  
- %=  -> calcula o resto da divisão e salva  

#### Operadores de Atribuição com Bits

Usados para operações binárias (nível de bits).

- &=  -> AND bit a bit  
- |=  -> OR bit a bit  
- ^=  -> XOR bit a bit  
- <<= -> desloca bits para a esquerda  
- >>= -> desloca bits para a direita  

#### Operador de Atribuição Condicional

- ??= -> só atribui se a variável estiver nula
  Muito usado com tipos que permitem null.

---

#### Operadores Aritméticos

Os operadores aritméticos são usados para realizar cálculos matemáticos entre valores numéricos.

- +  -> adição  
- -  -> subtração  
- *  -> multiplicação  
- /  -> divisão  
- %  -> módulo (resto da divisão)  

Observação: se os dois valores forem inteiros, o resultado será inteiro (descarta a parte decimal).

---

#### Operadores Unários Aritméticos

- ++ -> incremento. Aumenta 1 unidade no valor da variável.  
- -- -> decremento. Diminui 1 unidade no valor da variável.
- +  -> operador unário positivo (mantém o valor positivo).
- -  -> operador unário negativo (inverte o sinal do valor). 

---

#### 🧠 Entrada de Dados em C#

Entrada de dados é quando o programa lê dados digitados pelo usuário ou de outra fonte, de outro arquivo por exemplo.

O comando em C# para você ler os dados digitados pelo usuário é o comando:

- Console.ReadLine() -> Lê da entrada padrão até a quebra de linha e retorna para o programa em forma de string o que foi lido.

---

#### 🧠 Operadores Comparativos (Relacionais)

Os operadores comparativos são utilizados para comparar valores entre variáveis ou expressões.

O resultado de qualquer comparação é sempre um valor booleano:
**true (verdadeiro)** quando a condição é atendida, ou
**false (falso)** quando não é atendida.

- ==  -> igual a  
- !=  -> diferente de  
- >   -> maior que  
- <   -> menor que  
- >=  -> maior ou igual  
- <=  -> menor ou igual  

O resultado sempre será `true` ou `false`.

---

#### 🧠 Operadores Lógicos

Os operadores lógicos são usados para combinar expressões booleanas ( e sempre vão retornar true ou false).

- &&  -> AND lógico (verdadeiro se ambas forem verdadeiras)  
- ||  -> OR lógico (verdadeiro se ao menos uma for verdadeira)  
- !   -> NOT lógico (inverte o valor booleano)  

---

#### 🧠 Estrutura Condicional (if-else)

A estrutura condicional é usada para executar  
blocos de código com base em uma condição lógica.

A condição sempre deve retornar `true` ou `false`.

#### Estrutura Condicional Simples

A estrutura condicional simples é composta apenas por um único if().
O bloco de código dentro do if() será executado somente se a condição desse if() for verdadeira.

```csharp
if (condição) {
    comando 1;
    comando 2;
}
```

#### Estrutura Condicional Composta

A estrutura condicional composta é formada por uma estrutura if() e uma estrutura else.
Se a condição nesse caso for verdadeira, então o que será executado será a estrutura if().
Caso a condição nesse caso seja falsa, então o que será executado será a estrutura else.

```csharp
if (condição) {
    comandos se verdadeiro;
}
else {
    comandos se falso;
}
```

#### Estrutura Condicional Encadeada

A estrutura condicional encadeada é usada quando precisamos testar múltiplas condições diferentes.
Ela utiliza uma estrutura if(), uma estrutura else if() e uma estrutura else.

O programa avalia as condições de cima para baixo.
Quando encontra a primeira condição verdadeira, executa a estrutura correspondente e ignora as demais.

```csharp
if (condição1) {
    comandos;
}
else if (condição2) {
    comandos;
}
else if (condição3) {
    comandos;
}
else {
    comandos caso nenhuma condição seja verdadeira;
}
```

Observações:

- Apenas um bloco será executado.  
- O bloco `else` é opcional.  
- A ordem das condições é importante, pois a primeira condição verdadeira encerra a verificação das outras condições.

---

#### 🧠 Funções

Funções representam um bloco de código responsável  
por executar uma tarefa específica.

Elas servem para encapsular um processamento (uma operação) que possui um significado dentro do sistema.

Exemplo conceitual:
Uma função como:
- Math.Sqrt() -> representa o cálculo da raiz quadrada de um número informado (passado) para ela.


#### Vantagens das Funções

- Modularização  -> divide o programa em partes menores e organizadas.  
- Reaproveitamento -> permite reutilizar o mesmo código (a mesma função) várias vezes. 
- Delegação  Delegação -> permite separar responsabilidades no sistema.


#### Entrada e Saída de Dados em Funções

Funções podem receber dados de entrada,
chamados de parâmetros (ou argumentos).

Elas podem ou não retornar um valor como saída.
Quando retornam, utilizam a palavra-chave `return`.


#### Funções em Orientação a Objetos

Em programação orientada a objetos, funções declaradas dentro de classes recebem o nome de **métodos**.  


#### Funções em C#

No C#, toda função obrigatoriamente deve estar dentro de uma classe.
Não existem funções soltas fora de classes.

Quando criamos um método, precisamos definir se ele pertence: À classe Ou ao objeto (instância) da classe

Para indicar que um método pertence à classe, utilizamos a palavra-chave static.


#### Por que precisamos de static?

A palavra static indica que o método pertence à própria classe,
e não a um objeto específico criado com new.

Isso significa que:

Métodos (funções) static podem ser chamados diretamente pela classe

Métodos não static precisam de um objeto instanciado


#### Exemplo de método static:

class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}


#### 📌 Uso:

int resultado = Calculadora.Somar(5, 3);


Não foi necessário criar um objeto da classe Calculadora.

Se o método não for static, ele pertence à instância da classe:

class Pessoa
{
    public string Nome;

    public void Apresentar()
    {
        Console.WriteLine("Olá, meu nome é " + Nome);
    }
}


#### 📌 Uso:

Pessoa p = new Pessoa();
p.Nome = "Vinícius";
p.Apresentar();


Aqui foi necessário criar o objeto,
pois o método depende dos dados da instância.


#### 📌 Por que o método Main é static?

O método Main é o ponto de entrada do programa.
Ele precisa ser static porque é executado antes da criação
de qualquer objeto.

O sistema precisa chamar esse método diretamente pela classe,
sem instanciá-la manualmente.


#### 📌 Quando usar static?

Use static quando o método:

Não depende de atributos da instância

Representa um comportamento geral

É utilitário (ex: cálculos, validações, conversões)


#### 📌 Não use static quando o método:

Precisa acessar dados específicos do objeto

Depende do estado interno da instância

---


#### 🧠 Estrutura Repetitiva while

A estrutura `while` é usada para repetir um bloco de código  
enquanto uma condição for verdadeira.

A condição é verificada antes de cada repetição. Se a condição for **true**, o bloco é executado.
Se for **false**, a repetição é encerrada.

É importante garantir que a condição em algum momento se torne falsa, para evitar um loop infinito.

```csharp
while (condição) {
    comando 1;
    comando 2;
}
```

---


#### 🧠 Estrutura Repetitiva for

A estrutura `for` é utilizada quando sabemos antecipadamente quantas vezes o bloco de código deve ser executado.

Ela é muito usada para percorrer sequências (que já conhecemos) ou repetir alguns comandos, um número definido de vezes. 

O for possui três partes principais:

- início -> onde declaramos e inicializamos a variável de controle.
- condição -> define até quando a repetição continuará. Até onde vai a variável de controle 
- incremento -> atualiza a variável de controle a cada repetição.

A repetição acontece enquanto a condição for verdadeira. Quando a condição se torna falsa, o loop é encerrado.

```csharp
for (inicio; condição; incremento) {
    comando 1;
    comando 2;
}
```
