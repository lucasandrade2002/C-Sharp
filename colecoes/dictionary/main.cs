using System;
using System.Collections.Generic; //Biblioteca de pacotes para uso de dicionarios;

/* Os dicionários são compostos por chave e valor */

namespace dictionary{
    public class Program{
        static void Main(){
            Dictionary <int, string> veiculos = new Dictionary <int, string>();
            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Avião");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");

            Console.Write("Tamanho do dictionary: {0}\n", veiculos.Count);

            int chave = 0;

            if(veiculos.ContainsKey(chave)){
                Console.Write("A coleção de dados contém a chave {0}", chave);
            }else{
                Console.Write("A coleção de dados não contém a chave {0}", chave);
            }

            //Retorna um inteiro com o número de elementos do Dictionary
            /*Métodos:
                veiculos.Clear(); - Limpa o dicionário
                veiculos.ContainsKey/Value - retorna um boolean
                veiculos.Remove() - Remove um item da coleção. Recebe a chave do elemento
                veiculos[chave] = valor; Podemos adicionar valores através de índices

            */
            veiculos.Remove(5);
            veiculos[10] = "Helicópitero";

            foreach(KeyValuePair <int,string> element in veiculos){
                Console.Write("\nChave: {0} Valor: {1} ", element.Key, element.Value);
            }
        }
    }
}