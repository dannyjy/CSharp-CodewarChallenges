using System;
using System.Collections.Generic;

namespace Codewars;

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        List<char> dnaChar = dna.ToList();
        string newDnaString = string.Concat(dnaChar.Select((letter) =>
        {
            char character = 'd';
            if(letter == 'A')
                character = 'T';
            if(letter == 'T')
                character = 'A';
            if(letter == 'C')
                character = 'G';
            if(letter == 'G')
                character = 'C';
            
            return character;
        }));
        return newDnaString;
    }
}