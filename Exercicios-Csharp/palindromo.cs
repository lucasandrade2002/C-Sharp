using System;

namespace Palindromo{
    public class Program{
        static void Main(string[] args){
            string frase = "";
            string nova = "";
            bool palin = false;

            Console.Write("\nDigite uma frase para descobrir se ela é Palíndroma!\n");
            Console.Write("\nA frase não pode conter acentos! ");
            frase = Console.ReadLine();
            
            nova = LimpezaDaFrase(frase);
            palin = VerificaPalindromo(nova);
            
            if(palin){
                Console.Write("\nÉ palíndromo!");
            }else{
                Console.Write("\nNÃO é palíndromo!");
            }
        }
        static string LimpezaDaFrase(string frase){
            int i = 0;
            string novaFrase = "";
            string nova = "";
            string nova2 = "";
            novaFrase = frase.Replace(" ", "");
            for(i = 0; i < novaFrase.Length; i++){
                if(novaFrase[i] != ',' && novaFrase[i] != '!' && novaFrase[i] != '?' && novaFrase[i] != '.' && novaFrase[i] != '-'){
                    nova += novaFrase[i];
                }    
            }
            nova2 = nova.ToLower();
            return nova2;
        }

        static bool VerificaPalindromo(string frase){
            int i = 0, j = 0;
            j = frase.Length - 1;
            /*J recebe o comprimento da frase - 1 porque o número de caracteres da frase
            é de um tamanho, mas o índice começa em 0. Ex: Se uma frase tem 15 caracteres
            o último caractere será o 14, porque a contagem do índice começa em 0*/
            bool palindromo = true;
            for(i = 0; i < frase.Length; i++){
                if(frase[i] != frase[j]){
                    palindromo = false;
                }
                j -= 1;
            }
            return palindromo;
        }
    }
}