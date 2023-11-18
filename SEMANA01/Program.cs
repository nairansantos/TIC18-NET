
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
No .NET, existem vários tipos de dados numéricos inteiros. Aqui estão alguns dos tipos mais comuns:

int (Inteiro):
Tamanho: 32 bits em sistemas de 32 bits e 64 bits em sistemas de 64 bits.

long (Inteiro Longo):
Tamanho: 64 bits.

short (Inteiro Curto):
Tamanho: 16 bits.

byte (Byte):
Tamanho: 8 bits.

sbyte (SByte):
Tamanho: 8 bits, pode armazenar números negativos.

uint (Inteiro Sem Sinal):
Tamanho: 32 bits, armazena apenas números não negativos.

ulong (Inteiro Longo Sem Sinal):
Tamanho: 64 bits, armazena apenas números não negativos.

ushort (Inteiro Curto Sem Sinal):
Tamanho: 16 bits, armazena apenas números não negativos.
veja  exemplos em códigos:
*/

int idade = 25;
Console.WriteLine("Idade: " + idade);

// Exemplo com long
long populacaoMundial = 7_900_000_000L;
Console.WriteLine("População Mundial: " + populacaoMundial);

// Exemplo com short
short temperaturaMinima = -10;
Console.WriteLine("Temperatura Mínima:" + temperaturaMinima);

// Exemplo com byte
byte niveisDeCinza = 128;
Console.WriteLine("Níveis de Cinza: " + niveisDeCinza);

// Exemplo com sbyte
sbyte variacaoTemperatura = -5;
Console.WriteLine("Variação de Temperatura: " + variacaoTemperatura);

// Exemplo com uint
uint quantidadeItens = 1_000;
Console.WriteLine("Quantidade de Itens: " + quantidadeItens);

// Exemplo com ulong
ulong valorMaximo = 9_000_000_000_000_000_000UL;
Console.WriteLine("Valor Máximo: " + valorMaximo);

// Exemplo com ushort
ushort numeroDePortas = 10_000;
Console.WriteLine("Número de Portas: " + numeroDePortas);

#region 
//Conversão de Tipos de Dados:
{

  double valorDouble = 15.75;
  int valorInteiro = (int)valorDouble;
  Console.WriteLine($"Valor double:" + valorDouble);
  Console.WriteLine($"Valor inteiro : " + valorInteiro);
  /*Se a parte fracionária da variável double não puder ser convertida para um int por meio de casting em C#, ocorrerá a chamada "truncamento" da parte decimal. O truncamento simplesmente remove a parte fracionária, deixando apenas a parte inteira do número.*/

  Console.ReadLine();
}
#endregion
int x = 10;
int y = 3;

// Operações
int adicao = x + y;
int subtracao = x - y;
int multiplicacao = x * y;


if (y != 0)
{
  int divisao = x / y;


  Console.WriteLine($"Adição: " + adicao);
  Console.WriteLine($"Subtração: " + subtracao);
  Console.WriteLine($"Multiplicação: " + multiplicacao);
  Console.WriteLine($"Divisão: " + divisao);
}
else
{
  Console.WriteLine("A divisão por zero não é permitida.");
}


#region Operadores de Comparação:
{

  int a = 5;
  int b = 8;

  bool aMaiorQueB = a > b;


  Console.WriteLine("A é maior que B? " + aMaiorQueB);
}
#endregion

#region Operadores de Igualdade

string str1 = "Hello";
string str2 = "World";

if (str1 == str2)
{
  Console.WriteLine("As strings são iguais.");
}
else
{
  Console.WriteLine("As strings não são iguais.");
}

#endregion

#region operadores logicos

bool condicao1 = true;
bool condicao2 = false;

if (condicao1 && condicao2)
{
  Console.WriteLine("Ambas as condições são verdadeiras.");
}
else
{
  Console.WriteLine("Ambas as condições não são verdadeiras.");
}

#endregion

#region mistura de operadores
int num1 = 7;
int num2 = 3;
int num3 = 10;

if (num1 > num2 && num3 == num1 + num2)
{
  Console.WriteLine("num1 é maior do que num2 e num3 é igual a num1 + num2.");
}
else
{
  Console.WriteLine("num1 não é maior do que num2 ou num3 não é igual a num1 + num2.");
}
#endregion