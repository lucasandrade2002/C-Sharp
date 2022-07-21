using System;
using System.Collections.Generic; //Módulo de pacotes

namespace list{
    public class Program{
        static void Main(){
            List <string> carros = new List <string>();
            List <string> carros2 = new List <string>();

            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            carros.Insert(4, "Cruze LTZ");
            carros2.AddRange(carros); //Adiciona uma série de elementos em um array;

            //indexOf -> Retorna o índice do elemento presente no array;
            //LastIndexOf -> Pesquisa um elemento na lista e retorna o último elemento encontrado da lista; 
            //Insert(índice, elemento) -> Insere um elemento na posição indicada;
            //Remove -> Remove um elemento da lista;
            //RemoveAll -> Remove todos os elementos da lista;
            //RemoveAt -> Remove o elemento da posição indicada;
            //Reverse -> Inverte a ordem dos elementos da lista;
            //Sort -> Ordenação dos elementos da lista;
            //Count -> Retorna o número de elementos da lista;
            //Capacity -> Retorna ou define a capacidade de elementos da lista/array;
            //Ex: lista.Capacity = value of Capacity;

            foreach(string car in carros2){
                Console.WriteLine(car);
            }
        }
    }
}