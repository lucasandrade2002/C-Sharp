using System;

/*Escreva um algoritmo que leia 20 nomes e imprima o primeiro caractere de cada nome*/

namespace EX001{
    public class Program{
        static void Main(){

            string[] nomes = new string[20];
            int i = 0;

            for(i = 0; i < 20; i++){
                Console.Write("Escreva um nome: ");
                nomes[i] = Console.ReadLine();
            }

            i = 0;

            while(i < 20){
                Console.Write("\nA primeira letra do nome: {0} é {1}", nomes[i], nomes[i][0]);
                i++;
            }
        }
    }
}