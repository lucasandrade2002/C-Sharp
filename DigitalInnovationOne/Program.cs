using System;

namespace DigitalInnovationOne{
    public struct Aluno{
        public string nome; 
        public double nota;
    }
    class Program{
        static void Main(string[] args){
            Aluno[] alunos = new Aluno[10];
            int escolha, i;

            i = 0;

            Console.Write("\nBem-vindo(a) ao sistema de cadastro de alunos!\n\n");
            Console.Write($"Informe a opção desejada: \n\n1-Cadastrar novo aluno \n2-Listar Alunos \n3-Calcular Geral \n4-Sair do sistema\n\n");
            escolha = Convert.ToInt32(Console.ReadLine());

            while(escolha != 4){
                switch(escolha){
                    case 1:
                        Console.Clear();
                        Aluno aluno_cadastrado = obterAluno();
                        alunos[i] = aluno_cadastrado;
                        Console.Write("\nAluno cadastrado com sucesso!\n");
                        i++;
                        break;
                    case 2:
                        Console.Clear();
                        listarAlunos(alunos);
                        break;
                    case 3:
                        Console.Clear();
                        mediaGeral(alunos);
                        break;
                    default:
                        Console.Write("Opção Inválida!");
                        break;
                }
                escolha = opcaoUsuario();
            }
        }

        static int opcaoUsuario(){
            int option = 0;
            Console.Write("\nInforme a opção desejada: \n\n1-Cadastrar novo aluno \n2-Listar Alunos \n3-Calcular Geral \n4-Sair do sistema\n\n");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        static Aluno obterAluno(){

            Console.Write("Informe o nome do aluno: ");
            Aluno aluno = new Aluno();
            aluno.nome = Console.ReadLine();

            Console.Write("Informe a nota do aluno: ");
            if(double.TryParse(Console.ReadLine(), out double nota)){
                aluno.nota = nota;
            }else{
                throw new Exception("O valor da nota deve ser do tipo Double");
            }
            return aluno;
        }

        static void listarAlunos(Aluno[] registros){
            for(int i = 0; i < registros.Length; i++){
                if(registros[i].nome != null){
                Console.Write("Nome: {0} \nNota: {1}", registros[i].nome, registros[i].nota);
                Console.Write("\n----------------------\n");
            }
            }
        }

        static void mediaGeral(Aluno[] registros){
            int i = 0, count = 0;
            double soma = 0, media = 0;

            for(i = 0; i < registros.Length; i++){
                if(registros[i].nome != null){
                soma += registros[i].nota;
                count++;
            }
        }
            media = soma/count;

            Console.Write($"\nA média geral é de {media}\n");
        }
    }
}
