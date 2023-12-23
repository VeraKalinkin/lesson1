//Console.WriteLine("Hello, World!");

using System.Diagnostics.CodeAnalysis;

int count = 193728;
while (count > 0)
{
    int a = count % 10;
    count = count / 10;
    Console.Write(a);
    Console.Write(' ');
};

