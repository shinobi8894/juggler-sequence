// C# implementation of Juggler Sequence
using System;
 
class GFG {
     
    // This function prints the juggler Sequence
    static void printJuggler(int n)
    {
        int a = n;
 
    // print the first term
    Console.Write(a+" ");
 
    // calculate terms until last term is not 1
    while (a != 1)
    {
        int b = 0;
     
        // Check if previous term is even or odd
        if (a%2 == 0)
     
            // calculate next term
                b = (int)Math.Floor(Math.Sqrt(a));
 
        else
 
            // for odd previous term calculate
            // next term
                b =(int) Math.Floor(Math.Sqrt(a) *
                     Math.Sqrt(a) * Math.Sqrt(a));
 
        Console.Write( b+" ");
        a = b;
        }
    }
 
// Driver Code
public static void Main () {
    printJuggler(3);
    Console.WriteLine();
    printJuggler(9);
    }
}