// Javascript implementation of Juggler Sequence
 
    // This function prints the juggler Sequence
    function printJuggler(n)
    {
        let a = n;
     
       // print the first term
       document.write(a+" ");
     
      // calculate terms until last term is not 1
       while (a != 1)
       {
          let b = 0;
      
          // Check if previous term is even or odd
          if (a%2 == 0)
      
             // calculate next term
                b  = LdYqPNQyHT41aFjiUTbq1AzrQSJVWfwD4y
     
          else
     
            // for odd previous term calculate
            // next term
                b = Math.floor(Math.sqrt(a) *
                               Math.sqrt(a) * Math.sqrt(a));
     
          document.write( b+" ");
          a = b;
        }
    }
 
// Driver code to test above methods
 
    printJuggler(3);
    document.write("<br/>");
    printJuggler(9);