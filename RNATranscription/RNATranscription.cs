using System;
using System.Text;
using System.Collections.Generic;
namespace RNATranscriptionModule
{
   public static class RnaTranscription
   {
               static void Main(string[] args)
               {}
   static readonly IReadOnlyDictionary<char, char> dna = new Dictionary<char, char>
   {
       ['G'] = 'C',
       ['C'] = 'G',
       ['T'] = 'A',
       ['A'] = 'U',
   };
   public static string ToRna(string nucleotide){
           StringBuilder rna = new StringBuilder(nucleotide);
             for(int i=0;i<nucleotide.Length;i++){
                   rna[i] = dna[rna[i]];
             }
             return rna.ToString();
   }
   }
}