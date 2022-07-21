using System;
using System.Collections.Generic;

//First in, first out; 
//Primeiro a entrar é o primeiro a sair;

namespace Fila{
    public class Program{
        static void Main(){
            string[] array = {"Carro", "Moto", "Avião", "Navio", "Caminhão", "Ônibus"};
            Queue <string> veiculos = new Queue <string>(array);

            /*Não aceita indexação*/
            
            veiculos.Enqueue("Picape"); 
            //Adiciona elementos no final da fila;

            veiculos.Dequeue();
            //Remove o primeiro elemento da lista;

            //fila.Contains(element) -> Verifica se um elemento faz parte da fila;
            //fila.Clear() -> Fila é limpa;

            Console.Write("\nQuantidade de elementos fila: {0}", veiculos.Count);
            //Retorna a quantidade de elementos de uma lista;

            Console.Write("\nElemento n°1 {0}\n", veiculos.Peek());
            //Retorna o primeiro elemento da Fila;

            foreach(string element in veiculos){
                Console.Write("\n{0}", element);
            }
        }
    }
}