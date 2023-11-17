
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//No .NET, existem vários tipos de dados numéricos inteiros. Aqui estão alguns dos tipos mais comuns:

/*
int (Inteiro):
Tamanho: 32 bits em sistemas de 32 bits e 64 bits em sistemas de 64 bits.
Exemplo: int numeroInteiro = 42;

long (Inteiro Longo):
Tamanho: 64 bits.
Exemplo: long numeroLongo = 1234567890123456789L;ccccccccs

short (Inteiro Curto):
Tamanho: 16 bits.
Exemplo: short numeroCurto = 32767;

byte (Byte):
Tamanho: 8 bits.
Exemplo: byte byteValor = 255;

sbyte (SByte):
Tamanho: 8 bits, pode armazenar números negativos.
Exemplo: sbyte sbyteValor = -128;

uint (Inteiro Sem Sinal):
Tamanho: 32 bits, armazena apenas números não negativos.
Exemplo: uint numeroSemSinal = 4294967295U;

ulong (Inteiro Longo Sem Sinal):
Tamanho: 64 bits, armazena apenas números não negativos.
Exemplo: ulong numeroLongoSemSinal = 18446744073709551615UL;

ushort (Inteiro Curto Sem Sinal):
Tamanho: 16 bits, armazena apenas números não negativos.
Exemplo: ushort numeroCurtoSemSinal = 65535;
veja dois exemplos em códigos:
*/

class Exemplo
{
  static void Main()
  {


    int numero = 5;
    int resultado = numero * 2;
    Console.WriteLine($"Exemplo 1: O dobro de {numero} é {resultado}");

    // Exemplo 2: long
    long numero1 = 123456789012345;
    long numero2 = 987654321098765;
    long soma = numero1 + numero2;
    Console.WriteLine($"Exemplo 2: A soma de {numero1} e {numero2} é {soma}");




    Console.ReadLine();
  }
}



