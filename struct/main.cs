using System;

public struct dados{
        public string nome;
        public int idade;
        public char sexo;
    }

//Structs podem ter construtores.

public class Program{

    static void Main(){
        
        dados pessoa;
        pessoa.nome = "Lucas Andrade";
        pessoa.idade = 20;
        pessoa.sexo = 'M';
        Console.Write("Nome: {0} \nIdade: {1} \nSexo: {2}", pessoa.nome, pessoa.idade, pessoa.sexo);
    }
}