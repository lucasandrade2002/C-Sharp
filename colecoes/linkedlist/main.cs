using System;
using System.Collections.Generic;

namespace Linkedlist{
    public class Program{
        static void Main(){

            LinkedList<string> transp = new LinkedList<string>();

            transp.AddFirst("Avião");
            transp.AddFirst("Carro");
            transp.AddFirst("Moto");
            transp.AddFirst("Helicópitero");

            transp.AddLast("Navio");

            LinkedListNode <string> no; //Declaração do Nó;
            no = transp.FindLast("Moto"); //Atribuição do nó
            transp.AddAfter(no,"Bicicleta"); //Adição de um elemento posterior ao nó;

            foreach(string value in transp){
                Console.Write("\nVeículo: {0}", value);
            }
        }
    }
}