using System;
using Pile;
class Pilha
{
    static void Main(string[] args)
    {
       MyPile pilhaTeste = new MyPile();

        pilhaTeste.StackUp(1);
        pilhaTeste.StackUp(2);
        pilhaTeste.StackUp(3);
        Console.WriteLine(pilhaTeste.Unstack());
        Console.WriteLine(pilhaTeste.Unstack());
        Console.WriteLine(pilhaTeste.Unstack());
        Console.WriteLine(pilhaTeste.Unstack());
    }
}