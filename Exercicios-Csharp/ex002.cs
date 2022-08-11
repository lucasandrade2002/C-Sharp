using System;

/*Formule um algoritmo que entre com o nome do aluno e as notas de quatro provas de 20 alunos.
Imprima nome, nota 1-4 e média de cada aluno. Informe a média geral da turma.*/

namespace EX002{

    public class Aluno{
    public string nome {get;set;}
    public double[] notas = new double[4];
    public double media {get;set;}

    public Aluno(string nome){
        this.nome = nome;
    }

    public double CalculaMedia(double[] notas){
        int i, counter = 0;
        double soma = 0;

        for(i = 0; i < notas.Length; i++){
            soma += notas[i];
            counter++; 
        }
        this.media = soma/counter;
        return this.media;
    }

    public void infoAluno(double[] notasAluno){
        Console.Write("\nNome: {0} \n\nNota 1: {1} \nNota 2: {2} \nNota 3: {3} \nNota 4: {4} \n\nMédia: {5}\n", this.nome, notasAluno[0], notasAluno[1], notasAluno[2], notasAluno[3], this.media);
    }
}
    public class Program{
        static void Main(string[] args){
            int TAM = 0, i = 0, c = 0, j = 0;
            double mediaGeral = 0;
            string nome;

            Console.Write("Bem-vindo(a) ao sistema!!\n");

            Console.Write("\nInforme o tamanho da turma de alunos: ");
            try{
                TAM = Convert.ToInt32(Console.ReadLine());
            }catch{
                Console.Write("\nFormato de dados Inválido!");
            }

            Aluno[] alunos = new Aluno[TAM];
                
            for(i = 0; i < TAM; i++){
                    
                Console.Write("\nInforme o nome do aluno {0}: ", i+1);
                nome = Console.ReadLine();
                alunos[i] = new Aluno(nome);

                for(j = 0; j < 4; j++){
                    Console.Write("\nInforme a nota {0}: ", j+1);
                    try{
                        alunos[i].notas[j] = double.Parse(Console.ReadLine());
                    }catch{
                        Console.Write("Formato de dados Inválido!");
                    }
                }
                Console.Clear();
            }

            Console.Clear();

            Console.Write("\n-------DESEMPENHO DOS ALUNOS-------\n");

            for(c = 0; c < TAM; c++){
                alunos[c].CalculaMedia(alunos[c].notas);
                alunos[c].infoAluno(alunos[c].notas);
                mediaGeral += alunos[c].CalculaMedia(alunos[c].notas);
            }

            Console.Write("\nMÉDIA GERAL DA TURMA: {0}", mediaGeral/TAM);
        }
    }
}