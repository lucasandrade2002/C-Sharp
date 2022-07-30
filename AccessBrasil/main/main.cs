using System;

namespace CalculaEficiencia{
    public class Turma{
        public string id {get;set;}
        public double media {get;set;}
        public void CalculaMedia(double[] notas){
            int i;
            double soma = 0, counter = 0;

            if(notas.Length <= 1){
                Console.Write("A quantidade de notas informadas é insuficiente para realizar o cálculo!");
            }else{
                for(i = 0; i < notas.Length; i++){
                    soma += notas[i];
                    counter++;
                }
                this.media = soma/counter;
                Console.Write("\nA média da turma {0} é: {1}", this.id, this.media.ToString("N3")); 
            }
        }

        public void alunosAcimaDaMedia(double[] notas){
            int i = 0;
            double qtde = 0, percentual = 0;

            if(notas.Length >= 2){

            for(i = 0; i < notas.Length; i++){
                if(notas[i] > this.media){
                    qtde++;
                }
            }
            percentual = (qtde * 100.00)/notas.Length;
            Console.Write("\nA eficiência/percentual de alunos que estão acima da média é de: {0}%", percentual.ToString("N3"));
            }else{
                return;
            }
        }
    }

    public class Program{
        static void Main(){
            int i = 0, counter = 0, qtde = 0;
            Turma turma = new Turma();

            Console.WriteLine("\nBem-vindo(a) ao sistema de Cálculo de Médias!\n");

            Console.Write("Informe o ID da turma: ");
            turma.id = Console.ReadLine();

            qtde_notas:
            Console.Write("\nInforme a quantidade de notas que irá calcular: ");
            try{
                qtde = Convert.ToInt32(Console.ReadLine());
            }catch{
                Console.Write("Argumentos Inválidos!");
                goto qtde_notas;
            }
            
            Console.Write("\nAgora informe as notas de cada aluno da turma {0}.\n\n", turma.id);

            double[] notas = new double[qtde];

            do{
                Console.Write("Nota {0}: ", i+1);
                try{
                    notas[i] = double.Parse(Console.ReadLine());
                }catch{
                    throw new Exception("Argumentos Inválidos! O tipo de dado passado deve ser do tipo Double");
                }
                i++;
                counter++;
            }while(i < qtde);

            Console.Clear();
            Console.Write("\n-----------Desempenho da turma-----------\n");
            turma.CalculaMedia(notas);
            turma.alunosAcimaDaMedia(notas);
        }
    }
}